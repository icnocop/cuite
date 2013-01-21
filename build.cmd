@echo off

pushd "%~dp0"
setlocal ENABLEEXTENSIONS ENABLEDELAYEDEXPANSION

set ProgramFilesDir=%ProgramFiles%
if NOT "%ProgramFiles(x86)%"=="" set ProgramFilesDir=%ProgramFiles(x86)%

set VisualStudioCmd=%ProgramFilesDir%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat
if EXIST "%VisualStudioCmd%" call "%VisualStudioCmd%"

msbuild.exe build.proj %*
popd
endlocal