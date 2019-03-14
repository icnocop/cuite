[![Build Status](https://dev.azure.com/rami/cuite/_apis/build/status/cuite-CI?branchName=master)](https://dev.azure.com/rami/cuite/_build/latest?definitionId=9&branchName=master)

## What is CUITe?

CUITe (Coded UI Test enhanced) Framework is a thin layer developed on top of Microsoft Visual Studio Team Test's Coded UI Test engine which helps reduce code, increases readability and maintainability, while also providing a bunch of cool features for the automation engineer.

## Supported technologies

- HTML
- WPF
- WinForms
- Silverlight

## Supported Visual Studio versions

- Visual Studio 2010 Ultimate or Premium with Feature Pack 2
- Visual Studio 2012 Ultimate or Premium
- Visual Studio 2013 Ultimate or Premium
- Visual Studio 2015 Enterprise
- Visual Studio 2017 Enterprise

## Installation

Install CUITe using NuGet and make sure you include prerelease packages.

### Install CUITe using the NuGet Package Manager

If your intent is to test HTML you might also want to install [Selenium components for Coded UI Cross Browser Testing](https://visualstudiogallery.msdn.microsoft.com/11cfc881-f8c9-4f96-b303-a2780156628d).

The NuGet package to install depends on the Visual Studio version you are using.

#### CUITe in Visual Studio 2010

Installing CUITe for HTML, WPF and WinForms:

```Install-Package CUITe.VS2010 -Pre```

Install CUITe for Silverlight:

```Install-Package CUITe.Silverlight.VS2010 -Pre```

#### CUITe in Visual Studio 2012

Installing CUITe for HTML, WPF and WinForms:

```Install-Package CUITe.VS2012 -Pre```

Install CUITe for Silverlight:

```Install-Package CUITe.Silverlight.VS2012 -Pre```

You should also install the extension [Microsoft Visual Studio 2012 Coded UI Test Plugin for Silverlight](https://marketplace.visualstudio.com/items?itemName=PrachiBoraMSFT.MicrosoftVisualStudioUITestPluginforSilverlight).

#### CUITe in Visual Studio 2013

Installing CUITe for HTML, WPF and WinForms:

```Install-Package CUITe.VS2013 -Pre```

Install CUITe for Silverlight using the NuGet Package Manager:

```Install-Package CUITe.Silverlight.VS2013 -Pre```

You should also install the extension [Microsoft Visual Studio 2013 Coded UI Test Plugin for Silverlight](https://marketplace.visualstudio.com/items?itemName=PrachiBoraMSFT.MicrosoftVisualStudio2013CodedUITestPluginforSilve).

#### CUITe in Visual Studio 2015

Installing CUITe for HTML, WPF and WinForms:

```Install-Package CUITe.VS2015 -Pre```

Install CUITe for Silverlight using the NuGet Package Manager:

```Install-Package CUITe.Silverlight.VS2015 -Pre```

You should also install the extension [Microsoft Visual Studio 2015 Coded UI Test Plugin for Silverlight](https://marketplace.visualstudio.com/items?itemName=AtinBansal.MicrosoftVisualStudio2015CodedUITestPluginforSilve).

#### CUITe in Visual Studio 2017

Installing CUITe for HTML, WPF and WinForms:

```Install-Package CUITe.VS2017 -Pre```

Install CUITe for Silverlight using the NuGet Package Manager:

```Install-Package CUITe.Silverlight.VS2017 -Pre```

You should also install the extension [Unofficial Microsoft Visual Studio 2017 Coded UI Test Plugin for Silverlight](https://marketplace.visualstudio.com/items?itemName=RamiAbughazaleh.CodedUITestPluginForSilverlight).

## Using CUITe

As best practice, we recommend writing object repositories for a more object-oriented approach to testing.
Object repositories can more easily be created using the object recorder instead of manually creating them for HTML web pages.
For more information see [Recording objects using the CUITe Object Recorder](#recording-objects-using-the-cuite-object-recorder) or more code examples [here](https://github.com/icnocop/cuite/tree/master/src).

Here are simple examples of testing filling out a form:

### HTML
```
// Launch the web browser and navigate to the homepage
BrowserWindowUnderTest browserWindow = BrowserWindowUnderTest.Launch("https://website.com");

// Enter the first name
browserWindow.Find<HtmlEdit>(By.Id("FirstName")).Text = "John";

// Enter the last name
browserWindow.Find<HtmlPassword>(By.Id("LastName")).Text ="Doe";

// Click the Save button
browserWindow.Find<HtmlInputButton>(By.Id("Save")).Click();
```

### WPF
```
// Launch the application
ApplicationUnderTest.Launch(@"C:\path to your application.exe");

// Find the main window of your application
WpfWindow window = new WpfWindow(By.Name("Main Window Title"));

// Enter the first name
window.Find<WpfEdit>(By.Name("FirstName")).Text = "John";

// Enter the last name
window.Find<WpfEdit>(By.Name("LastName")).Text = "Doe";

// Click on the Save button
window.Find<WinButton>(By.Name("Save")).Click();
```

### WinForms
```
// Launch the application
ApplicationUnderTest.Launch(@"C:\path to your application.exe");

// Find the main window of your application
WinWindow window = new WinWindow(By.Name("Main Window Title"));

// Enter the first name
window.Find<WinEdit>(By.Name("FirstName")).Text = "John";

// Enter the last name
window.Find<WinEdit>(By.Name("LastName")).Text = "Doe";

// Click on the Save button
window.Find<WinButton>(By.Name("Save")).Click();
```

### Silverlight

```
// Launch the browser where the silverlight application is hosted
BrowserWindowUnderTest browser = BrowserWindowUnderTest.Launch("https://website.com");

// Enter the first name
browser.Find<SilverlightEdit>(By.AutomationId("FirstName")).Text = "John";

// Enter the last name
browser.Find<SilverlightEdit>(By.AutomationId("LastName")).Text = "Doe";

// Click on the Save button
browser.Find<SilverlightButton>(By.AutomationId("Save")).Click();
```

## Recording objects using the CUITe Object Recorder

The CUITe Object Recorder supports recording objects from an HTML web page only.

1. Launch the CUITe Object Recorder from the location where the NuGet package was installed.

   For example, launch /packages/CUITe.VS2013.x.x.x/tools/CUITe_ObjectRecorder.exe, relative to your solution.

2. Enter the full address of your web page in the Address field (ex. http://website.com).
3. Click on the 'Record' button.
4. Click on the objects you want to record actions against.
5. Click on the 'Code' button.
6. Copy the code and paste it in a new file in your Coded UI Test project.
7. Change the placeholder '$ProjectNameSpace$' with your namespace.
8. Use the class and generated code in a more object-oriented fashion:
```
// Launch the web page
MyObjectRepository browserWindow = BrowserWindowUnderTest.Launch<MyObjectRepository>("https://website.com");

// Enter the first name
browserWindow.FirstName.Text = "John";

// Enter the last name
browserWindow.LastName.Text ="Doe";

// Click on the Save button
browserWindow.Save.Click();
```

## Contact

[![Join the chat at https://gitter.im/icnocop/cuite](https://badges.gitter.im/icnocop/cuite.svg)](https://gitter.im/icnocop/cuite?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)