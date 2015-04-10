.\update.ps1

$availabilityHasChanged = -not [string]::IsNullOrEmpty( (git diff --name-only -- src-diff) )

if (-not $availabilityHasChanged)
{
    # The effective diff hasn't changed. Reset all pending changes.
    git reset --hard
}
else
{
    # The effective diff has changed, so we'll commit & push.
    git add -A
    git commit -m 'Update progress'
    git push origin master
}