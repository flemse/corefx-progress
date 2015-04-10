 # Update our copy of corefx-progress

 git fetch origin master
 git merge origin/master --ff-only

# Update the binaries and the diffs

.\update.ps1

# Compute whether the effective diff has changed.

$availabilityHasChanged = -not [string]::IsNullOrEmpty( (git diff --name-only -- src-diff) )

# Now reset or commit+push.

if (-not $availabilityHasChanged)
{
    # The effective diff hasn't changed. Reset all pending changes.
    echo 'Nothing changed -- resetting...'
    git reset --hard
}
else
{
    # The effective diff has changed, so we'll commit & push.
    echo 'Updating official copy...'
    git add -A
    git commit -m 'Update progress'
    git push origin master
}