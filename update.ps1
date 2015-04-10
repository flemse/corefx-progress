# NOTE: This tool isn't designed to run outside of the Microsoft network,
# sorry about that. The purpose of this script is to allow us to easily update
# this repo which is only provided to allow you track our progress towards
# open sourcing .NET Core.
#
# Once all libraries are open sourced and on NuGet, this repo will go away.

# Variables

$asmdiff = "\\fxcore\tools\bin\AsmDiff.exe"
$contractsFolder = '\\cpvsbuild\drops\dev14\ProjectK\raw\current\binaries.x86ret\ref\ProjectK'
$corefxUrl = 'https://github.com/dotnet/corefx'
$corefxFolder = 'corefx'

$libFullFolder = "lib-full"
$libOssFolder = "lib-oss"
$srcFullFolder = "src-full"
$srcOssFolder = "src-oss"
$srcDiffFolder = "src-diff"
$summaryFile = "src-diff\README.md"
$progressPng = $PSScriptRoot + "\progress.png"

# Functions

function update-lib-full($libFolder)
{
    # Get full list of .NET Core libraries, but exclude old-style facades.

    $files = ls $contractsFolder -fi *.dll -rec |
             ? { $_.Name.StartsWith("Microsoft") -or $_.Name.StartsWith("System") } |
             ? { $_.BaseName -ne 'System' } |
             ? { $_.BaseName -ne 'System.ComponentModel.DataAnnotations' } |
             ? { $_.BaseName -ne 'System.Core' } |
             ? { $_.BaseName -ne 'System.Net' } |
             ? { $_.BaseName -ne 'System.Numerics' } |
             ? { $_.BaseName -ne 'System.Runtime.Serialization' } |
             ? { $_.BaseName -ne 'System.ServiceModel' } |
             ? { $_.BaseName -ne 'System.ServiceModel.Web' } |
             ? { $_.BaseName -ne 'System.Windows' } |
             ? { $_.BaseName -ne 'System.Xml' } |
             ? { $_.BaseName -ne 'System.Xml.Linq' } |
             ? { $_.BaseName -ne 'System.Xml.Serialization' }

    # Update lib folder

    if (test-path $libFolder) {
        rm $libFolder -rec -force
    }

    mkdir $libFolder | out-null
    $files | % { cp $_.FullName $libFolder -force }
}

function update-lib-oss($libFolder)
{
    # Build a local copy of the CoreFX repo

    if (-not (Test-Path corefx) ) {

        git clone $corefxUrl $corefxFolder
        & "$corefxFolder\build.cmd" /p:SkipTests=true /p:SkipBuildPackages=true

    }

    # Create a single folder with the relevant binaries, i.e. no test
    # and internal artifacts.

    $files = ls "$corefxFolder\bin" -fi *.dll -rec |
             ? { $_.Name.StartsWith("System.") -or $_.Name.StartsWith("Microsoft.") } |
             ? { -not $_.FullName.ToLower().Contains("test") }

    # Copy those files to another folder

    rm $libFolder -rec -force -ErrorAction Ignore
    mkdir $libFolder | out-null
    $files | % { cp $_.FullName $libFolder -force }

    rm $corefxFolder -rec -force
}

function update-src($libFolder, $srcFolder)
{
    # We want to skip the first line of AsmDiff's output as it contains
    # the file name. This makes it harder to later on generate the
    # overview table.

    rm $srcFolder -rec -force -erroraction ignore
    mkdir $srcFolder | out-null

    $files = ls $libFolder
    foreach ($file in $files)
    {
        $fileName = $srcFolder + "\" + $file.BaseName + ".cs"
        & $asmdiff $file.FullName -syntax:text |
            select -skip 1 |
            out-file $fileName -encoding utf8
    }
}

