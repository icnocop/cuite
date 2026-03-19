<#
.SYNOPSIS
    Registers the Coded UI Test IE Communication COM DLLs and verifies registration.
.DESCRIPTION
    Registers both the 64-bit and 32-bit IE Communication COM DLLs from the
    Microsoft.TestPlatform NuGet package, verifies COM registry entries,
    enables Fusion assembly binding logging, and tests COM instantiation.
.PARAMETER TestPlatformVersion
    The version of the Microsoft.TestPlatform NuGet package (e.g., '17.13.0').
.PARAMETER FusionLogPath
    Directory path for Fusion assembly binding failure logs.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [string]$TestPlatformVersion,

    [Parameter(Mandatory = $false)]
    [string]$FusionLogPath = "$env:TEMP\FusionLogs"
)

$ErrorActionPreference = 'Stop'

# --- Verify Internet Explorer availability ---

Write-Host "=== Verifying Internet Explorer availability ==="

$ieExe64 = Join-Path $env:ProgramFiles "Internet Explorer\iexplore.exe"
$ieExe32 = Join-Path ${env:ProgramFiles(x86)} "Internet Explorer\iexplore.exe"
Write-Host "iexplore.exe (64-bit): $ieExe64 - Exists: $(Test-Path $ieExe64)"
Write-Host "iexplore.exe (32-bit): $ieExe32 - Exists: $(Test-Path $ieExe32)"

# Check COM registration for InternetExplorer.Application
$ieClsid = "{0002DF01-0000-0000-C000-000000000046}"
$ieRegPath = "Registry::HKEY_CLASSES_ROOT\CLSID\$ieClsid\LocalServer32"
if (Test-Path $ieRegPath) {
    $ieLocalServer = (Get-ItemProperty $ieRegPath).'(default)'
    Write-Host "IE COM LocalServer32: $ieLocalServer"
    $ieServerPath = [System.Environment]::ExpandEnvironmentVariables(($ieLocalServer -replace '"',''))
    Write-Host "IE COM server file exists: $(Test-Path $ieServerPath)"
} else {
    Write-Warning "IE COM class $ieClsid is NOT registered"
}

# On Windows Server, IE is an optional feature that may need to be enabled
if (-not (Test-Path $ieExe64)) {
    Write-Host "`nInternet Explorer not found. Checking if it can be enabled as a Windows feature..."
    $featureResult = dism /online /get-featureinfo /featurename:Internet-Explorer-Optional-amd64 2>&1
    $featureAvailable = $LASTEXITCODE -eq 0
    if ($featureAvailable) {
        Write-Host "IE feature found. Enabling Internet-Explorer-Optional-amd64..."
        $enableResult = dism /online /Enable-Feature /FeatureName:Internet-Explorer-Optional-amd64 /All /NoRestart 2>&1
        Write-Host $enableResult
        if ($LASTEXITCODE -ne 0) {
            Write-Warning "Failed to enable IE feature (exit code: $LASTEXITCODE)"
        } else {
            Write-Host "Internet Explorer feature enabled successfully" -ForegroundColor Green
        }
    } else {
        Write-Warning "IE optional feature is not available on this OS. IE-dependent tests will fail."
        Write-Host "DISM output: $featureResult"
        Write-Host "OS: $((Get-CimInstance Win32_OperatingSystem).Caption)"
    }
}

# Test IE COM instantiation
Write-Host "`nTesting InternetExplorer.Application COM instantiation..."
try {
    $ieType = [Type]::GetTypeFromProgID("InternetExplorer.Application")
    if ($ieType) {
        $ie = [Activator]::CreateInstance($ieType)
        Write-Host "IE COM object created successfully" -ForegroundColor Green
        $ie.Quit()
        [System.Runtime.InteropServices.Marshal]::ReleaseComObject($ie) | Out-Null
    } else {
        Write-Warning "InternetExplorer.Application ProgID not registered"
    }
} catch {
    Write-Warning "IE COM instantiation failed: $($_.Exception.Message)"
    Write-Warning "HRESULT: 0x$($_.Exception.HResult.ToString('X8'))"
}

# --- Locate test platform directories ---

