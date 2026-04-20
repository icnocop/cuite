@echo off
setlocal

call %~dp0SetDevelopmentEnvironment.bat

set SOLUTION=%~dp0src\CUITe.sln
set INTTEST_PROJECT=%~dp0src\CUITe.IntegrationTests\CUITe.IntegrationTests.csproj
set NUGET=%~dp0src\.nuget\NuGet.exe
set CONFIG=%1
if "%CONFIG%"=="" set CONFIG=Release

echo.
echo ========================================
echo  Building CUITe for Visual Studio 2013
echo  VisualStudioVersion=12.0, TFV=v4.5+v4.0
echo  Configuration=%CONFIG%
echo ========================================
echo.

rem Restore NuGet packages
"%NUGET%" restore "%SOLUTION%"
if %errorlevel% neq 0 goto error

rem Build solution - v4.5
msbuild.exe "%SOLUTION%" /t:Rebuild /p:Configuration=%CONFIG%;VisualStudioVersion=12.0;TargetFrameworkVersion=v4.5 /m
if %errorlevel% neq 0 goto error

rem Build solution - v4.0
msbuild.exe "%SOLUTION%" /t:Rebuild /p:Configuration=%CONFIG%;VisualStudioVersion=12.0;TargetFrameworkVersion=v4.0 /m
if %errorlevel% neq 0 goto error

rem Build integration tests - v4.5
msbuild.exe "%INTTEST_PROJECT%" /t:Rebuild /p:Configuration=%CONFIG%;VisualStudioVersion=12.0;TargetFrameworkVersion=v4.5;SolutionDir=%~dp0src\\ /m
if %errorlevel% neq 0 goto error

rem Build integration tests - v4.0
msbuild.exe "%INTTEST_PROJECT%" /t:Rebuild /p:Configuration=%CONFIG%;VisualStudioVersion=12.0;TargetFrameworkVersion=v4.0;SolutionDir=%~dp0src\\ /m
if %errorlevel% neq 0 goto error

rem Pack NuGet
"%NUGET%" pack "%~dp0src\CUITe\CUITe for Visual Studio 2013.nuspec" -OutputDirectory "%~dp0\" -Verbosity detailed -Prop Configuration=%CONFIG% -Prop Version=2.0.0.0
if %errorlevel% neq 0 goto error

"%NUGET%" pack "%~dp0src\CUITe.Silverlight\CUITe.Silverlight.VS2013.nuspec" -OutputDirectory "%~dp0\" -Verbosity detailed -Prop VisualStudioVersion=12.0 -Prop Configuration=%CONFIG% -Prop Version=2.0.0.0
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