function update-diff($lib1, $lib2, $resultFolder)
{
    # Create a set of all the DLL names (union of $lib1 and $lib2)

    $nameset = new-object 'System.Collections.Generic.HashSet[string]'

    $files1 = ls $lib1 | % { $_.Name }
    $files2 = ls $lib2 | % { $_.Name }
 
    $files1 | % { $nameset.Add($_) } | out-null
    $files2 | % { $nameset.Add($_) } | out-null

    # Now run a diff between $lib1 and $lib2.
    #
    # The nice thing is that AsmDiff allows files to not exist. So if a
    # file only exists in $lib1 but not in $lib2, all its contents will
    # show up as removed.

    rm $resultFolder -rec -force -erroraction ignore
    mkdir $resultFolder | out-null
    $nameset |
        % { & $asmdiff "$lib1\$_" "$lib2\$_" -added -removed -unchanged -changed -syntax:diff -out ($resultFolder + "\" + $_.Replace(".dll", ".md")) }

    # In oder to make these files valid Markdown files, we need to
    # surround the unified diff with a fenced code block

    foreach ($file in (ls $resultFolder))
    {
        -join '```diff', (gc $file.FullName), '```' | out-file $file.FullName -encoding utf8
    }
}

function update-table($src1, $src2, $resultFile)
{
    $files1 = ls $src1 | sort $_.BaseName
    $lines =  new-object 'System.Collections.Generic.List[string]'

    $lines.Add('# .NET Core: Library Open Source Progress')
    $lines.Add('')
    $lines.Add('Assembly Name | Status')
    $lines.Add('------------- | ------')

    foreach ($file1 in $files1)
    {
        $file2 = $src2 + '\' + $file1.Name

        if (test-path $file2)
        {
            $status = 'Done'
        }
        else
        {
            $status = 'Coming'
        }

        $assemblyName = $file1.BaseName
        $asssemblyDiffPath = $file1.BaseName + '.md'

        $lines.Add("[$assemblyName]($asssemblyDiffPath) | $status")
    }

    $lines | out-file $resultFile -encoding utf8
}

function update-chart($src1, $src2, $resultFile)
{
    # Compute #done, #coming

    $done = 0.0
    $coming = 0.0

    $files1 = ls $src1 | sort $_.BaseName

    foreach ($file1 in $files1)
    {
        $file2 = $src2 + '\' + $file1.Name

        if (test-path $file2)
        {
            $done = $done + 1
        }
        else
        {
            $coming = $coming + 1
        }
    }

    $total = $done + $coming
    $donePercent = $done / $total
    $comingPercent = $coming /  $total

    # Render the chart

    [void][Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms")
    [void][Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms.DataVisualization")

    $chart = New-object System.Windows.Forms.DataVisualization.Charting.Chart
    $chart.Width = 600
    $chart.Height = 300

    # Add Title

    $title = $chart.Titles.Add("text1")
    $title.Text = "GitHub Availability of .NET Core APIs"
    $title.Font = New-Object System.Drawing.Font("Calibri", 18)

    # Add chart

    $area = $chart.ChartAreas.Add("area1")
    $area.Area3DStyle.Enable3D = $true

    # Add series

    $series = $chart.Series.Add("series1")
    $series.ChartType = [System.Windows.Forms.DataVisualization.Charting.SeriesChartType]::Pie

    # Data

    $p1 = New-object System.Windows.Forms.DataVisualization.Charting.DataPoint
    $p1.AxisLabel = [string]::Format("Coming {0:P0}", $comingPercent)
    $p1.Color = [System.Drawing.Color]::Orange
    $p1.LabelForeColor = [System.Drawing.Color]::White
    $p1.LabelBackColor = [System.Drawing.Color]::Black
    $p1.Font = New-Object System.Drawing.Font("Calibri", 10)
    $p1.YValues = [System.Double[]] @($comingPercent)
    $series.Points.Add($p1)

    $p2 = New-object System.Windows.Forms.DataVisualization.Charting.DataPoint
    $p2.AxisLabel = [string]::Format("Done {0:P0}", $donePercent)
    $p2.Color = [System.Drawing.Color]::DodgerBlue
    $p2.LabelForeColor = [System.Drawing.Color]::White
    $p2.LabelBackColor = [System.Drawing.Color]::Black
    $p2.Font = New-Object System.Drawing.Font("Calibri", 10)
    $p2.YValues = [System.Double[]] @($donePercent)
    $series.Points.Add($p2)

    $chart.SaveImage($resultFile, [System.Windows.Forms.DataVisualization.Charting.ChartImageFormat]::Png)
}

# Main flow

update-lib-full $libFullFolder
update-lib-oss $libOssFolder

update-src $libFullFolder $srcFullFolder
update-src $libOssFolder $srcOssFolder

update-diff $libFullFolder $libOssFolder $srcDiffFolder
update-table $srcFullFolder $srcOssFolder $summaryFile
update-chart $srcFullFolder $srcOssFolder $progressPng