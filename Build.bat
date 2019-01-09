@echo off

call %~dp0SetDevelopmentEnvironment.bat

rem Parameters
set PROJECT=%~dp0src\Build.proj

set ConfigurationName=%1

if '%ConfigurationName%'=='' set ConfigurationName=Release

rem Build
msbuild.exe %PROJECT% /t:Build /p:ConfigurationName=%ConfigurationName%
if %errorlevel% neq 0 (
    goto error
)

msbuild.exe %PROJECT% /t:Pack /p:ConfigurationName=%ConfigurationName%
if %errorlevel% neq 0 (
    goto error
)

goto end:

:error
echo An error has occurred.
pause
exit /b 1

:end
echo Finished successfully.
pause
exit /b 0