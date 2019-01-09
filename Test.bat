@echo off

call SetDevelopmentEnvironment.bat

rem Parameters
set PROJECT=.\src\Build.proj

rem Build
msbuild.exe %PROJECT% /t:Build
msbuild.exe %PROJECT% /t:Test

pause