# Enable -Verbose option
[CmdletBinding()]

# Set a flag to force verbose as a default
$VerbosePreference ='Continue' # equiv to -verbose

if (Test-Path "$env:ChocolateyInstall\logs") 
{
    Copy-Item -Path "$env:ChocolateyInstall\logs" -Destination "$env:BUILD_ARTIFACTSTAGINGDIRECTORY" –Recurse
}

if (Test-Path "$env:TEMP\chocolatey") 
{
    Copy-Item -Path "$env:TEMP\chocolatey" -Destination "$env:BUILD_ARTIFACTSTAGINGDIRECTORY" –Recurse
}

if (Test-Path "$env:ChocolateyInstall\config") 
{
    Copy-Item -Path "$env:ChocolateyInstall\config" -Destination "$env:BUILD_ARTIFACTSTAGINGDIRECTORY" –Recurse
}