# The VisualStudioTestPlatformInstaller@1 task extracts to AGENT_TOOLSDIRECTORY.
# Fall back to the NuGet global-packages folder for local development.
$cuitPluginsDir = $null
if ($env:AGENT_TOOLSDIRECTORY) {
    $candidate = Join-Path $env:AGENT_TOOLSDIRECTORY "VsTest\$TestPlatformVersion\x64\tools\net462\Common7\IDE\Extensions\TestPlatform\CUITPlugins"
    if (Test-Path $candidate) {
        $cuitPluginsDir = $candidate
    }
}
if (-not $cuitPluginsDir) {
    $candidate = Join-Path $env:USERPROFILE ".nuget\packages\microsoft.testplatform\$TestPlatformVersion\tools\net462\Common7\IDE\Extensions\TestPlatform\CUITPlugins"
    if (Test-Path $candidate) {
        $cuitPluginsDir = $candidate
    }
}

if (-not $cuitPluginsDir) {
    Write-Error "CUITPlugins directory not found. Searched:`n  AGENT_TOOLSDIRECTORY: $env:AGENT_TOOLSDIRECTORY`n  NuGet packages: $env:USERPROFILE\.nuget\packages\microsoft.testplatform\$TestPlatformVersion"
    exit 1
}

Write-Host "CUITPlugins directory: $cuitPluginsDir"
Write-Host "Contents:"
Get-ChildItem $cuitPluginsDir | ForEach-Object { Write-Host "  $($_.Name) ($($_.Length) bytes)" }

# --- Register COM DLLs ---

$ie64Dll = Join-Path $cuitPluginsDir "Microsoft.VisualStudio.TestTools.UITest.Extension.IE64.Communication.dll"
$ie32Dll = Join-Path $cuitPluginsDir "Microsoft.VisualStudio.TestTools.UITest.Extension.IE.Communication.dll"

# Register 64-bit COM DLL
Write-Host "`n=== Registering 64-bit IE Communication COM DLL ==="
Write-Host "DLL: $ie64Dll"
if (-not (Test-Path $ie64Dll)) {
    Write-Error "64-bit DLL not found: $ie64Dll"
    exit 1
}
$proc = Start-Process -FilePath 'regsvr32' -ArgumentList "/s `"$ie64Dll`"" -Wait -PassThru -NoNewWindow
if ($proc.ExitCode -ne 0) {
    Write-Error "regsvr32 failed for 64-bit DLL with exit code $($proc.ExitCode)"
    exit 1
}
Write-Host "regsvr32 succeeded (exit code: $($proc.ExitCode))"

# Register 32-bit COM DLL
Write-Host "`n=== Registering 32-bit IE Communication COM DLL ==="
Write-Host "DLL: $ie32Dll"
if (-not (Test-Path $ie32Dll)) {
    Write-Error "32-bit DLL not found: $ie32Dll"
    exit 1
}
$regsvr32_32 = Join-Path $env:windir "SysWOW64\regsvr32.exe"
$proc = Start-Process -FilePath $regsvr32_32 -ArgumentList "/s `"$ie32Dll`"" -Wait -PassThru -NoNewWindow
if ($proc.ExitCode -ne 0) {
    Write-Error "regsvr32 (32-bit) failed for 32-bit DLL with exit code $($proc.ExitCode)"
    exit 1
}
Write-Host "regsvr32 (32-bit) succeeded (exit code: $($proc.ExitCode))"

# --- Verify COM Registry Entries ---

Write-Host "`n=== Verifying COM Registry Entries ==="
$clsid = "{216EC036-8A14-489B-911B-04E4CEA921D8}"
Write-Host "Expected CLSID: $clsid"

$path64 = "HKLM:\SOFTWARE\Classes\CLSID\$clsid\InprocServer32"
$path32 = "HKLM:\SOFTWARE\WOW6432Node\Classes\CLSID\$clsid\InprocServer32"

Write-Host "`n64-bit registry ($path64):"
if (Test-Path $path64) {
    $props = Get-ItemProperty $path64
    Write-Host "  DLL path: $($props.'(default)')"
    Write-Host "  ThreadingModel: $($props.ThreadingModel)"
    $exists = Test-Path $props.'(default)'
    Write-Host "  File exists: $exists"
    if (-not $exists) { Write-Warning "Registered DLL file does not exist!" }
} else {
    Write-Warning "64-bit COM registration NOT FOUND in registry"
}

