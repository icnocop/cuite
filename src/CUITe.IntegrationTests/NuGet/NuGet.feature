Feature: NuGet
	In order to use CUITe
	As a developer
	I want to be able to add the CUITe NuGet package to my Coded UI test project

Scenario Outline: Adding the CUITe NuGet package to a Coded UI test project
	Given the Visual Studio version <VisualStudioVersion>
	When a new Coded UI test project is created with platform <TargetFrameworkVersion>
	And the CUITe nuget package "<NuGetPackageId>", "<NuGetProjectReferenceName>" is added to the project
	And test methods are added to the project which use CUITe to test the sample application(s)
	Then the project should build and its tests run successfully
	
	Examples:
	| Description                                                   | VisualStudioVersion | TargetFrameworkVersion | NuGetPackageId           | NuGetProjectReferenceName |
	| Visual Studio 2010 and .NET Framework 4.0                     | 2010                | 4.0                    | CUITe.VS2010             | CUITe                     |
	| Visual Studio 2010 and Silverlight 5                          | 2010                | 4.0                    | CUITe.Silverlight.VS2010 | CUITe.Silverlight         |
	| Visual Studio 2012 and .NET Framework 4                       | 2012                | 4.0                    | CUITe.VS2012             | CUITe                     |
	| Visual Studio 2012 and .NET Framework 4.5                     | 2012                | 4.5                    | CUITe.VS2012             | CUITe                     |
	| Visual Studio 2012 and .NET Framework 4.5.1                   | 2012                | 4.5.1                  | CUITe.VS2012             | CUITe                     |
	| Visual Studio 2012 and .NET Framework 4.5.2                   | 2012                | 4.5.2                  | CUITe.VS2012             | CUITe                     |
	| Visual Studio 2012 and .NET Framework 4.6                     | 2012                | 4.6                    | CUITe.VS2012             | CUITe                     |
	| Visual Studio 2012 and .NET Framework 4.5 and Silverlight 5   | 2012                | 4.5                    | CUITe.Silverlight.VS2012 | CUITe.Silverlight         |
	| Visual Studio 2012 and .NET Framework 4.5.1 and Silverlight 5 | 2012                | 4.5.1                  | CUITe.Silverlight.VS2012 | CUITe.Silverlight         |
	| Visual Studio 2012 and .NET Framework 4.5.2 and Silverlight 5 | 2012                | 4.5.2                  | CUITe.Silverlight.VS2012 | CUITe.Silverlight         |
	| Visual Studio 2012 and .NET Framework 4.6 and Silverlight 5   | 2012                | 4.6                    | CUITe.Silverlight.VS2012 | CUITe.Silverlight         |
	| Visual Studio 2013 and .NET Framework 4                       | 2013                | 4.0                    | CUITe.VS2013             | CUITe                     |
	| Visual Studio 2013 and .NET Framework 4.5                     | 2013                | 4.5                    | CUITe.VS2013             | CUITe                     |
	| Visual Studio 2013 and .NET Framework 4.5.1                   | 2013                | 4.5.1                  | CUITe.VS2013             | CUITe                     |
	| Visual Studio 2013 and .NET Framework 4.5.2                   | 2013                | 4.5.2                  | CUITe.VS2013             | CUITe                     |
	| Visual Studio 2013 and .NET Framework 4.6                     | 2013                | 4.6                    | CUITe.VS2013             | CUITe                     |
	| Visual Studio 2013 and .NET Framework 4.5 and Silverlight 5   | 2013                | 4.5                    | CUITe.Silverlight.VS2013 | CUITe.Silverlight         |
	| Visual Studio 2013 and .NET Framework 4.5.1 and Silverlight 5 | 2013                | 4.5.1                  | CUITe.Silverlight.VS2013 | CUITe.Silverlight         |
	| Visual Studio 2013 and .NET Framework 4.5.2 and Silverlight 5 | 2013                | 4.5.2                  | CUITe.Silverlight.VS2013 | CUITe.Silverlight         |
	| Visual Studio 2013 and .NET Framework 4.6 and Silverlight 5   | 2013                | 4.6                    | CUITe.Silverlight.VS2013 | CUITe.Silverlight         |
	| Visual Studio 2015 and .NET Framework 4                       | 2015                | 4.0                    | CUITe.VS2015             | CUITe                     |
	| Visual Studio 2015 and .NET Framework 4.5                     | 2015                | 4.5                    | CUITe.VS2015             | CUITe                     |
	| Visual Studio 2015 and .NET Framework 4.5.1                   | 2015                | 4.5.1                  | CUITe.VS2015             | CUITe                     |
	| Visual Studio 2015 and .NET Framework 4.5.2                   | 2015                | 4.5.2                  | CUITe.VS2015             | CUITe                     |
	| Visual Studio 2015 and .NET Framework 4.6                     | 2015                | 4.6                    | CUITe.VS2015             | CUITe                     |
	| Visual Studio 2015 and .NET Framework 4.5 and Silverlight 5   | 2015                | 4.5                    | CUITe.Silverlight.VS2015 | CUITe.Silverlight         |
	| Visual Studio 2015 and .NET Framework 4.5.1 and Silverlight 5 | 2015                | 4.5.1                  | CUITe.Silverlight.VS2015 | CUITe.Silverlight         |
	| Visual Studio 2015 and .NET Framework 4.5.2 and Silverlight 5 | 2015                | 4.5.2                  | CUITe.Silverlight.VS2015 | CUITe.Silverlight         |
	| Visual Studio 2015 and .NET Framework 4.6 and Silverlight 5   | 2015                | 4.6                    | CUITe.Silverlight.VS2015 | CUITe.Silverlight         |
	| Visual Studio 2017 and .NET Framework 4                       | 2017                | 4.0                    | CUITe.VS2017             | CUITe                     |
	| Visual Studio 2017 and .NET Framework 4.5                     | 2017                | 4.5                    | CUITe.VS2017             | CUITe                     |
	| Visual Studio 2017 and .NET Framework 4.5.1                   | 2017                | 4.5.1                  | CUITe.VS2017             | CUITe                     |
	| Visual Studio 2017 and .NET Framework 4.5.2                   | 2017                | 4.5.2                  | CUITe.VS2017             | CUITe                     |
	| Visual Studio 2017 and .NET Framework 4.6                     | 2017                | 4.6                    | CUITe.VS2017             | CUITe                     |
