# Install Visual Studio version-specific dependencies.
# Usage: .\Install-VSDependencies.ps1 -VSVersion "2026"
# Valid values: 2010, 2012, 2013, 2015, 2017, 2019, 2022, 2026

[CmdletBinding()]
param(
    [Parameter(Mandatory=$true)]
    [ValidateSet("2010", "2012", "2013", "2015", "2017", "2019", "2022", "2026")]
    [string]$VSVersion
)

$VerbosePreference = 'Continue'

. "$Env:BUILD_SOURCESDIRECTORY\build\ProcessRunner.ps1"

$webclient = New-Object System.Net.WebClient
$chocolateyLogFilePath = "$($env:ProgramData)\chocolatey\logs\chocolatey.log"

$depsPath = Join-Path $env:AGENT_BUILDDIRECTORY '.deps'
if (-not(Test-Path -Path $depsPath -PathType Container)) {
    New-Item -Path $depsPath -ItemType Directory
}

# -------------------------------------------------------------------
# VS2010 and VS2012 require VS2013 Premium for the build toolsets.
# VS2013 also requires VS2013 Premium plus its Silverlight plugin.
# -------------------------------------------------------------------
function Install-VS2013Premium {
    Write-Host "Downloading Microsoft Visual Studio 2013 Premium..."
    $isoFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\VS2013_RTM_PREM_ENU.iso"
    if (-not(Test-Path -Path $isoFilePath -PathType Leaf)) {
        $webclient.DownloadFile('https://download.microsoft.com/download/D/B/D/DBDEE6BB-AF28-4C76-A5F8-710F610615F7/VS2013_RTM_PREM_ENU.iso', $isoFilePath)
    }
    Write-Host "Installing Microsoft Visual Studio 2013 Premium..."
    $mountResult = Mount-DiskImage -ImagePath $isoFilePath
    $driveLetter = ($mountResult | Get-Volume).DriveLetter
    $exitCode = Run-Process -FilePath "$($driveLetter[0]):\vs_premium.exe" -ArgumentList "/Q /Passive /NoRestart /NoWeb /Full"
    if ($exitCode -ne 0)
    {
        throw "Command failed with exit code $exitCode."
    }
    Write-Host "Microsoft Visual Studio 2013 Premium successfully installed" -ForegroundColor Green
    Dismount-DiskImage -ImagePath $isoFilePath
}

function Install-VS2013SilverlightPlugin {
    Write-Host "Downloading Microsoft Visual Studio 2013 Coded UI Test Plugin for Silverlight..."
    $msiFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\UITestPluginForSilverlightVS2013.msi"
    if (-not(Test-Path -Path $msiFilePath -PathType Leaf)) {
        $webclient.DownloadFile('https://prachiboramsft.gallerycdn.vsassets.io/extensions/prachiboramsft/microsoftvisualstudio2013codeduitestpluginforsilve/1.0/1482140133605/133666/1/UITestPluginForSilverlightVS2013.msi', $msiFilePath)
    }
    $logFilePath = "$($env:TEMP)\UITestPluginForSilverlightVS2013.txt"
    Write-Host "Installing Microsoft Visual Studio 2013 Coded UI Test Plugin for Silverlight..."
    $exitCode = Run-Process -FilePath "msiexec.exe" -ArgumentList "/i $msiFilePath /quiet /l*v $logFilePath"
    if ($exitCode -ne 0)
    {
        if (Test-Path $logFilePath) { Get-Content $logFilePath }
        throw "Command failed with exit code $exitCode."
    }
    if (Test-Path $msiFilePath) { Remove-Item $msiFilePath }
    if (Test-Path $logFilePath) { Remove-Item $logFilePath }
    Write-Host "Microsoft Visual Studio 2013 Coded UI Test Plugin for Silverlight successfully installed" -ForegroundColor Green
}

# -------------------------------------------------------------------

