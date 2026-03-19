# CopyUIAComWrapper.ps1
# Copies UIAComWrapper.dll from installed Visual Studio versions into
# .\src\ThirdParty\CUIT\vXX\ for source control.
#
# UIAComWrapper is referenced (without HintPath) for VS2015 (v14),
# VS2017 (v15), and VS2019 (v16) in CodedUITests.targets.
#
# Run this script ONCE on a machine that has the required VS versions installed.
# After running, check in the updated ThirdParty\CUIT\ directory so builds
# no longer require Visual Studio to be installed.
#
# Usage: .\build\CopyUIAComWrapper.ps1
[CmdletBinding()]
param()

$VerbosePreference = 'Continue'
$ErrorActionPreference = 'Stop'

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$repoRoot = Split-Path -Parent $scriptDir
$thirdPartyBase = Join-Path $repoRoot 'src\ThirdParty\CUIT'

$dllName = 'UIAComWrapper.dll'

# Map of VS version tag -> possible installation paths (searched in order)
# UIAComWrapper lives in the TestPlatform extensions or PublicAssemblies
$vsVersions = [ordered]@{
    'v14' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio 14.0\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio 14.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow"
    )
    'v15' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\Extensions\TestPlatform"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\Professional\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\Community\Common7\IDE\PublicAssemblies"
    )
    'v16' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\Extensions\TestPlatform"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Professional\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Community\Common7\IDE\PublicAssemblies"
    )
}

$copiedCount = 0
$skippedCount = 0

foreach ($entry in $vsVersions.GetEnumerator()) {
    $versionTag = $entry.Key
    $searchPaths = $entry.Value
    $destDir = Join-Path $thirdPartyBase $versionTag

    $found = $false
    foreach ($searchPath in $searchPaths) {
        $dllPath = Join-Path $searchPath $dllName
        if (Test-Path $dllPath) {
            if (-not (Test-Path $destDir)) {
                New-Item -Path $destDir -ItemType Directory -Force | Out-Null
            }

            Write-Host "[$versionTag] Copying from: $searchPath" -ForegroundColor Cyan
            Copy-Item -Path $dllPath -Destination $destDir -Force
            Write-Host "  Copied: $dllName" -ForegroundColor Green

            $copiedCount++
            $found = $true
            break
        }
    }

    if (-not $found) {
        Write-Host "[$versionTag] SKIPPED - $dllName not found in any search path" -ForegroundColor Yellow
        $skippedCount++
    }
}

Write-Host ""
Write-Host "Summary: $copiedCount copied, $skippedCount skipped" -ForegroundColor White
Write-Host "Output directory: $thirdPartyBase" -ForegroundColor White

if ($copiedCount -gt 0) {
    Write-Host ""
    Write-Host "Next steps:" -ForegroundColor White
    Write-Host "  1. Check in the updated ThirdParty\CUIT\ directory to source control" -ForegroundColor White
    Write-Host "  2. CodedUITests.targets already provides HintPaths for UIAComWrapper" -ForegroundColor White
}
