# Install common dependencies shared across all VS version builds.
# This includes Silverlight, Firefox, Selenium components, drivers, and security settings.

# Enable -Verbose option
[CmdletBinding()]

# Set a flag to force verbose as a default
$VerbosePreference = 'Continue' # equiv to -verbose

. "$Env:BUILD_SOURCESDIRECTORY\build\ProcessRunner.ps1"

$webclient = New-Object System.Net.WebClient

# Set default Chocolatey execution timeout to infinite
$exitCode = Run-Process -FilePath "choco.exe" -ArgumentList "config set commandExecutionTimeoutSeconds 0"
if ($exitCode -ne 0)
{
    throw "Command failed with exit code $exitCode."
}

$depsPath = Join-Path $env:AGENT_BUILDDIRECTORY '.deps'
Write-Host $depsPath
if (-not(Test-Path -Path $depsPath -PathType Container)) {
    New-Item -Path $depsPath -ItemType Directory
}

# Internet Explorer
# On Windows Server, IE is an optional feature that may not be enabled by default.
# Coded UI Tests require IE to be available for COM automation (InternetExplorer.Application).
$ieExe = Join-Path $env:ProgramFiles "Internet Explorer\iexplore.exe"
if (-not (Test-Path $ieExe)) {
    Write-Host "Internet Explorer not found. Attempting to enable Windows feature..."
    $result = dism /online /Enable-Feature /FeatureName:Internet-Explorer-Optional-amd64 /All /NoRestart 2>&1
    if ($LASTEXITCODE -eq 0) {
        Write-Host "Internet Explorer feature enabled successfully" -ForegroundColor Green
    } else {
        Write-Warning "Could not enable Internet Explorer feature (exit code: $LASTEXITCODE)"
        Write-Host $result
    }
} else {
    Write-Host "Internet Explorer is available at: $ieExe"
}

# Microsoft Silverlight 5
Write-Host "Downloading Microsoft Silverlight 5 (64 bit) 5.1.50918.00..."
$exeFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\Silverlight_x64.exe"
if (-not(Test-Path -Path $exeFilePath -PathType Leaf)) {
    $retry_attempts = 3
    for($i=0; $i -lt $retry_attempts; $i++){
        try {
            $webclient.DownloadFile('https://web.archive.org/web/20211013031912if_/https://download.microsoft.com/download/D/D/F/DDF23DF4-0186-495D-AA35-C93569204409/50918.00/Silverlight_x64.exe', $exeFilePath)
            break
        }
        Catch [Exception]{
            Start-Sleep 1
        }
    }
}
Write-Host "Installing Microsoft Silverlight 5 (64 bit) 5.1.50918.00..."
$exitCode = Run-Process -FilePath $exeFilePath -ArgumentList "/q"
if ($exitCode -ne 0)
{
    throw "Command failed with exit code $exitCode."
}
if (Test-Path $exeFilePath)
{
    Remove-Item $exeFilePath
}
Write-Host "Microsoft Silverlight 5 (64 bit) 5.1.50918.00 successfully installed" -ForegroundColor Green

$registryPath = "HKCU\Software\Microsoft\Windows\CurrentVersion\Ext"
if (Test-Path -Path "HKCU:\Software\Microsoft\Windows\CurrentVersion\Ext")
{
    Write-Host "Registry path '$registryPath' exists."
    $exitCode = Run-Process -FilePath "reg.exe" -ArgumentList "export $registryPath ""$env:BUILD_ARTIFACTSTAGINGDIRECTORY\HKCU_Software_Microsoft_Windows_CurrentVerison_Ext.reg"""
    if ($exitCode -ne 0)
    {
        throw "Command failed with exit code $exitCode."
    }
}
else
{
    Write-Host "Registry path '$registryPath' doesn't exist."
}

