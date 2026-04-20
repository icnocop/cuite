@echo off
setlocal

call %~dp0SetDevelopmentEnvironment.bat

set CONFIG=%1
if "%CONFIG%"=="" set CONFIG=Debug

echo.
echo ========================================
echo  Running Tests for Visual Studio 2026
echo  Configuration=%CONFIG%
echo ========================================
echo.

rem Use vstest.console.exe from the Microsoft.TestPlatform NuGet package.
rem The Coded UI Test adapter was removed in VS2026 (v18), so the
rem NuGet package provides a standalone test runner without requiring VS2022.
set TESTPLATFORM_VERSION=17.13.0
set NUGET_GLOBAL=
if defined NUGET_PACKAGES (
    set "NUGET_GLOBAL=%NUGET_PACKAGES%"
) else (
    set "NUGET_GLOBAL=%USERPROFILE%\.nuget\packages"
)
set "VSTEST=%NUGET_GLOBAL%\microsoft.testplatform\%TESTPLATFORM_VERSION%\tools\net462\Common7\IDE\Extensions\TestPlatform\vstest.console.exe"
if not exist "%VSTEST%" (
    echo Error: vstest.console.exe not found at:
    echo   %VSTEST%
    echo.
    echo Please restore NuGet packages first ^(dotnet restore^) or verify
    echo Microsoft.TestPlatform %TESTPLATFORM_VERSION% is in the global packages folder.
    goto error
)
echo Using: %VSTEST%
echo.

rem Disable telemetry to avoid FileNotFoundException for
rem Microsoft.VisualStudio.RemoteControl on agents without VS installed.
set TESTINGPLATFORM_TELEMETRY_OPTOUT=1

rem Test assemblies matching the pipeline pattern (**\bin\<Config>\**\*Test.dll),
rem excluding Silverlight (same as azure-pipelines.yml and build\pipelines\vs2026.yml).
rem To temporarily skip a test assembly, add REM before its line.
set SRCDIR=%~dp0src
set SETTINGS=/Settings:"%~dp0src\Local_CUITv18.runsettings" /Logger:trx

"%VSTEST%" "%SRCDIR%\CUITeTest\bin\%CONFIG%\VS2026\net472\CUITeTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.Html.PageObjectsTest\bin\%CONFIG%\VS2026\net472\Sut.Html.PageObjectsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.Html.WorkflowsTest\bin\%CONFIG%\VS2026\net472\Sut.Html.WorkflowsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.HtmlTest\bin\%CONFIG%\VS2026\net472\Sut.HtmlTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.PeripheralInputTest\bin\%CONFIG%\VS2026\net472\Sut.PeripheralInputTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.WinForms.ControlsTest\bin\%CONFIG%\VS2026\net472\Sut.WinForms.ControlsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.WinForms.ScreenObjectsTest\bin\%CONFIG%\VS2026\net472\Sut.WinForms.ScreenObjectsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.WinForms.WorkflowsTest\bin\%CONFIG%\VS2026\net472\Sut.WinForms.WorkflowsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.Wpf.ControlsTest\bin\%CONFIG%\VS2026\net472\Sut.Wpf.ControlsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.Wpf.ScreenObjectsTest\bin\%CONFIG%\VS2026\net472\Sut.Wpf.ScreenObjectsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

"%VSTEST%" "%SRCDIR%\SystemsUnderTest\Sut.Wpf.WorkflowsTest\bin\%CONFIG%\VS2026\net472\Sut.Wpf.WorkflowsTest.dll" %SETTINGS%
if %errorlevel% neq 0 goto error

goto end

:error
echo.
echo An error has occurred.
pause
exit /b 1

:end
echo.
echo Finished successfully.
pause
exit /b 0
