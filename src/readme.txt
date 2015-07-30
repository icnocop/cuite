Development Environment System Requirements:
--------------------------------------------

Visual Studio 2010 Premium or Ultimate

Visual Studio 2010 Feature Pack 2
http://visualstudiogallery.msdn.microsoft.com/90db28aa-528b-4de5-9711-b6c5b8ce83dc

Visual Studio 2012 Premium or Ultimate

Microsoft Visual Studio UI Test Plugin for Silverlight
http://visualstudiogallery.msdn.microsoft.com/28312a61-9451-451a-990c-c9929b751eb4


Building from the Source Code:
------------------------------

Run build.cmd from an elevated command prompt to build all solutions using the Debug configuration.

Hint: Redirect stdout and stderr to a text file by running: build.cmd >out.txt 2>&1

Syntax:

 build [/p:Targets=[Build|Rebuild]] [/p:Configuration=[Debug|Release]]

Targets:

 Build (Default)
 Rebuild

Configuration:
 Debug (Default)
 Release

Examples:

Rebuilds all solutions using the Debug configuration
    build.cmd /p:Targets=Rebuild

Rebuilds all solutions using the Release configuration
    build.cmd /p:Targets=Rebuild /p:Configuration=Release