$registryPath = "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Ext"
if (Test-Path -Path "HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Ext")
{
    Write-Host "Registry path '$registryPath' exists."

    $exitCode = Run-Process -FilePath "reg.exe" -ArgumentList "export $registryPath ""$env:BUILD_ARTIFACTSTAGINGDIRECTORY\HKLM_Software_Microsoft_Windows_CurrentVerison_Ext.reg"""
    if ($exitCode -ne 0)
    {
        throw "Command failed with exit code $exitCode."
    }
}
else
{
    Write-Host "Registry path '$registryPath' doesn't exist."
}

# Microsoft Silverlight 5 SDK
Write-Host "Downloading Microsoft Silverlight 5 SDK..."
$exeFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\silverlight_sdk.exe"
if (-not(Test-Path -Path $exeFilePath -PathType Leaf)) {
    $webclient.DownloadFile('https://web.archive.org/web/20190126163602if_/http://download.microsoft.com/download/3/A/3/3A35179D-5C87-4D0A-91EB-BF5FEDC601A4/sdk/silverlight_sdk.exe', $exeFilePath)
}
$logFilePath = "$($env:TEMP)\silverlight_sdk.txt"
Write-Host "Installing Microsoft Silverlight 5 SDK..."
$exitCode = Run-Process -FilePath $exeFilePath -ArgumentList "/qb /norestart /l*v $logFilePath"
if ($exitCode -ne 0)
{
    if (Test-Path $logFilePath)
    {
        Get-Content $logFilePath
    }
    throw "Command failed with exit code $exitCode."
}
if (Test-Path $exeFilePath)
{
    Remove-Item $exeFilePath
}
if (Test-Path $logFilePath)
{
    Remove-Item $logFilePath
}
Write-Host "Microsoft Silverlight 5 SDK successfully installed" -ForegroundColor Green

# Microsoft Silverlight 5 Toolkit - December 2011
Write-Host "Downloading Microsoft Silverlight 5 Toolkit - December 2011..."
$msiFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\Silverlight_5_Toolkit_December_2011.msi"
if (-not(Test-Path -Path $msiFilePath -PathType Leaf)) {
    $webclient.DownloadFile('https://github.com/MicrosoftArchive/SilverlightToolkit/releases/download/5/Silverlight_5_Toolkit_December_2011.1.msi', $msiFilePath)
}
$logFilePath = "$($env:TEMP)\Silverlight_5_Toolkit_December_2011.txt"
Write-Host "Installing Microsoft Silverlight 5 Toolkit - December 2011..."
$exitCode = Run-Process -FilePath "msiexec.exe" -ArgumentList "/i $msiFilePath /quiet /l*v $logFilePath"
if ($exitCode -ne 0)
{
    if (Test-Path $logFilePath)
    {
        Get-Content $logFilePath
    }
    throw "Command failed with exit code $exitCode."
}
if (Test-Path $msiFilePath)
{
    Remove-Item $msiFilePath
}
if (Test-Path $logFilePath)
{
    Remove-Item $logFilePath
}
Write-Host "Microsoft Silverlight 5 Toolkit - December 2011 successfully installed" -ForegroundColor Green

# Microsoft Silverlight 5 Developer Runtime for Windows (64 bit) 5.1.50918.00
# https://www.microsoft.com/en-us/download/details.aspx?id=57768
Write-Host "Downloading Microsoft Silverlight 5 Developer Runtime for Windows (64 bit) 5.1.50918.00..."
$exeFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\Silverlight_Developer_x64.exe"
if (-not(Test-Path -Path $exeFilePath -PathType Leaf)) {
    $retry_attempts = 3
    for($i=0; $i -lt $retry_attempts; $i++){
        try {
            $webclient.DownloadFile('https://web.archive.org/web/20210306113945if_/https://download.microsoft.com/download/D/D/F/DDF23DF4-0186-495D-AA35-C93569204409/50918.00/Silverlight_Developer_x64.exe', $exeFilePath)
            break
        }
        Catch [Exception]{
            Start-Sleep 1
        }
    }
}
Write-Host "Installing Microsoft Silverlight 5 Developer Runtime for Windows (64 bit) 5.1.50918.00..."
$exitCode = Run-Process -FilePath $exeFilePath -ArgumentList "/q"
if ($exitCode -ne 0)
{
    throw "Command failed with exit code $exitCode."
}
if (Test-Path $exeFilePath)
{
    Remove-Item $exeFilePath
}
Write-Host "Microsoft Silverlight 5 Developer Runtime for Windows (64 bit) 5.1.50918.00 successfully installed" -ForegroundColor Green