Write-Host "`n32-bit (WOW64) registry ($path32):"
if (Test-Path $path32) {
    $props = Get-ItemProperty $path32
    Write-Host "  DLL path: $($props.'(default)')"
    Write-Host "  ThreadingModel: $($props.ThreadingModel)"
    $exists = Test-Path $props.'(default)'
    Write-Host "  File exists: $exists"
    if (-not $exists) { Write-Warning "Registered DLL file does not exist!" }
} else {
    Write-Warning "32-bit (WOW64) COM registration NOT FOUND in registry"
}

# --- Copy missing test platform dependencies ---

Write-Host "`n=== Copying missing test platform dependencies ==="

# Determine the test platform directory where the test runner executes from.
# The VisualStudioTestPlatformInstaller@1 task extracts to AGENT_TOOLSDIRECTORY.
$testPlatformDir = $null
if ($env:AGENT_TOOLSDIRECTORY) {
    $candidate = Join-Path $env:AGENT_TOOLSDIRECTORY "VsTest\$TestPlatformVersion\x64\tools\net462\Common7\IDE\Extensions\TestPlatform"
    if (Test-Path $candidate) {
        $testPlatformDir = $candidate
    }
}
# Fall back to NuGet package path
if (-not $testPlatformDir) {
    $candidate = Join-Path $env:USERPROFILE ".nuget\packages\microsoft.testplatform\$TestPlatformVersion\tools\net462\Common7\IDE\Extensions\TestPlatform"
    if (Test-Path $candidate) {
        $testPlatformDir = $candidate
    }
}

