#### What is CUITe?

CUITe (Coded UI Test enhanced) Framework is a thin layer developed on top of Microsoft Visual Studio Team Test's Coded UI Test engine which helps reduce code, increases readability and maintainability, while also providing a bunch of cool features for the automation engineer.

#### Supported technologies

- HTML
- WPF
- WinForms
- Silverlight

#### Supported Visual Studio versions

- Visual Studio 2010 Ultimate or Premium and Feature Pack 2
- Visual Studio 2012 Ultimate or Premium
- Visual Studio 2013 Ultimate or Premium
- Visual Studio 2015 Enterprise

#### Requirements

###### Testing HTML

[Selenium components for Coded UI Cross Browser Testing](https://visualstudiogallery.msdn.microsoft.com/11cfc881-f8c9-4f96-b303-a2780156628d)

###### Testing Silverlight

[Microsoft Visual Studio 2012 Coded UI Test Plugin for Silverlight](https://visualstudiogallery.msdn.microsoft.com/28312a61-9451-451a-990c-c9929b751eb4)
[Microsoft Visual Studio 2013 Coded UI Test Plugin for Silverlight](https://visualstudiogallery.msdn.microsoft.com/51b4a94a-1878-4dcc-81e0-7dc92131d2da)

#### Installation

Install CUITe using NuGet.

Make sure you include prerelease packages.

For example, to install CUITe using the NuGet Package Manager:

CUITe for HTML/WPF/WinForms: `Install-Package CUITe -Pre`
CUITe Silverlight for Visual Studio 2012: `Install-Package CUITe.Silverlight.VS2012 -Pre`
CUITe Silverlight for Visual Studio 2013: `Install-Package CUITe.Silverlight.VS2013 -Pre`

#### Using CUITe

As best practice, we recommend writing object repositories for a more object-oriented approach to testing.
Object repositories can more easily be created using the object recorder instead of manually creating them for HTML web pages.
For more information see [Recording objects using the CUITe Object Recorder](#recording-objects-using-the-cuite-object-recorder) or more code examples [here](https://github.com/icnocop/cuite/tree/master/src).

Here are simple examples of testing filling out a form:

##### HTML
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

##### WPF
```
// Launch the application
ApplicationUnderTest.Launch(@"C:\path to your application.exe");

// Find the main window of your application
WpfWindow window = new WpfWindow(By.Name("Main Window Title"));

// Enter the first name
window.Find<WpfEdit>(By.Name("FirstName")).Text = "John"

// Enter the last name
window.Find<WpfEdit>(By.Name("LastName")).Text = "Doe";

// Click on the Save button
window.Find<WinButton>(By.Name("Save")).Click();
```

##### WinForms
```
// Launch the application
ApplicationUnderTest.Launch(@"C:\path to your application.exe");

// Find the main window of your application
WinWindow window = new WinWindow(By.Name("Main Window Title"));

// Enter the first name
window.Find<WinEdit>(By.Name("FirstName")).Text = "John"

// Enter the last name
window.Find<WinEdit>(By.Name("LastName")).Text = "Doe";

// Click on the Save button
window.Find<WinButton>(By.Name("Save")).Click();
```

##### Silverlight

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

#### Recording objects using the CUITe Object Recorder

The CUITe Object Recorder supports recording objects from an HTML web page only.

1. Launch the CUITe Object Recorder from the location where the nuget package was installed.

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

#### Building

Run Build.bat from a command prompt to build all projects using the Release configuration.  

Run Test.bat from a command prompt to execute all UI tests.