# Uninstall Mozilla Firefox (64-bit)
Write-Host "Uninstalling Mozilla Firefox (64-bit)..."
$exeFilePath = "${Env:ProgramFiles}\Mozilla Firefox\uninstall\helper.exe"
$exitCode = Run-Process -FilePath $exeFilePath -ArgumentList "/s"
if ($exitCode -ne 0)
{
    throw "Command failed with exit code $exitCode."
}
Write-Host "Mozilla Firefox (64-bit) successfully uninstalled."

# Mozilla Firefox 47.0.1
Write-Host "Downloading Mozilla Firefox 47.0.1..."
$exeFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\Firefox Setup 47.0.1.exe"
if (-not(Test-Path -Path $exeFilePath -PathType Leaf)) {
    $retry_attempts = 3
    for($i=0; $i -lt $retry_attempts; $i++){
        try {
            $webclient.DownloadFile('http://ftp.mozilla.org/pub/mozilla.org/firefox/releases/47.0.1/win32/en-US/Firefox%20Setup%2047.0.1.exe', $exeFilePath)
            break
        }
        Catch [Exception]{
            Start-Sleep 1
        }
    }
}
Write-Host "Installing Mozilla Firefox 47.0.1..."
$exitCode = Run-Process -FilePath $exeFilePath -ArgumentList "-ms"
if ($exitCode -ne 0)
{
    throw "Command failed with exit code $exitCode."
}
if (Test-Path $exeFilePath)
{
    Remove-Item $exeFilePath
}
Write-Host "Mozilla Firefox 47.0.1 successfully installed" -ForegroundColor Green

# Configure Firefox for first run
Write-Host "Configuring Mozilla Firefox for first run..."
$firefoxPath = "${Env:ProgramFiles(x86)}\Mozilla Firefox"
Copy-Item -path "$Env:BUILD_SOURCESDIRECTORY\build\Firefox\override.ini" -Destination "$firefoxPath\browser\override.ini"
Copy-Item -path "$Env:BUILD_SOURCESDIRECTORY\build\Firefox\local-settings.js" -Destination "$firefoxPath\defaults\pref\local-settings.js"
Copy-Item -path "$Env:BUILD_SOURCESDIRECTORY\build\Firefox\mozilla.cfg" -Destination "$firefoxPath\mozilla.cfg"
Write-Host "Mozilla Firefox configured successfully" -ForegroundColor Green

Write-Host "Creating default Mozilla Firefox profile..."
$exitCode = Run-Process -FilePath "$firefoxPath\firefox.exe" -ArgumentList "-CreateProfile default"
if ($exitCode -ne 0)
{
    throw "Command failed with exit code $exitCode."
}
Write-Host "Default Mozilla Firefox profile created successfully" -ForegroundColor Green

# Selenium components for Coded UI Cross Browser Testing Version 1.7
Write-Host "Downloading Selenium components for Coded UI Cross Browser Testing Version 1.7..."
$msiFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\CodedUITestCrossBrowserSetup.msi"
if (-not(Test-Path -Path $msiFilePath -PathType Leaf)) {
    $webclient.DownloadFile('https://atinbansal.gallerycdn.vsassets.io/extensions/atinbansal/seleniumcomponentsforcodeduicrossbrowsertesting/1.7/1482138134269/85444/13/CodedUITestCrossBrowserSetup.msi', $msiFilePath)
}
$logFilePath = "$($env:TEMP)\CodedUITestCrossBrowserSetup.txt"
Write-Host "Installing Selenium components for Coded UI Cross Browser Testing Version 1.7..."
$exitCode = Run-Process -FilePath "msiexec.exe" -ArgumentList "/i $msiFilePath /quiet /l*v $logFilePath"
if ($exitCode -ne 0)
{
    if (Test-Path $logFilePath)
    {
        Get-Content $logFilePath
    }
    throw "Command failed with exit code $exitCode."
}
if (Test-Path $msiFilePath)
{
    Remove-Item $msiFilePath
}
if (Test-Path $logFilePath)
{
    Remove-Item $logFilePath
}
Write-Host "Selenium components for Coded UI Cross Browser Testing Version 1.7 successfully installed" -ForegroundColor Green