if (-not $testPlatformDir) {
    Write-Warning "Could not find test platform directory"
} else {
    Write-Host "Test platform directory: $testPlatformDir"

    # 1. Copy Microsoft.VisualStudio.RemoteControl.dll from VS PrivateAssemblies.
    #    The test platform's Telemetry.dll references it but the package doesn't include it.
    $vswhere = Join-Path ${env:ProgramFiles(x86)} "Microsoft Visual Studio\Installer\vswhere.exe"
    if (Test-Path $vswhere) {
        $vsInstallPath = & $vswhere -latest -property installationPath
        Write-Host "VS installation path: $vsInstallPath"
        $privateAssembliesDir = Join-Path $vsInstallPath "Common7\IDE\PrivateAssemblies"

        $vsAssemblies = @(
            "Microsoft.VisualStudio.RemoteControl.dll"
        )
        foreach ($assemblyName in $vsAssemblies) {
            $source = Join-Path $privateAssembliesDir $assemblyName
            $target = Join-Path $testPlatformDir $assemblyName
            if (Test-Path $target) {
                Write-Host "  $assemblyName already exists in test platform directory"
            } elseif (-not (Test-Path $source)) {
                Write-Warning "  $assemblyName not found in VS PrivateAssemblies: $source"
            } else {
                Copy-Item -Path $source -Destination $target -Force
                Write-Host "  Copied $assemblyName from VS PrivateAssemblies"
            }
        }
    } else {
        Write-Warning "vswhere.exe not found, cannot copy VS PrivateAssemblies dependencies"
    }

    # 2. Copy managed CUITPlugins assemblies to the test platform directory.
    #    The test host configs set privatePath="Extensions" but NOT "CUITPlugins".
    #    When the native IE Communication COM DLLs (registered via regsvr32) call into
    #    managed code (e.g., EventHelper.dll), the CLR probes from the test host's appbase
    #    (the TestPlatform directory) and cannot find assemblies in CUITPlugins.
    $cuitPluginsDlls = Get-ChildItem (Join-Path $testPlatformDir "CUITPlugins") -Filter "*.dll" -ErrorAction SilentlyContinue
    if ($cuitPluginsDlls) {
        Write-Host "`nCopying CUITPlugins managed assemblies to test platform directory..."
        foreach ($dll in $cuitPluginsDlls) {
            $isManaged = $false
            try { [System.Reflection.AssemblyName]::GetAssemblyName($dll.FullName) | Out-Null; $isManaged = $true } catch {}
            if (-not $isManaged) { continue }

            $target = Join-Path $testPlatformDir $dll.Name
            if (Test-Path $target) {
                Write-Host "  $($dll.Name) already exists"
            } else {
                Copy-Item -Path $dll.FullName -Destination $target -Force
                Write-Host "  Copied $($dll.Name)"
            }
        }
    }

    # 2b. Add CUITPlugins to the test host assembly probing paths.
    #     When native COM DLLs call CoCreateInstance for managed COM classes
    #     registered with /codebase, the CLR resolves dependencies from the host's
    #     AppBase and privatePath. Without CUITPlugins in the probing path,
    #     assemblies that exist only in CUITPlugins fail to load with
    #     FileNotFoundException (0x80070002) in methods like CreateWebControlEventSink.
    Write-Host "`nAdding CUITPlugins to test host probing paths..."
    $configFiles = Get-ChildItem $testPlatformDir -Filter "*.exe.config" -ErrorAction SilentlyContinue
    foreach ($configFile in $configFiles) {
        $xml = [xml](Get-Content $configFile.FullName -Raw)
        $nsmgr = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
        $nsmgr.AddNamespace("asm", "urn:schemas-microsoft-com:asm.v1")
        $probingNode = $xml.SelectSingleNode("//configuration/runtime/asm:assemblyBinding/asm:probing", $nsmgr)
        if (-not $probingNode) {
            $probingNode = $xml.SelectSingleNode("//configuration/runtime/assemblyBinding/probing")
        }
        if ($probingNode) {
            $currentPath = $probingNode.GetAttribute("privatePath")
            if ($currentPath -and $currentPath -notmatch '\bCUITPlugins\b') {
                $newPath = "$currentPath;CUITPlugins"
                $probingNode.SetAttribute("privatePath", $newPath)
                $xml.Save($configFile.FullName)
                Write-Host "  $($configFile.Name): privatePath updated to '$newPath'"
            } elseif (-not $currentPath) {
                $probingNode.SetAttribute("privatePath", "CUITPlugins")
                $xml.Save($configFile.FullName)
                Write-Host "  $($configFile.Name): privatePath set to 'CUITPlugins'"
            } else {
                Write-Host "  $($configFile.Name): CUITPlugins already in privatePath"
            }
        } else {
            Write-Host "  $($configFile.Name): no probing element found (skipped)"
        }
    }

    # 3. Register ALL managed CUITPlugins DLLs for COM interop.
    #    The native IE Communication COM DLLs call CoCreateInstance to create
    #    managed objects (e.g., IEEventHelper, DomAttachEventCallback, and
    #    WebControl event sink classes) from managed assemblies in CUITPlugins.
    #    Without COM registration, test hosts fail with FileNotFoundException
    #    (0x80070002) in IIECommunicator methods such as CreateDocumentEventSink
    #    and CreateWebControlEventSink.
    #
    #    RegAsm resolves dependencies from the assembly's own directory.
    #    Several CUITPlugins DLLs depend on UITest.Extension.dll which lives in
    #    the test platform root, not in CUITPlugins. To satisfy these dependencies
    #    we register the copies already placed in the test platform root (step 2)
    #    where UITest.Extension.dll and other dependencies are co-located.
    Write-Host "`n=== Registering managed CUITPlugins DLLs for COM interop ==="
    $regasm32 = Join-Path $env:windir "Microsoft.NET\Framework\v4.0.30319\RegAsm.exe"
    $regasm64 = Join-Path $env:windir "Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe"
    $cuitManagedDlls = Get-ChildItem (Join-Path $testPlatformDir "CUITPlugins") -Filter "*.dll" -ErrorAction SilentlyContinue
    if ($cuitManagedDlls) {
        foreach ($dll in $cuitManagedDlls) {
            $isManaged = $false
            try { [System.Reflection.AssemblyName]::GetAssemblyName($dll.FullName) | Out-Null; $isManaged = $true } catch {}
            if (-not $isManaged) { continue }

            # Prefer the copy in the test platform root where dependencies
            # (e.g., UITest.Extension.dll) are co-located in the same directory.
            $rootCopy = Join-Path $testPlatformDir $dll.Name
            if (Test-Path $rootCopy) {
                $regTarget = $rootCopy
            } else {
                $regTarget = $dll.FullName
            }
            Write-Host "`nRegistering $($dll.Name) for COM interop (from $(Split-Path $regTarget))..."

            # 32-bit registration
            if (Test-Path $regasm32) {
                $proc = Start-Process -FilePath $regasm32 -ArgumentList "/codebase `"$regTarget`"" -Wait -PassThru -NoNewWindow
                if ($proc.ExitCode -ne 0) {
                    Write-Warning "  RegAsm (32-bit) returned exit code $($proc.ExitCode) for $($dll.Name)"
                } else {
                    Write-Host "  RegAsm (32-bit) succeeded" -ForegroundColor Green
                }
            } else {
                Write-Warning "  32-bit RegAsm.exe not found at $regasm32"
            }

            # 64-bit registration (so the CodeBase points to the correct location,
            # overriding any stale VS-installed registration).
            if (Test-Path $regasm64) {
                $proc = Start-Process -FilePath $regasm64 -ArgumentList "/codebase `"$regTarget`"" -Wait -PassThru -NoNewWindow
                if ($proc.ExitCode -ne 0) {
                    Write-Warning "  RegAsm (64-bit) returned exit code $($proc.ExitCode) for $($dll.Name)"
                } else {
                    Write-Host "  RegAsm (64-bit) succeeded" -ForegroundColor Green
                }
            } else {
                Write-Warning "  64-bit RegAsm.exe not found at $regasm64"
            }
        }
    } else {
        Write-Warning "No DLLs found in CUITPlugins directory"
    }

    # Verify known managed COM class registrations in 32-bit registry
    Write-Host "`nVerifying managed COM class registrations (32-bit)..."
    $managedClsids = @{
        "{4422752E-BF61-4FE9-89A6-95508A88870F}" = "IEEventHelper"
        "{1C7F57B0-124D-4A99-8E1C-110886B437B6}" = "DomAttachEventCallback"
    }
    foreach ($entry in $managedClsids.GetEnumerator()) {
        $regPath = "HKLM:\SOFTWARE\WOW6432Node\Classes\CLSID\$($entry.Key)\InprocServer32"
        if (Test-Path $regPath) {
            $props = Get-ItemProperty $regPath
            Write-Host "  $($entry.Value): registered (CodeBase=$($props.CodeBase))"
        } else {
            Write-Warning "  $($entry.Value) ($($entry.Key)): NOT registered in 32-bit registry"
        }
    }
}

