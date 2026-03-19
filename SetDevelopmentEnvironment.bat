:: Set up the development environment to use Msbuild
IF EXIST "%programfiles%\Microsoft Visual Studio\18\Enterprise\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\18\Enterprise\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles%\Microsoft Visual Studio\18\Professional\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\18\Professional\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles%\Microsoft Visual Studio\18\Community\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\18\Community\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles%\Microsoft Visual Studio\18\BuildTools\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\18\BuildTools\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles%\Microsoft Visual Studio\2022\Enterprise\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\2022\Enterprise\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles%\Microsoft Visual Studio\2022\Professional\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\2022\Professional\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles%\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles%\Microsoft Visual Studio\2022\BuildTools\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles%\Microsoft Visual Studio\2022\BuildTools\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles(x86)%\Microsoft Visual Studio\2019\Enterprise\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles(x86)%\Microsoft Visual Studio\2019\Enterprise\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles(x86)%\Microsoft Visual Studio\2017\Community\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles(x86)%\Microsoft Visual Studio\2017\Community\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles(x86)%\Microsoft Visual Studio\2017\Professional\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles(x86)%\Microsoft Visual Studio\2017\Professional\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%programfiles(x86)%\Microsoft Visual Studio\2017\BuildTools\Common7\Tools\VsDevCmd.bat" (
    CALL "%programfiles(x86)%\Microsoft Visual Studio\2017\BuildTools\Common7\Tools\VsDevCmd.bat"
) ELSE IF EXIST "%VS140COMNTOOLS%VsDevCmd.bat" (
    CALL "%VS140COMNTOOLS%VsDevCmd.bat"
) ELSE IF EXIST "%VS130COMNTOOLS%VsDevCmd.bat" (
    CALL "%VS130COMNTOOLS%VsDevCmd.bat"
) ELSE IF EXIST "%VS120COMNTOOLS%VsDevCmd.bat" (
    CALL "%VS120COMNTOOLS%VsDevCmd.bat"
) ELSE (
    ECHO Error: You don't seem to have Visual Studio installed!
)