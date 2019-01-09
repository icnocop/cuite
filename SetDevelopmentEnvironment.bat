:: Set up the development environment to use Msbuild
IF EXIST "%VS140COMNTOOLS%VsDevCmd.bat" (
    CALL "%VS140COMNTOOLS%VsDevCmd.bat"
) ELSE IF EXIST "%VS130COMNTOOLS%VsDevCmd.bat" (
    CALL "%VS130COMNTOOLS%VsDevCmd.bat"
) ELSE IF EXIST "%VS120COMNTOOLS%VsDevCmd.bat" (
    CALL "%VS120COMNTOOLS%VsDevCmd.bat"
) ELSE (
    ECHO Error: You don't seem to have Visual Studio installed!
)