# --- Enable Fusion Assembly Binding Logging ---

Write-Host "`n=== Enabling Fusion Assembly Binding Logging ==="

if (-not (Test-Path $FusionLogPath)) {
    New-Item -ItemType Directory -Path $FusionLogPath -Force | Out-Null
}
Write-Host "Fusion log directory: $FusionLogPath"

$fusionKey = "HKLM:\SOFTWARE\Microsoft\Fusion"
if (-not (Test-Path $fusionKey)) {
    New-Item -Path $fusionKey -Force | Out-Null
}
Set-ItemProperty -Path $fusionKey -Name "ForceLog" -Value 1 -Type DWord
Set-ItemProperty -Path $fusionKey -Name "LogFailures" -Value 1 -Type DWord
Set-ItemProperty -Path $fusionKey -Name "LogResourceBinds" -Value 1 -Type DWord
Set-ItemProperty -Path $fusionKey -Name "EnableLog" -Value 1 -Type DWord
Set-ItemProperty -Path $fusionKey -Name "LogPath" -Value "$FusionLogPath\"
Write-Host "Fusion logging enabled. Binding failures will be logged to: $FusionLogPath"

# --- Test COM Instantiation ---

Write-Host "`n=== Testing COM Object Instantiation ==="
$comClsid = [System.Guid]::new("216EC036-8A14-489B-911B-04E4CEA921D8")
try {
    $comType = [System.Type]::GetTypeFromCLSID($comClsid, $true)
    Write-Host "COM type resolved: $($comType.FullName)"
    $instance = [System.Activator]::CreateInstance($comType)
    Write-Host "COM object instantiated successfully: $instance"
    if ($instance -is [System.IDisposable]) { $instance.Dispose() }
    [System.Runtime.InteropServices.Marshal]::ReleaseComObject($instance) | Out-Null
} catch {
    Write-Warning "COM instantiation test failed (this may be expected without IE running):"
    Write-Warning "  Exception: $($_.Exception.GetType().FullName)"
    Write-Warning "  Message: $($_.Exception.Message)"
    Write-Warning "  HRESULT: 0x$($_.Exception.HResult.ToString('X8'))"
    if ($_.Exception.InnerException) {
        Write-Warning "  Inner: $($_.Exception.InnerException.GetType().FullName): $($_.Exception.InnerException.Message)"
    }
}

Write-Host "`n=== Registration and diagnostics complete ==="