switch ($VSVersion) {
    "2010" {
        # VS2010 builds require VS2013 Premium for the toolset
        Install-VS2013Premium
    }
    "2012" {
        # VS2012 builds require VS2013 Premium for the toolset
        Install-VS2013Premium
    }
    "2013" {
        Install-VS2013Premium
        Install-VS2013SilverlightPlugin
    }
    "2015" {
        # Microsoft Visual Studio 2015 Enterprise Update 3
        Write-Host "Downloading Microsoft Visual Studio 2015 Enterprise Update 3..."
        $isoFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\vs2015.3.ent_enu.iso"
        if (-not(Test-Path -Path $isoFilePath -PathType Leaf)) {
            $webclient.DownloadFile('https://download.microsoft.com/download/8/4/3/843ec655-1b67-46c3-a7a4-10a1159cfa84/vs2015.3.ent_enu.iso', $isoFilePath)
        }
        Write-Host "Installing Microsoft Visual Studio 2015 Enterprise Update 3..."
        $mountResult = Mount-DiskImage -ImagePath $isoFilePath
        $driveLetter = ($mountResult | Get-Volume).DriveLetter
        $exitCode = Run-Process -FilePath "$($driveLetter[0]):\vs_enterprise.exe" -ArgumentList "/Q /Passive /NoRestart /NoWeb /Full"
        if ($exitCode -ne -2147185721)
        {
            throw "Command failed with exit code $exitCode."
        }
        Write-Host "Microsoft Visual Studio 2015 Enterprise Update 3 successfully installed" -ForegroundColor Green
        Dismount-DiskImage -ImagePath $isoFilePath

        # Microsoft Visual Studio 2015 Coded UI Test Plugin for Silverlight
        Write-Host "Downloading Microsoft Visual Studio 2015 Coded UI Test Plugin for Silverlight..."
        $msiFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\UITestPluginForSilverlightVS2015.msi"
        if (-not(Test-Path -Path $msiFilePath -PathType Leaf)) {
            $webclient.DownloadFile('https://atinbansal.gallerycdn.vsassets.io/extensions/atinbansal/microsoftvisualstudio2015codeduitestpluginforsilve/1.0/1482142639885/189320/1/UITestPluginForSilverlightVS2015.msi', $msiFilePath)
        }
        $logFilePath = "$($env:TEMP)\UITestPluginForSilverlightVS2015.txt"
        Write-Host "Installing Microsoft Visual Studio 2015 Coded UI Test Plugin for Silverlight..."
        $exitCode = Run-Process -FilePath "msiexec.exe" -ArgumentList "/i $msiFilePath /quiet /l*v $logFilePath"
        if ($exitCode -ne 0)
        {
            if (Test-Path $logFilePath) { Get-Content $logFilePath }
            throw "Command failed with exit code $exitCode."
        }
        if (Test-Path $msiFilePath) { Remove-Item $msiFilePath }
        if (Test-Path $logFilePath) { Remove-Item $logFilePath }
        Write-Host "Microsoft Visual Studio 2015 Coded UI Test Plugin for Silverlight successfully installed" -ForegroundColor Green
    }
    "2017" {
        # Microsoft Visual Studio 2017 Enterprise
        # https://chocolatey.org/packages/visualstudio2017enterprise
        $logFilePath = "$($env:TEMP)\chocolatey\vs.log"
        Write-Host "Installing Microsoft Visual Studio 2017 Enterprise..."
        $exitCode = Run-Process -FilePath "choco.exe" -ArgumentList "install --execution-timeout=0 -y VisualStudio2017Enterprise  -packageParameters ""--add Microsoft.VisualStudio.Workload.NativeDesktop --add Microsoft.VisualStudio.Workload.NetWeb"""
        if (($exitCode -ne 3010) -and ($exitCode -ne 0))
        {
            if (Test-Path $logFilePath) { Get-Content $logFilePath }
            if (Test-Path $chocolateyLogFilePath) { Get-Content $chocolateyLogFilePath }
            throw "Command failed with exit code $exitCode."
        }
        if (Test-Path $logFilePath) { Remove-Item $logFilePath }
        Write-Host "Microsoft Visual Studio 2017 Enterprise successfully installed" -ForegroundColor Green

        # Unofficial Microsoft Visual Studio 2017 Coded UI Test Plugin for Silverlight
        Write-Host "Downloading Unofficial Microsoft Visual Studio 2017 Coded UI Test Plugin for Silverlight..."
        $msiFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\UITestPluginForSilverlightVS2017.msi"
        if (-not(Test-Path -Path $msiFilePath -PathType Leaf)) {
            $webclient.DownloadFile('https://ramiabughazaleh.gallerycdn.vsassets.io/extensions/ramiabughazaleh/codeduitestpluginforsilverlight/15.0.2321.0/1606001510488/UITestPluginForSilverlightVS2017.msi', $msiFilePath)
        }
        $logFilePath = "$($env:TEMP)\UITestPluginForSilverlightVS2017.txt"
        Write-Host "Installing Unofficial Microsoft Visual Studio 2017 Coded UI Test Plugin for Silverlight..."
        $exitCode = Run-Process -FilePath "msiexec.exe" -ArgumentList "/i $msiFilePath /quiet /l*v $logFilePath"
        if ($exitCode -ne 0)
        {
            if (Test-Path $logFilePath) { Get-Content $logFilePath }
            throw "Command failed with exit code $exitCode."
        }
        if (Test-Path $msiFilePath) { Remove-Item $msiFilePath }
        if (Test-Path $logFilePath) { Remove-Item $logFilePath }
        Write-Host "Unofficial Microsoft Visual Studio 2017 Coded UI Test Plugin for Silverlight successfully installed" -ForegroundColor Green
    }
    "2019" {
        # Microsoft Visual Studio 2019 Enterprise
        # https://chocolatey.org/packages/visualstudio2019enterprise
        $logFilePath = "$($env:TEMP)\chocolatey\visualstudio2019enterprise.log"
        Write-Host "Installing Microsoft Visual Studio 2019 Enterprise..."
        $exitCode = Run-Process -FilePath "choco.exe" -ArgumentList "install --execution-timeout=0 -y VisualStudio2019Enterprise  -packageParameters ""--add Microsoft.VisualStudio.Workload.NativeDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Microsoft.VisualStudio.Component.TestTools.CodedUITest"""
        if (($exitCode -ne 3010) -and ($exitCode -ne 0))
        {
            if (Test-Path $logFilePath) { Get-Content $logFilePath }
            if (Test-Path $chocolateyLogFilePath) { Get-Content $chocolateyLogFilePath }
            throw "Command failed with exit code $exitCode."
        }
        if (Test-Path $logFilePath) { Remove-Item $logFilePath }
        Write-Host "Microsoft Visual Studio 2019 Enterprise successfully installed" -ForegroundColor Green

        # Unofficial Microsoft Visual Studio 2019 Coded UI Test Plugin for Silverlight
        Write-Host "Downloading Unofficial Microsoft Visual Studio 2019 Coded UI Test Plugin for Silverlight..."
        $msiFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\UITestPluginForSilverlightVS2019.msi"
        if (-not(Test-Path -Path $msiFilePath -PathType Leaf)) {
            $webclient.DownloadFile('https://ramiabughazaleh.gallerycdn.vsassets.io/extensions/ramiabughazaleh/visualstudio2019codeduitestpluginforsilverlight/16.0.1127.1/1574849731387/UITestPluginForSilverlightVS2019.msi', $msiFilePath)
        }
        $logFilePath = "$($env:TEMP)\UITestPluginForSilverlightVS2019.txt"
        Write-Host "Installing Unofficial Microsoft Visual Studio 2019 Coded UI Test Plugin for Silverlight..."
        $exitCode = Run-Process -FilePath "msiexec.exe" -ArgumentList "/i $msiFilePath /quiet /l*v $logFilePath"
        if ($exitCode -ne 0)
        {
            if (Test-Path $logFilePath) { Get-Content $logFilePath }
            throw "Command failed with exit code $exitCode."
        }
        if (Test-Path $msiFilePath) { Remove-Item $msiFilePath }
        if (Test-Path $logFilePath) { Remove-Item $logFilePath }
        Write-Host "Unofficial Microsoft Visual Studio 2019 Coded UI Test Plugin for Silverlight successfully installed" -ForegroundColor Green
    }
    "2022" {
        # Microsoft Visual Studio 2022 Enterprise
        # https://chocolatey.org/packages/visualstudio2022enterprise
        $logFilePath = "$($env:TEMP)\chocolatey\visualstudio2022enterprise.log"
        Write-Host "Installing Microsoft Visual Studio 2022 Enterprise..."
        $exitCode = Run-Process -FilePath "choco.exe" -ArgumentList "install --execution-timeout=0 -y VisualStudio2022Enterprise  -packageParameters ""--add Microsoft.VisualStudio.Workload.NativeDesktop --add Microsoft.VisualStudio.Workload.NetWeb --add Microsoft.VisualStudio.Component.TestTools.CodedUITest"""
        if (($exitCode -ne 3010) -and ($exitCode -ne 0))
        {
            if (Test-Path $logFilePath) { Get-Content $logFilePath }
            if (Test-Path $chocolateyLogFilePath) { Get-Content $chocolateyLogFilePath }
            throw "Command failed with exit code $exitCode."
        }
        if (Test-Path $logFilePath) { Remove-Item $logFilePath }
        Write-Host "Microsoft Visual Studio 2022 Enterprise successfully installed" -ForegroundColor Green

        # Unofficial Microsoft Visual Studio 2022 Coded UI Test Plugin for Silverlight
        Write-Host "Downloading Unofficial Microsoft Visual Studio 2022 Coded UI Test Plugin for Silverlight..."
        $msiFilePath = "$Env:AGENT_BUILDDIRECTORY\.deps\UITestPluginForSilverlightVS2022.msi"
        if (-not(Test-Path -Path $msiFilePath -PathType Leaf)) {
            $webclient.DownloadFile('https://ramiabughazaleh.gallerycdn.vsassets.io/extensions/ramiabughazaleh/visualstudio2022codeduitestpluginforsilverlight/17.0.306.13/1646595365211/UITestPluginForSilverlightVS2022.msi', $msiFilePath)
        }
        $logFilePath = "$($env:TEMP)\UITestPluginForSilverlightVS2022.txt"
        Write-Host "Installing Unofficial Microsoft Visual Studio 2022 Coded UI Test Plugin for Silverlight..."
        $exitCode = Run-Process -FilePath "msiexec.exe" -ArgumentList "/i $msiFilePath /quiet /l*v $logFilePath"
        if ($exitCode -ne 0)
        {
            if (Test-Path $logFilePath) { Get-Content $logFilePath }
            throw "Command failed with exit code $exitCode."
        }
        if (Test-Path $msiFilePath) { Remove-Item $msiFilePath }
        if (Test-Path $logFilePath) { Remove-Item $logFilePath }
        Write-Host "Unofficial Microsoft Visual Studio 2022 Coded UI Test Plugin for Silverlight successfully installed" -ForegroundColor Green
    }
    "2026" {
        # VS2026 is pre-installed on the 'windows-2025-vs2026' VM image; no additional installation needed.
        Write-Host "VS2026 is pre-installed on the VM image. Skipping installation." -ForegroundColor Green
    }
}

Write-Host "VS$VSVersion dependencies successfully installed." -ForegroundColor Green
