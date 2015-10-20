2.0 (TBD)
=========

* added support for cross browser testing - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added PointAndClick method to work around the common scenario on third-party controls which Coded UI tests throw the FailedToPerformActionOnBlockedControlException exception - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added support for .net 4 for visual studio 2012 - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* The parsing of search properties in CUITe_ControlBase now allows for search properties that contained = or ~ characters. - [@dubsnz](https://www.codeplex.com/site/users/view/dubsnz)
* using NET4 and VS2010 preprocessor directives; running tests in build.proj - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* using cassini dev web server to fix failing silverlight unit tests - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* using new ResourceNotFoundException - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* updated TelerikASPNETComboBox integration test and object repository class - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* marked Telerik_ComboBox as obsolete - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* replaced calls to GetPropertyOfChildren with InnerText.Split() to resolve errors and time outs - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed Telerik ASP.NET ComboBox control wrapper and added back the unit test SelectItemByText_OnTelerikASPNETComboBox_Succeeds - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added support for the LableFor property of the HtmlLabel control - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* removed GetLabelFor method - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed support for HtmlCustom controls - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added support for HtmlRow controls, implemented by CUITe_HtmlRow, and integration tests - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added support to wrap an HTML IFrame, CUITe_HtmlIFrame thanks to [@deepakguna](https://www.codeplex.com/site/users/view/deepakguna)
* added Enabled_OnDisabledHtmlInputButton_ReturnsFalse test - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added Get_UsingMultipleValuesOfClassAttributeWithContainsOperatorOfHtmlSpan_ReturnsTheSpecificElementWithAllSpecifiedClassValues and GetSelectedValue_OfRadioButton_Succeeds test methods - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed SelectItem_UsingHtmlComboBoxThatAlertsOnChange_Succeeds - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed Launch_ObjectRepositoryTempHtmlFile_CanFindUnorderedListsByTagAndClassName test - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed html5 control sample test method - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added SetText_OnHtmlPassword_Succeeds test - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed Launch_ObjectRepositoryTempHtmlFile_CanFindUnorderedListsByTagAndClassName test method - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* removed hintpath for UnitTestFramework assembly - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* updated DynamicBrowserWindowTitleRepository and TestHtmlPage to use properties to declare html elements which use "this.Get<T>" instead of field initializers - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added DataManager_GetDataRowUsingEmbeddedResourceFromTypeAsString_Succeeds test - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* updated browser window tests to use generic \ non browser specific window titles - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed CUITe_BrowserWindow.Launch by using BrowserWindow.CopyFrom - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added support for .net 4 for Visual Studio 2013 (but without silverlight support) - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* removed adding SearchConfiguration.AlwaysSearch to SearchConfigurations when wrapping a control to fix issue encountered in discussion [#522298](https://cuite.codeplex.com/discussions/522298) - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* using %ProgramFilesDir%\Microsoft Visual Studio 12.0\VC\vcvarsall.bat - [@SpaghettiCoder](https://www.codeplex.com/site/users/view/SpaghettiCoder)
* added required dependency, Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight.dll - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* updated references to ..\Third Party\Microsoft\Visual Studio 2010 Feature Pack 2\Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight.dll - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* using relative path to MSBuild Community Tasks - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added dependency, Visual Studio UI Test Plugin for Silverlight and updated project references accordingly - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* fixed reference to TestSilverlightApplication - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* creating one zip file during the build with assemblies for all platforms - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)
* added support for .NET v4.5 (VS2013) - [@icnocop](https://www.codeplex.com/site/users/view/icnocop)


1.0.6.0 (1/24/2013)
===================

*Bugs*

* [#882](http://cuite.codeplex.com/workitem/882): Fixed whitespace in attributes are not preserved when CUITe looks for controls
* Fixed issue where an HtmlEdit control is returned instead of an HtmlPassword control
* [#379395](http://cuite.codeplex.com/discussions/379395): Fixed issue when working with html table rows with header cells
* [#1011](http://cuite.codeplex.com/workitem/1011): Fixed issue when working with html table with header columns
* [#400874](https://cuite.codeplex.com/discussions/400874): Fixed issues when using the CUITe_HtmlTable.FindRow method

*Features*

* added support for Html Heading tags - h1, h2, h3, h4, h5, h6
* [#766](http://cuite.codeplex.com/workitem/766): Fixed fillSearchProperties() issue
* [#556](http://cuite.codeplex.com/workitem/556): Added support for Win and Wpf controls
* [#609](http://cuite.codeplex.com/workitem/609): CUITe_InvalidSearchKey exception displays all the available control properties that can be used
* added support for finding controls just by their control type and without search parameters
* implemented CUITe_HtmlDocument wrapper for HtmlDocument
* [#366106](https://cuite.codeplex.com/discussions/366106): added support for HtmlUnorderedList, HtmlOrderedList, and HtmlListItem
* [#607](http://cuite.codeplex.com/workitem/607): CUITe_BrowserWindow constructor accepts a window title as a parameter
* [#390777](https://cuite.codeplex.com/discussions/390777): added CUITe_DynamicBrowserWindow to support interacting with web pages that contain dynamic window titles.
* added wrapper class for silverlight password control
* [#330874](http://cuite.codeplex.com/discussions/330874): support <input type="image" /> in Object Recorder
* [#633](http://cuite.codeplex.com/workitem/633): Support for Silverlight spinner control
* [#897](https://cuite.codeplex.com/workitem/897): Added public CUITe_HtmlTable.GetCell(...) method which returns a CUITe_HtmlCell instance
* [#397051](https://cuite.codeplex.com/discussions/397051): Implemented CUITe_HtmlCustom for easier extensibility and CUITe_HtmlIns to support the <ins /> html tag
* [#396767](https://cuite.codeplex.com/discussions/396767): Implemented CUITe_HtmlXml to support the <xml /> html tag
* [#400116](https://cuite.codeplex.com/discussions/400116): Added support for HtmlHeaderCell using CUITe_HtmlHeaderCell and public methods CUITe_HtmlTable.FindHeaderAndClick(int iRow, int iCol) and CUITe_HtmlTable.GetHeader(int iRow, int iCol) for more functionality
* [#399948](https://cuite.codeplex.com/discussions/399948): Added public property CUITe_HtmlTable.ColumnCount
* [#1047](https://cuite.codeplex.com/workitem/1047): Added support for CUITe_HtmlEditableDiv and CUITe_HtmlEditableSpan, thanks to flapmio
* [#406609](http://cuite.codeplex.com/discussions/406609): Added a SelectedItems property wrapper for the CUITe_HtmlList control
* [#1089](https://cuite.codeplex.com/workitem/1089): Added visual studio 2012 sln and accompanying projects to target .net 4.5

*Misc*

* [#781](http://cuite.codeplex.com/workitem/781): Fixed Microsoft.VisualStudio.TestTools.UITest* project references
* simplified code; improved performance; resolved compiler warnings, removed duplicate code
* signing CUITe.dll with a strong name key
* added command line build support
* added msbuild project file to build solutions and create release zips
* added readme.txt to document development environment system requirements and build instructions
* [#564](http://cuite.codeplex.com/workitem/564): removed setup project in favor of zipped binaries

1.0.5.0 (2/10/2012)
===================

* First public release on [CodePlex](https://cuite.codeplex.com).