# Google Chrome driver 2.27
Write-Host "Downloading Google Chrome driver 2.27..."
$zipPath = "$Env:AGENT_BUILDDIRECTORY\.deps\chromedriver_win32.zip"
if (-not(Test-Path -Path $zipPath -PathType Leaf)) {
    $webclient.DownloadFile('http://chromedriver.storage.googleapis.com/2.27/chromedriver_win32.zip', $zipPath)
}
Write-Host "Installing Google Chrome driver 2.27..."
7z x $zipPath -y -o"$($ProgramFiles)\Common Files\Microsoft Shared\VSTT\Cross Browser Selenium Components" | Out-Null
Write-Host "Google Chrome driver 2.27 successfully installed" -ForegroundColor Green

# Mozilla Firefox driver v0.17.0 (Win32)
Write-Host "Downloading Mozilla Firefox driver v0.17.0  (Win32)..."
$zipPath = "$Env:AGENT_BUILDDIRECTORY\.deps\geckodriver-v0.17.0-win32.zip"
if (-not(Test-Path -Path $zipPath -PathType Leaf)) {
    $webclient.DownloadFile('https://github.com/mozilla/geckodriver/releases/download/v0.17.0/geckodriver-v0.17.0-win32.zip', $zipPath)
}
Write-Host "Installing Mozilla Firefox driver v0.17.0  (Win32)..."
7z x $zipPath -y -o"$($ProgramFiles)\Common Files\Microsoft Shared\VSTT\Cross Browser Selenium Components" | Out-Null
Write-Host "Mozilla Firefox driver v0.17.0  (Win32) successfully installed" -ForegroundColor Green

# Load remote sources with full trust
$ConfigFilePath = ${Env:ProgramFiles(x86)} + "\Microsoft Visual Studio 14.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe.config"
if (Test-Path -Path $ConfigFilePath) {
    [xml]$Configuration = Get-Content -Path $ConfigFilePath
    $element = $Configuration.CreateElement('loadFromRemoteSources')
    $element.Attributes.Append($Configuration.CreateAttribute("enabled"))
    $element.enabled = "true"
    $Configuration.configuration.runtime.AppendChild($element)
    $Configuration.Save($ConfigFilePath)
}

# Disable "Open File - Security Warning" for .exe files
Set-PSRepository -Name PSGallery -InstallationPolicy Trusted
Write-Host "Installing PolicyFileEditor Module"
Install-Module -Repository PSGallery -Name PolicyFileEditor

Write-Host "Importing PolicyFileEditor Module"
import-module -Name PolicyFileEditor

$userRegistryPol = "$env:windir\system32\GroupPolicy\User\registry.pol"
$regPath = "Software\Microsoft\Windows\CurrentVersion\Policies\Associations"
$regName = "LowRiskFileTypes"
$regData = ".exe"
$regType = "String"
Set-PolicyFileEntry -Path $userRegistryPol -Key $regPath -ValueName $regName -Data $regData -Type $regType
gpupdate /Target:User /force

# Disable Internet Explorer's Protected Mode Banner: "Protected mode is turned off for the Local intranet zone"
Set-ItemProperty -Path "HKCU:\Software\Microsoft\Internet Explorer\Main" -Name "NoProtectedModeBanner" -Value 1

Write-Host "Disable zone checking when opening files for the current user..."
# This circumvents the "Open File - Security Warning" dialog that appears when exes (applications under test) are launched
$exitCode = Run-Process -FilePath "reg.exe" -ArgumentList "add ""HKCU\Environment"" /V SEE_MASK_NOZONECHECKS /T REG_SZ /D 1 /F"
if ($exitCode -ne 0)
{
    throw "Command failed with exit code $exitCode."
}
