# CopyMSTestFramework.ps1
# Copies Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll from installed
# Visual Studio versions into .\src\ThirdParty\MSTest\vXX\ for source control.
#
# Run this script ONCE on a machine that has the required VS versions installed.
# After running, check in the ThirdParty\MSTest\ directory so builds no longer
# require Visual Studio to be installed.
#
# Usage: .\build\CopyMSTestFramework.ps1
[CmdletBinding()]
param()

$VerbosePreference = 'Continue'
$ErrorActionPreference = 'Stop'

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$repoRoot = Split-Path -Parent $scriptDir
$thirdPartyBase = Join-Path $repoRoot 'src\ThirdParty\MSTest'

$dllName = 'Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll'
$xmlName = 'Microsoft.VisualStudio.QualityTools.UnitTestFramework.xml'

# Map of VS version tag -> possible installation paths (searched in order)
$vsVersions = [ordered]@{
    'v10' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio 10.0\Common7\IDE\PublicAssemblies"
    )
    'v11' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio 11.0\Common7\IDE\PublicAssemblies"
    )
    'v12' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio 12.0\Common7\IDE\PublicAssemblies"
    )
    'v14' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio 14.0\Common7\IDE\PublicAssemblies"
    )
    'v15' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\Professional\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2017\Community\Common7\IDE\PublicAssemblies"
    )
    'v16' = @(
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Professional\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Community\Common7\IDE\PublicAssemblies"
    )
    'v17' = @(
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Professional\Common7\IDE\PublicAssemblies"
        "${env:ProgramFiles}\Microsoft Visual Studio\2022\Community\Common7\IDE\PublicAssemblies"
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

            # Also copy the XML doc file if available
            $xmlPath = Join-Path $searchPath $xmlName
            if (Test-Path $xmlPath) {
                Copy-Item -Path $xmlPath -Destination $destDir -Force
                Write-Host "  Copied: $xmlName" -ForegroundColor Green
            }

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
    Write-Host "  1. Check in the ThirdParty\MSTest\ directory to source control" -ForegroundColor White
    Write-Host "  2. The MSTest.targets file provides HintPaths for these DLLs" -ForegroundColor White
}
