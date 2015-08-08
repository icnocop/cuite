@echo off

rem Environment variables
if exist "%ProgramFiles%\MSBuild\12.0\bin" set PATH=%ProgramFiles%\MSBuild\12.0\bin;%PATH%
if exist "%ProgramFiles(x86)%\MSBuild\12.0\bin" set PATH=%ProgramFiles(x86)%\MSBuild\12.0\bin;%PATH%

rem Parameters
set PROJECT=.\src\Build.proj

rem Build
msbuild.exe %PROJECT% /t:Build
msbuild.exe %PROJECT% /t:Pack
msbuild.exe %PROJECT% /t:Test

pause