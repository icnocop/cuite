@echo off

call "%VS120COMNTOOLS%VsDevCmd.bat"

rem Parameters
set PROJECT=.\src\Build.proj

rem Build
msbuild.exe %PROJECT% /t:Build
msbuild.exe %PROJECT% /t:Pack

rem Build Silverlight
msbuild.exe %PROJECT% /t:BuildSilverlight
msbuild.exe %PROJECT% /t:PackSilverlight

pause