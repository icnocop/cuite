using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using TechTalk.SpecFlow;
using TestHelpers;
using VSLangProj;
using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.IntegrationTests.NuGet
{
    /// <summary>
    /// NuGet Feature Steps
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    [Binding]
    public class NuGetFeatureSteps : IDisposable
    {
        private string visualStudioProgramId;

        private string visualStudioProjectTemplateCachePath;

        private string visualStudioItemTemplateCachePath;

        private TempDirectory solutionDirectory;

        private DTE2 dte;

        private VisualStudioAutomation visualStudio;

        private Solution2 solution;

        private VSProject testProject;

        private string testProjectPath;

        private string visualStudioVersionNumber;

        private string codedUiTestTemplatePath;

        private string visualStudioVersion;

        private string testProjectTemplatePath;

        private bool isSilverlightNuGetPackage;

        private string solutionFilePath;

        private string testSettingsFilePath;

        private string codedUiTestCsFilePath;

        private const string SolutionName = "NewSolution";
        private const string ProjectName = "TestProject";

        /// <summary>
        /// Initializes a new instance of the <see cref="NuGetFeatureSteps"/> class.
        /// </summary>
        public NuGetFeatureSteps()
        {
            MessageFilter.Register();
        }

        private string NuGetPackageId { get; set; }

        private string TargetFrameworkVersion { get; set; }

        /// <summary>
        /// Given the Visual Studio version (.*).
        /// </summary>
        /// <param name="visualStudioVersion">The visual studio version.</param>
        /// <exception cref="NotSupportedException">
        /// </exception>
        [Given(@"the Visual Studio version (.*)")]
        public void GivenTheVisualStudioVersion(string visualStudioVersion)
        {
            Trace.WriteLine(string.Format("Visual Studio Version: {0}", visualStudioVersion));

            this.visualStudioVersion = visualStudioVersion;

            Dictionary<string, string> visualStudioVersionMap = new Dictionary<string, string>
            {
                { "2010", "10" },
                { "2012", "11" },
                { "2013", "12" },
                { "2015", "14" },
                { "2017", "15" }
            };

            if (!visualStudioVersionMap.ContainsKey(visualStudioVersion))
            {
                throw new NotSupportedException(string.Format("Visual Studio version {0} not support", visualStudioVersion));
            }

            this.visualStudioVersionNumber = visualStudioVersionMap[visualStudioVersion];

            Trace.WriteLine(string.Format("Visual Studio Version Number: {0}", this.visualStudioVersionNumber));

            this.visualStudioProgramId = string.Format("VisualStudio.DTE.{0}.0", this.visualStudioVersionNumber);

            Trace.WriteLine(string.Format("Visual Studio Program Id: {0}", this.visualStudioProgramId));

            // get the visual studio project template cache path
            // ex. c:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\ProjectTemplatesCache
            this.visualStudioProjectTemplateCachePath = this.GetVisualStudioProjectTemplateCachePath(this.visualStudioVersionNumber);

            Trace.WriteLine(string.Format("Visual Studio Project Template Cache Path: {0}", this.visualStudioProjectTemplateCachePath));

            // get the visual studio item template cache path
            // ex. c:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\ItemTemplatesCache
            this.visualStudioItemTemplateCachePath = this.GetVisualStudioItemTemplateCachePath(this.visualStudioVersionNumber);

            Trace.WriteLine(string.Format("Visual Studio Item Template Cache Path: {0}", this.visualStudioItemTemplateCachePath));

            switch (this.visualStudioVersionNumber)
            {
                case "10":
                    this.testProjectTemplatePath = Path.Combine(this.visualStudioProjectTemplateCachePath, @"CSharp\Test\1033\TestProject.zip");
                    this.codedUiTestTemplatePath = Path.Combine(this.visualStudioItemTemplateCachePath, @"CSharp\1033\CodedUITest.zip");
                    break;
                case "11":
                case "12":
                case "14":
                case "15":
                    this.testProjectTemplatePath = Path.Combine(this.visualStudioProjectTemplateCachePath, @"CSharp\Test\1033\TestProject");
                    this.codedUiTestTemplatePath = Path.Combine(this.visualStudioItemTemplateCachePath, @"CSharp\Test\1033\CodedUITest");
                    break;
                default:
                    throw new NotSupportedException(string.Format("Visual Studio version {0} not support", this.visualStudioVersionNumber));
            }

            Trace.WriteLine(string.Format("Visual Studio Coded UI Test Template Path: {0}", this.codedUiTestTemplatePath));
        }

        /// <summary>
        /// When a new Coded UI test project is created with platform (.*).
        /// </summary>
        /// <param name="platform">The platform.</param>
        /// <exception cref="Exception">Failed to convert Project to VSProject.</exception>
        [When(@"a new Coded UI test project is created with platform (.*)")]
        public void WhenANewCodedUITestProjectIsCreatedWithPlatform(string platform)
        {
            this.TargetFrameworkVersion = platform;

            using (new TemporaryEnvironmentVariable("VisualStudioVersion", string.Format("{0}.0", this.visualStudioVersionNumber)))
            {
                Type type = Type.GetTypeFromProgID(this.visualStudioProgramId);
                Object obj = Activator.CreateInstance(type, true);

                this.dte = (DTE2)obj;
            }

            this.dte.MainWindow.Visible = true;
            this.dte.UserControl = true;

            // create a new solution
            this.solutionDirectory = new TempDirectory();

            this.dte.Solution.Create(this.solutionDirectory.DirectoryPath, SolutionName);
            this.solutionFilePath = Path.Combine(this.solutionDirectory.DirectoryPath, SolutionName + ".sln");
            this.visualStudio = new VisualStudioAutomation(this.dte);
            this.solution = (Solution2)this.dte.Solution;

            // for troubleshooting purposes, uncomment the next two lines
            //this.solutionDirectory.DeleteDirectoryOnDispose = false;
            //this.visualStudio.QuitVisualStudioOnDispose = false;

            // create a test project
            this.testProjectPath = Path.Combine(this.solutionDirectory.DirectoryPath, ProjectName);

            using (TempDirectory projectTemplateDirectory = new TempDirectory())
            {
                this.ConfigureTemplate(this.testProjectTemplatePath, "TestProject.vstemplate", projectTemplateDirectory.DirectoryPath);

                string testProjectTemplateFilePath = Path.Combine(projectTemplateDirectory.DirectoryPath, "TestProject.vstemplate");

                Trace.WriteLine(string.Format("Creating test project '{0}' in '{1}' using template '{2}'...", ProjectName, this.testProjectPath, testProjectTemplateFilePath));

                this.solution.AddFromTemplate(string.Format("{0}|$targetframeworkversion$={1}", testProjectTemplateFilePath, platform), this.testProjectPath, ProjectName);

                foreach (Project project in this.solution.Projects)
                {
                    if (project.Name != ProjectName)
                    {
                        continue;
                    }

                    this.testProject = (VSProject)project.Object;
                    if (this.testProject == null)
                    {
                        throw new Exception("Failed to convert Project to VSProject.");
                    }

                    break;
                }

                Assert.IsNotNull(this.testProject);
            }

            using (TempDirectory templateDirectory = new TempDirectory())
            {
                this.ConfigureTemplate(this.codedUiTestTemplatePath, "CodedUITest.vstemplate", templateDirectory.DirectoryPath, true);

                string templateFile = Path.Combine(templateDirectory.DirectoryPath, "CodedUITest.vstemplate");

                string name = "CodedUITest.cs";

                Trace.WriteLine(string.Format("Adding project item '{0}' from template '{1}'...", name, templateFile));

                this.testProject.Project.ProjectItems.AddFromTemplate(templateFile, name);

                foreach (ProjectItem projectItem in this.testProject.Project.ProjectItems)
                {
                    if (projectItem.Name.Equals(name))
                    {
                        this.codedUiTestCsFilePath = projectItem.Properties.Item("FullPath").Value.ToString();
                        break;
                    }
                }

                Assert.IsFalse(string.IsNullOrEmpty(this.codedUiTestCsFilePath));
            }

            foreach (Reference projectReference in this.testProject.References)
            {
                if (new[]
                    {
                        "Microsoft.VisualStudio.QualityTools.CodedUITestFramework",
                        "Microsoft.VisualStudio.TestTools.UITest.Common",
                        "Microsoft.VisualStudio.TestTools.UITest.Extension",
                        "Microsoft.VisualStudio.TestTools.UITest.Extension.Firefox",
                        "Microsoft.VisualStudio.TestTools.UITesting"
                    }.Contains(projectReference.Name))
                {
                    projectReference.CopyLocal = false;
                }
            }
        }

        private void ConfigureTemplate(string source, string templateFileName, string destination, bool forceUpdate = false)
        {
            Trace.WriteLine(string.Format("Copying template from '{0}' to '{1}'...", source, destination));

            foreach (string file in Directory.GetFiles(source))
            {
                string fileName = Path.GetFileName(file);
                Assert.IsNotNull(fileName);
                File.Copy(file, Path.Combine(destination, fileName));
            }

            string testProjectTemplateFilePath = Path.Combine(destination, templateFileName);

            if ((this.visualStudioVersion != "2010") || forceUpdate)
            {
                Trace.WriteLine(string.Format("Updating '{0}'...", testProjectTemplateFilePath));

                XmlDocument document = new XmlDocument();
                document.Load(testProjectTemplateFilePath);
                XmlNameTable nameTable = document.NameTable;
                XmlNamespaceManager namespaceManager = new XmlNamespaceManager(nameTable);

                string namespaceUri = "http://schemas.microsoft.com/developer/vstemplate/2005";
                namespaceManager.AddNamespace("def", namespaceUri);

                XmlNode vsTemplateNode = document.SelectSingleNode("/def:VSTemplate", namespaceManager);
                Assert.IsNotNull(vsTemplateNode);

                XmlNode wizardExtensionNode = vsTemplateNode.SelectSingleNode(".//def:WizardExtension", namespaceManager);
                Assert.IsNotNull(wizardExtensionNode);
                vsTemplateNode.RemoveChild(wizardExtensionNode);

                XmlNode templateContentNode = vsTemplateNode.SelectSingleNode(".//def:TemplateContent", namespaceManager);
                Assert.IsNotNull(templateContentNode);

                XmlNode referencesNode = templateContentNode.SelectSingleNode(".//def:References", namespaceManager);
                if (referencesNode == null)
                {
                    XmlElement references = document.CreateElement("References", namespaceUri);
                    referencesNode = templateContentNode.AppendChild(references);
                }
                Assert.IsNotNull(referencesNode);

                List<string> assemblyReferences = new List<string>
                {
                    this.GetFullAssemblyName("Microsoft.VisualStudio.QualityTools.UnitTestFramework", "10"),
                    this.GetFullAssemblyName("Microsoft.VisualStudio.QualityTools.CodedUITestFramework", this.visualStudioVersionNumber),
                    this.GetFullAssemblyName("Microsoft.VisualStudio.TestTools.UITest.Common", this.visualStudioVersionNumber),
                    this.GetFullAssemblyName("Microsoft.VisualStudio.TestTools.UITest.Extension", this.visualStudioVersionNumber),
                    this.GetFullAssemblyName("Microsoft.VisualStudio.TestTools.UITesting", this.visualStudioVersionNumber)
                };

                if (this.visualStudioVersion == "2010")
                {
                    assemblyReferences.AddRange(new[]
                    {
                        this.GetFullAssemblyName("Microsoft.VisualStudio.TestTools.UITest.Extension.Firefox", this.visualStudioVersionNumber),
                        this.GetFullAssemblyName("Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight", this.visualStudioVersionNumber)
                    });
                }

                foreach (string fullAssemblyName in assemblyReferences)
                {
                    Trace.WriteLine(string.Format("Adding reference '{0}' to template file '{1}'...", fullAssemblyName, testProjectTemplateFilePath));

                    XmlElement reference = document.CreateElement("Reference", namespaceUri);
                    XmlElement assembly = document.CreateElement("Assembly", namespaceUri);
                    assembly.InnerText = fullAssemblyName;
                    reference.AppendChild(assembly);
                    referencesNode.AppendChild(reference);
                }

                document.Save(testProjectTemplateFilePath);
            }
        }

        private string GetFullAssemblyName(string assemblyName, string majorVersionNumber)
        {
            return string.Format("{0}, Version={1}.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL", assemblyName, majorVersionNumber);
        }

        /// <summary>
        /// Gets the visual studio template cache path.
        /// </summary>
        /// <param name="visualStudioVersion">The visual studio version.</param>
        /// <param name="templateType">Type of the template.</param>
        /// <returns>
        /// The visual studio template cache path.
        /// For example, c:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\ItemTemplatesCache
        /// </returns>
        private string GetVisualStudioTemplateCachePath(string visualStudioVersion, string templateType)
        {
            List<string> registryKeys = new List<string>
            {
                "HKEY_LOCAL_MACHINE",
                "SOFTWARE"
            };

            if (Environment.Is64BitOperatingSystem)
            {
                registryKeys.Add("Wow6432Node");
            }

            registryKeys.AddRange(new[]
            {
                "Microsoft",
                "VisualStudio",
                string.Format("{0}.0", visualStudioVersion),
                "VSTemplate",
                templateType
            });

            string registryKeyName = string.Join(@"\", registryKeys);

            string registryValueName = "CacheFolder";
            object cacheFolder = Registry.GetValue(registryKeyName, registryValueName, null);
            if (cacheFolder == null)
            {
                throw new Exception(string.Format("Failed to get registry value '{0}' from key '{1}'", registryValueName, registryKeyName));
            }

            return cacheFolder.ToString();
        }

        private string GetVisualStudioInstallPath(string visualStudioVersion)
        {
            List<string> registryKeys = new List<string>
            {
                "HKEY_LOCAL_MACHINE",
                "SOFTWARE"
            };

            if (Environment.Is64BitOperatingSystem)
            {
                registryKeys.Add("Wow6432Node");
            }

            registryKeys.AddRange(new[]
            {
                "Microsoft",
                "VisualStudio",
                "SxS",
                "VS7"
            });

            string registryKeyName = string.Join(@"\", registryKeys);

            string registryValueName = $"{visualStudioVersion}.0";
            object installPath = Registry.GetValue(registryKeyName, registryValueName, null);
            if (installPath == null)
            {
                throw new Exception(string.Format("Failed to get registry value '{0}' from key '{1}'", registryValueName, registryKeyName));
            }

            return installPath.ToString();
        }

        /// <summary>
        /// Gets the visual studio project template cache path.
        /// </summary>
        /// <param name="visualStudioVersion">The visual studio version.</param>
        /// <returns>
        /// The visual studio project template cache path.
        /// For example, c:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\ProjectTemplatesCache
        /// </returns>
        private string GetVisualStudioProjectTemplateCachePath(string visualStudioVersion)
        {
            switch (visualStudioVersion)
            {
                case "15":
                    string installPath = this.GetVisualStudioInstallPath(visualStudioVersion);
                    return Path.Combine(installPath, "Common7", "IDE", "ProjectTemplates");
                default:
                    return this.GetVisualStudioTemplateCachePath(visualStudioVersion, "Project");
            }
        }

        /// <summary>
        /// Gets the visual studio item template cache path.
        /// </summary>
        /// <param name="visualStudioVersion">The visual studio version.</param>
        /// <returns>
        /// The visual studio item template cache path.
        /// For example, c:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\ItemTemplatesCache
        /// </returns>
        private string GetVisualStudioItemTemplateCachePath(string visualStudioVersion)
        {
            switch (visualStudioVersion)
            {
                case "15":
                    string installPath = this.GetVisualStudioInstallPath(visualStudioVersion);
                    return Path.Combine(installPath, "Common7", "IDE", "ItemTemplates");
                default:
                    return this.GetVisualStudioTemplateCachePath(visualStudioVersion, "Item");
            }
        }

        /// <summary>
        /// When the CUITe nuget package "Id","Name" is added to the project.
        /// </summary>
        /// <param name="nugetPackageId">The nuget package identifier.</param>
        /// <param name="nuGetProjectReferenceName">Name of the nu get project reference.</param>
        [When(@"the CUITe nuget package ""(.*)"", ""(.*)"" is added to the project")]
        public void WhenTheCUITeNugetPackageIsAddedToTheProject(string nugetPackageId, string nuGetProjectReferenceName)
        {
            this.NuGetPackageId = nugetPackageId;
            this.isSilverlightNuGetPackage = this.NuGetPackageId.Contains("Silverlight");

            this.InstallNuGetPackage(this.testProject, nugetPackageId, ProjectName, nuGetProjectReferenceName, Directory.GetCurrentDirectory(), true);
        }

        private void InstallNuGetPackage(
            VSProject project,
            string package,
            string projectName,
            string projectReferenceName,
            string source = null,
            bool includePrerelease = false,
            string version = null)
        {
            // activate Package Manager Console window
            const string packageManagerConsoleGuid = "{0AD07096-BBA9-4900-A651-0598D26F6D24}";

            Window packageManagerConsoleWindow = this.dte.Windows.Item(packageManagerConsoleGuid);
            packageManagerConsoleWindow.Activate();

            string commandName = "View.PackageManagerConsole";

            // Execute Install-Command in Package Manager Console
            List<string> nugetCommandArguments = new List<string>
            {
                string.Format("Install-Package {0}", package)
            };

            if (source != null)
            {
                nugetCommandArguments.Add(string.Format("-Source \"{0}\"", source));
            }

            nugetCommandArguments.Add(string.Format("-ProjectName {0}", projectName));

            if (includePrerelease)
            {
                nugetCommandArguments.Add("-IncludePrerelease");
            }

            if (version != null)
            {
                nugetCommandArguments.Add(string.Format("-Version {0}", version));
            }

            string nugetCommand = string.Join(" ", nugetCommandArguments);

            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            _dispCommandEvents_BeforeExecuteEventHandler commandEventsOnBeforeExecute = (string guid, int id, object @in, object @out, ref bool cancelDefault) =>
            {
                Trace.WriteLine(string.Format("Before Executing Command Guid: {0} In: {1} Out: {2}", this.ConvertGuidAndId(guid, id), @in, @out));
            };

            this.dte.Events.CommandEvents.BeforeExecute += commandEventsOnBeforeExecute;

            _dispCommandEvents_AfterExecuteEventHandler commandEventsOnAfterExecute = (guid, id, @in, @out) =>
            {
                Trace.WriteLine(string.Format("After Executing Command Guid: {0} In: {1} Out: {2}", this.ConvertGuidAndId(guid, id), @in, @out));

                if ((@in != null) && (@in.ToString().Trim() == nugetCommand))
                {
                    autoResetEvent.Set();
                }
            };

            this.dte.Events.CommandEvents.AfterExecute += commandEventsOnAfterExecute;

            this.ExecuteCommand(commandName, nugetCommand);

            autoResetEvent.WaitOne();

            this.dte.Events.CommandEvents.BeforeExecute -= commandEventsOnBeforeExecute;
            this.dte.Events.CommandEvents.AfterExecute -= commandEventsOnAfterExecute;

            Trace.WriteLine(string.Format("Finished executing command {0}", nugetCommand));

            Assert.IsNotNull(project);

            while (true)
            {
                if (project.References.Cast<Reference>()
                    .Where(reference => reference.SourceProject == null)
                    .Any(reference => reference.Name == projectReferenceName))
                {
                    Trace.WriteLine(string.Format("Found project reference to {0}", projectReferenceName));
                    break;
                }

                Trace.WriteLine(string.Format("Could not find project reference to {0}", projectReferenceName));

                Trace.WriteLine(string.Format("Active Window Caption: {0}", this.dte.ActiveWindow.Caption));

                System.Threading.Thread.Sleep(1000);
            }
        }

        private void ExecuteCommand(string commandName, string commandArgs = "")
        {
            const int maximumRetryCount = 10;
            const int waitBetweenRetriesInSeconds = 5;

            int retryCount = 0;

            while (retryCount < maximumRetryCount)
            {
                try
                {
                    this.dte.ExecuteCommand(commandName, commandArgs);

                    break;
                }
                catch (COMException ex)
                {
                    if (ex.ErrorCode != unchecked((int)0x80004005))
                    {
                        throw;
                    }

                    // Command "{0}" is not available.

                    Trace.WriteLine(ex);
                    retryCount++;
                }

                Trace.WriteLine(string.Format("Waiting {0} seconds", waitBetweenRetriesInSeconds));
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(waitBetweenRetriesInSeconds));
                Trace.WriteLine(string.Format("Finished waiting {0} seconds", waitBetweenRetriesInSeconds));
            }

            if (retryCount >= maximumRetryCount)
            {
                throw new Exception(string.Format("Failed to execute command: {0} {1}.", commandName, commandArgs));
            }
        }

        private string ConvertGuidAndId(string guid, int id)
        {
            string command = null;

            switch (guid)
            {
                case "{5EFC7975-14BC-11CF-9B2B-00AA00573819}":
                {
                    command += "VSConstants.VSStd97CmdID";

                    VSConstants.VSStd97CmdID commandId = (VSConstants.VSStd97CmdID)Enum.Parse(typeof(VSConstants.VSStd97CmdID), id.ToString());

                    string commandName = Enum.GetName(typeof(VSConstants.VSStd97CmdID), commandId);

                    command += string.Format(".{0}", commandName);
                }
                    break;
                case "{1E8A55F6-C18D-407F-91C8-94B02AE1CED6}":
                    command += "View.PackageManagerConsole.";

                    switch (id)
                    {
                        case 1024:
                            command += "PackageSource";
                            break;
                        case 1080:
                            command += "DefaultProject";
                            break;
                        case 256:
                            command += "CommandPrompt";
                            break;
                        default:
                            command += string.Format("Unknown {0}", id);
                            break;
                    }

                    break;
                case "{1496A755-94DE-11D0-8C3F-00C04FC2AAE2}":
                {
                    command += "VSConstants.VSStd2KCmdID";

                    VSConstants.VSStd2KCmdID commandId = (VSConstants.VSStd2KCmdID)Enum.Parse(typeof(VSConstants.VSStd2KCmdID), id.ToString());

                    string commandName = Enum.GetName(typeof(VSConstants.VSStd2KCmdID), commandId);

                    command += string.Format(".{0}", commandName);
                }
                    break;
                default:
                    command += string.Format("Unknown command {0} {1}", guid, id);
                    break;
            }

            return command;
        }

        /// <summary>
        /// When the test methods are added to the project which use CUITe to test the sample application(s).
        /// </summary>
        [When(@"test methods are added to the project which use CUITe to test the sample application\(s\)")]
        public void WhenTestMethodsAreAddedToTheProjectWhichUseCUITeToTestTheSampleApplicationS()
        {
            // HTML
            Assembly assembly = Assembly.GetExecutingAssembly();

            string htmlTestsCsFilePath = Path.Combine(this.testProjectPath, "HtmlTests.cs");
            AssemblyResourceLoader.ExtractEmbeddedResource(assembly, "CUITe.IntegrationTests.NuGet.HtmlTests.cs", htmlTestsCsFilePath);
            this.testProject.Project.ProjectItems.AddFromFile(htmlTestsCsFilePath);

            string tempWebPageCsFilePath = Path.Combine(this.testProjectPath, "TempWebPage.cs");
            AssemblyResourceLoader.ExtractEmbeddedResource(assembly, "CUITe.IntegrationTests.NuGet.TempWebPage.cs", tempWebPageCsFilePath);
            this.testProject.Project.ProjectItems.AddFromFile(tempWebPageCsFilePath);

            if (this.isSilverlightNuGetPackage)
            {
                // Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight.dll
                string microsoftVisualStudioTestToolsUITestExtensionSilverlightDllFilePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86),
                    "microsoft shared",
                    "VSTT",
                    string.Format("{0}.0", this.visualStudioVersionNumber),
                    "UITestExtensionPackages",
                    "Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight.dll");

                Assert.IsTrue(File.Exists(microsoftVisualStudioTestToolsUITestExtensionSilverlightDllFilePath),
                    string.Format("File doesn't exist: {0}", microsoftVisualStudioTestToolsUITestExtensionSilverlightDllFilePath));

                this.testProject.References.Add(microsoftVisualStudioTestToolsUITestExtensionSilverlightDllFilePath);

                // SilverlightControlTests.cs
                string silverlightControlTestsCsFilePath = Path.Combine(this.testProjectPath, "SilverlightControlTests.cs");
                AssemblyResourceLoader.ExtractEmbeddedResource(assembly, "CUITe.IntegrationTests.NuGet.SilverlightControlTests.cs", silverlightControlTestsCsFilePath);
                this.testProject.Project.ProjectItems.AddFromFile(silverlightControlTestsCsFilePath);

                // TestPage.cs
                string testPageCsFilePath = Path.Combine(this.testProjectPath, "TestPage.cs");
                AssemblyResourceLoader.ExtractEmbeddedResource(assembly, "CUITe.IntegrationTests.NuGet.TestPage.cs", testPageCsFilePath);
                this.testProject.Project.ProjectItems.AddFromFile(testPageCsFilePath);

                // CassiniDev 4.0
                // wait for 10 seconds otherwise the following error may appear in a message box for which can't be dismissed programmatically when trying to install multiple NuGet packages:
                // "Package Manager Console busy at the moment..."
                System.Threading.Thread.Sleep(10000);

                this.InstallNuGetPackage(this.testProject, "CassiniDev", ProjectName, "CassiniDev4-lib", version: "4.0.0");

                // Sut.Silverlight.html
                const string silverlightHtmlFileName = "Sut.Silverlight.html";
                string sutSilverlightHtmlFilePath = Path.Combine(this.testProjectPath, silverlightHtmlFileName);
                string sutSilverlightHtmlFileResourceName = string.Format("CUITe.IntegrationTests.NuGet.{0}", silverlightHtmlFileName);
                Trace.WriteLine(string.Format("Extracting embedded resource '{0}' to '{1}'", sutSilverlightHtmlFileResourceName, sutSilverlightHtmlFilePath));
                AssemblyResourceLoader.ExtractEmbeddedResource(assembly, sutSilverlightHtmlFileResourceName, sutSilverlightHtmlFilePath);
                ProjectItem sutSilverlightHtmlProjectItem = this.testProject.Project.ProjectItems.AddFromFile(sutSilverlightHtmlFilePath);
                this.SetCopyToOutputDirectory(sutSilverlightHtmlProjectItem);

                // Sut.Silverlight.xap
                const string silverlightXapFileName = "Sut.Silverlight.xap";
                string sutSilverlightXapFilePath = Path.Combine(this.testProjectPath, silverlightXapFileName);
                string sutSilverlightXapFileResourceName = string.Format("CUITe.IntegrationTests.NuGet.VisualStudio{0}.{1}", this.visualStudioVersion, silverlightXapFileName);
                Trace.WriteLine(string.Format("Extracting embedded resource '{0}' to '{1}'", sutSilverlightXapFileResourceName, sutSilverlightXapFilePath));
                AssemblyResourceLoader.ExtractEmbeddedResource(assembly, sutSilverlightXapFileResourceName, sutSilverlightXapFilePath);
                ProjectItem sutSilverlightXapProjectItem = this.testProject.Project.ProjectItems.AddFromFile(sutSilverlightXapFilePath);
                this.SetCopyToOutputDirectory(sutSilverlightXapProjectItem);

                const string localTestSettingsFileName = "Local.testsettings";
                this.testSettingsFilePath = Path.Combine(this.solutionDirectory.DirectoryPath, localTestSettingsFileName);

                const string namespaceUri = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010";

                if (this.visualStudioVersionNumber != "10")
                {
                    // Visual Studio 2010 will automatically create a Local.testsettings file but with deployment disabled
                    // add new test settings solution item
                    /*Project solutionItemsProject =*/ this.solution.AddSolutionFolder("Solution Items");

                    XNamespace ns = XNamespace.Get(namespaceUri);

                    XDocument doc = new XDocument(
                        new XDeclaration("1.0", "UTF-8", ""),
                        new XElement(ns + "TestSettings",
                            new XAttribute("name", "Local"),
                            new XAttribute("id", Guid.NewGuid().ToString()),
                            new XElement(ns + "Description", "These are default test settings for a local test run."),
                            new XElement(ns + "Deployment",
                                new XAttribute("enabled", "true"))));
                    doc.Save(this.testSettingsFilePath);

                    // if we try to add the file to the solution using automation, the file will automatically open
                    // when specifically adding a test settings file, a modal wizard dialog will automatically be displayed that needs to be manually closed
                    // solutionItemsProject.ProjectItems.AddFromFile(this.testSettingsFilePath);
                    // so update the sln file directly

                    // select test settings file
                    System.Diagnostics.Process visualStudioProcess = System.Diagnostics.Process.GetProcessesByName("devenv").Single(x => x.MainWindowTitle.Contains(SolutionName));
                    VisualStudioScreen visualStudio = Screen.FromProcess<VisualStudioScreen>(visualStudioProcess);
                    visualStudio.TestMenuItem.Click();
                    visualStudio.TestSettingsMenuItem.Click();
                    visualStudio.SelectTestSettingsFileMenuItem.Click();

                    Playback.PlaybackSettings.WaitForReadyTimeout = 1000; // 60000

                    OpenTestSettingsFileWindow openTestSettingsFileWindow  = new OpenTestSettingsFileWindow();
                    openTestSettingsFileWindow.FileName.EditableItem = this.testSettingsFilePath;
                    openTestSettingsFileWindow.OpenButton.Click();
                }

                // For troubleshooting purposes, enable logging in App.config:
                string appConfigFilePath = Path.Combine(this.testProjectPath, "App.config");
                Assert.IsTrue(!File.Exists(appConfigFilePath));
                const string appConfigFileResourceName = "CUITe.IntegrationTests.NuGet.App.config";
                Trace.WriteLine(string.Format("Extracting embedded resource '{0}' to '{1}'", appConfigFileResourceName, appConfigFilePath));
                AssemblyResourceLoader.ExtractEmbeddedResource(assembly, appConfigFileResourceName, appConfigFilePath);
                this.testProject.Project.ProjectItems.AddFromFile(appConfigFilePath);
                //File.WriteAllLines(appConfigFilePath, new[]
                //{
                //    "<configuration>",
                //    "  <system.diagnostics>",
                //    "    <switches>",
                //    "      <add name=\"EqtTraceLevel\" value=\"4\" />",
                //    "    </switches>",
                //    "  </system.diagnostics>",
                //    "</configuration>"
                //});
                //xmlDocument.Load(appConfigFilePath);

                //string xpath = "/configuration";
                //XmlNode configurationNode = xmlDocument.SelectSingleNode(xpath);
                //if (configurationNode == null)
                //{
                //    throw new Exception(string.Format("Failed to select single node with xpath '{0}' in file '{1}'", xpath, appConfigFilePath));
                //}

                //xpath = "/system.diagnostics";
                //XmlNode systemDiagnosticsNode = configurationNode.SelectSingleNode(xpath);
                //if (systemDiagnosticsNode == null)
                //{
                //    throw new Exception(string.Format("Failed to select single node with xpath '{0}' in file '{1}'", xpath, appConfigFilePath));
                //}

                //xpath = "/switches";
                //XmlNode switchesNode = systemDiagnosticsNode.SelectSingleNode(xpath);
                //if (switchesNode == null)
                //{
                //    throw new Exception(string.Format("Failed to select single node with xpath '{0}' in file '{1}'", xpath, appConfigFilePath));
                //}

                //xpath = "/add[@name='EqTaceLevel']";
                //XmlNode addNode = switchesNode.SelectSingleNode(xpath);
                //if (addNode == null)
                //{
                //    throw new Exception(string.Format("Failed to select single node with xpath '{0}' in file '{1}'", xpath, appConfigFilePath));
                //}

                //if (addNode.Attributes == null)
                //{
                //    throw new Exception(string.Format("Xml node attributes at xpath '{0}' in file '{1}' is null", xpath, appConfigFilePath));
                //}

                //addNode.Attributes["value"].Value = "4";
                //xmlDocument.Save(appConfigFilePath);

                // add Sut.Silverlight.xap as a deployment item
                // enable deployment
                // Change the following:
                // <TestSettings>
                //   <Deployment enabled="false" />
                // ...
                // To this:
                // <TestSettings>
                //   <Deployment enabled="true">
                //     <DeploymentItem filename="TestProject\Sut.Silverlight.xap" />
                //   </Deployment>
                // ...
                XmlDocument xmlDocument = new XmlDocument();
                XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
                xmlNamespaceManager.AddNamespace("mstt", namespaceUri);
                xmlDocument.Load(this.testSettingsFilePath);

                XmlNode testSettingsXmlNode = xmlDocument.SelectSingleNode("//mstt:TestSettings", xmlNamespaceManager);
                Assert.IsNotNull(testSettingsXmlNode);
                XmlNode deploymentXmlNode = testSettingsXmlNode.SelectSingleNode("//mstt:Deployment", xmlNamespaceManager);
                Assert.IsNotNull(deploymentXmlNode);
                Assert.IsNotNull(deploymentXmlNode.Attributes);
                deploymentXmlNode.Attributes["enabled"].Value = "true";

                XmlElement deploymentItem = xmlDocument.CreateElement(string.Empty, "DeploymentItem", namespaceUri);
                deploymentItem.SetAttribute("filename", string.Format(@"{0}\{1}", ProjectName, silverlightXapFileName));
                deploymentXmlNode.AppendChild(deploymentItem);
                xmlDocument.Save(this.testSettingsFilePath);

                // force solution to reload
                this.dte.ExecuteCommand("File.SaveAll");
                this.dte.Solution.Close();
                this.dte.Solution.Open(this.solutionFilePath);
            }
        }

        private void SetCopyToOutputDirectory(ProjectItem projectItem)
        {
            // Set "Copy to Output Directory" property
            this.SetPropertyValue(projectItem, "CopyToOutputDirectory", CopyToOutputDirectory.CopyIfNewer);
        }

        private void SetPropertyValue(ProjectItem projectItem, string propertyName, object propertyValue)
        {
            Property property = projectItem.Properties.Item(propertyName);
            Assert.IsNotNull(property);
            property.Value = propertyValue;
        }

        /// <summary>
        /// Defines if and when a file is copied to the output directory.
        /// </summary>
        private enum CopyToOutputDirectory
        {
            /// <summary>
            /// Do not copy this file to the output directory.
            /// </summary>
            DoNotCopy = 0,

            /// <summary>
            /// Always copy this file to the output directory.
            /// </summary>
            CopyAlways = 1,

            /// <summary>
            /// Copy this file to the output directory only if it is 
            /// newer than the same file in the output directory.
            /// </summary>
            CopyIfNewer = 2,
        }

        /// <summary>
        /// Then the project should build and its tests run successfully.
        /// </summary>
        [Then(@"the project should build and its tests run successfully")]
        public void ThenTheProjectShouldBuildAndItsTestsRunSuccessfully()
        {
            Trace.WriteLine("Building solution");

            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            bool buildSucceeded = false;

            this.dte.Events.BuildEvents.OnBuildProjConfigDone += (project, projectConfig, platform, solutionConfig, success) =>
            {
                Trace.WriteLine(
                    string.Format(
                        "Project {0} Project Configuration {1} Platform {2} Solution Configuration {3} Success {4}",
                        project,
                        projectConfig,
                        platform,
                        solutionConfig,
                        success));

                buildSucceeded = success;

                autoResetEvent.Set();
            };

            this.dte.ExecuteCommand("Build.RebuildSolution");

            autoResetEvent.WaitOne();

            Trace.WriteLine("Done building solution");

            if (!buildSucceeded)
            {
                const string buildOutputPaneGuid = "{1BD8A850-02D1-11D1-BEE7-00A0C913D1F8}";

                Window vsWindow = this.dte.Windows.Item(Constants.vsWindowKindOutput);

                OutputWindowPane objBuildOutputWindowPane = null;

                OutputWindow vsOutputWindow = (OutputWindow)vsWindow.Object;

                foreach (OutputWindowPane objOutputWindowPane in vsOutputWindow.OutputWindowPanes)
                {
                    if (objOutputWindowPane.Guid.ToUpper() == buildOutputPaneGuid)
                    {
                        objBuildOutputWindowPane = objOutputWindowPane;
                    }
                }

                Assert.IsNotNull(objBuildOutputWindowPane);

                TextDocument txtOutput = objBuildOutputWindowPane.TextDocument;
                TextSelection txtSelection = txtOutput.Selection;

                txtSelection.StartOfDocument();
                txtSelection.EndOfDocument(true);

                txtSelection = txtOutput.Selection;

                Assert.IsTrue(buildSucceeded, txtSelection.Text);
            }

            if (this.visualStudioVersionNumber == "15")
            {
                // wait for tests to be discovered
                // read the tests window output
                string output = this.GetTestsOutput();
                while (!output.Contains("Discover test finished"))
                {
                    Trace.WriteLine(output);
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                    output = this.GetTestsOutput();
                }
            }

            this.RunAllTests();
        }

        private void RunAllTests()
        {
            Trace.WriteLine("Running all tests...");

            int expectedPassedTests = 2;
            string testResultsFilePath = null;

            using (TempFile testResultsFile = new TempFile())
            {

                if (this.visualStudioVersion == "2010")
                {
                    expectedPassedTests = 3;
                    string testResultsPath = Path.Combine(this.solutionDirectory.DirectoryPath, "TestResults");

                    // directory must exist for FileSystemWatcher
                    Directory.CreateDirectory(testResultsPath);

                    AutoResetEvent autoResetEvent = new AutoResetEvent(false);

                    FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(testResultsPath, "*.trx");
                    fileSystemWatcher.Created += (sender, args) =>
                    {
                        Trace.WriteLine(string.Format("File created Name: '{0}' FullPath: '{1}' ChangeType: '{2}'", args.Name, args.FullPath, args.ChangeType));
                        testResultsFilePath = args.FullPath;
                    };
                    fileSystemWatcher.Changed += (sender, args) =>
                    {
                        Trace.WriteLine(string.Format("File changed Name: '{0}' FullPath: '{1}' ChangeType: '{2}'", args.Name, args.FullPath, args.ChangeType));
                        autoResetEvent.Set();
                    };

                    fileSystemWatcher.EnableRaisingEvents = true;

                    this.dte.ExecuteCommand("Test.RunAllTestsInSolution");

                    autoResetEvent.WaitOne();
                }
                else
                {
                    if (this.isSilverlightNuGetPackage)
                    {
                        expectedPassedTests = 8;
                    }

                    // Activate "Test Explorer" window
                    const string testExplorerGuid = "{E1B7D1F8-9B3C-49B1-8F4F-BFC63A88835D}";

                    Window testExplorerWindow = null;
                    foreach (Window window in this.dte.Windows)
                    {
                        if (window.Caption == "Test Explorer")
                        {
                            testExplorerWindow = window;
                            break;
                        }
                    }

                    if (testExplorerWindow == null)
                    {
                        testExplorerWindow = this.dte.Windows.Item(testExplorerGuid);
                    }

                    testExplorerWindow.Activate();

                    this.ExecuteCommand("TestExplorer.RunAllTests");

                    // read the tests window output
                    string output = this.GetTestsOutput();
                    while (!output.Contains("Run test finished"))
                    {
                        Trace.WriteLine(output);
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                        output = this.GetTestsOutput();
                    }

                    Match testsRunMatch = Regex.Match(output, @"Run test finished: (\d+)");
                    Assert.IsTrue(testsRunMatch.Success, output);
                    Assert.IsNotNull(testsRunMatch, output);
                    Assert.IsNotNull(testsRunMatch.Groups, output);
                    Assert.AreEqual(2, testsRunMatch.Groups.Count, output);
                    Group testsRunGroup = testsRunMatch.Groups[1];
                    string testsRunString = testsRunGroup.Value;
                    Assert.AreEqual(expectedPassedTests.ToString(), testsRunString, output);
                    int testsRun = Int32.Parse(testsRunString);
                    Assert.AreEqual(expectedPassedTests, testsRun, output);

                    // results file must not exist
                    File.Delete(testResultsFile.FilePath);

                    string fileName = this.GetMsTestFilePath(this.visualStudioVersionNumber);
                    List<string> arguments = new List<string>
                    {
                        string.Format("/testcontainer:{0}", Path.Combine(this.testProjectPath, "bin", "Debug", string.Format("{0}.dll", ProjectName))),
                        string.Format("/resultsfile:{0}", testResultsFile.FilePath)
                    };

                    if (!string.IsNullOrEmpty(this.testSettingsFilePath))
                    {
                        arguments.Add(string.Format("/testsettings:{0}", this.testSettingsFilePath));
                    }

                    RunResult runResult = ProcessRunner.Run(fileName, string.Join(" ", arguments));
                    Assert.AreEqual(0, runResult.ExitCode, string.Join(Environment.NewLine, new { runResult.StandardOutput, runResult.StandardError }));

                    testResultsFilePath = testResultsFile.FilePath;
                }

                // Deserialize TestRunType object from the trx file
                // To support a new version of visual studio:
                // 1. xsd.exe "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Xml\Schemas\vstst.xsd" /c /namespace:CUITe.IntegrationTests.NuGet.VisualStudio2015
                // 2. Manually fix runtime errors "There was an error reflecting property 'Items'. ---> System.InvalidOperationException: Member 'GenericTestType.Items' hides inherited member 'BaseTestType.Items', but has different custom attributes."
                // See http://stackoverflow.com/a/10872961/90287
                // 3. Replace "[][]" with "[]" in generated class
                int testsPassedCount;
                switch (this.visualStudioVersionNumber)
                {
                    case "10":
                        testsPassedCount = this.GetNumberOfPassedTestsInVisualStudio2010(testResultsFilePath);
                        break;
                    case "11":
                        testsPassedCount = this.GetNumberOfPassedTestsInVisualStudio2012(testResultsFilePath);
                        break;
                    case "12":
                        testsPassedCount = this.GetNumberOfPassedTestsInVisualStudio2013(testResultsFilePath);
                        break;
                    case "14":
                        testsPassedCount = this.GetNumberOfPassedTestsInVisualStudio2015(testResultsFilePath);
                        break;
                    case "15":
                        testsPassedCount = this.GetNumberOfPassedTestsInVisualStudio2017(testResultsFilePath);
                        break;
                    default:
                        throw new NotSupportedException(this.visualStudioVersionNumber);
                }

                Assert.AreEqual(expectedPassedTests, testsPassedCount, File.ReadAllText(testResultsFilePath));
            }
        }

        private string GetMsTestFilePath(string visualStudioVersionNumber)
        {
            switch (visualStudioVersionNumber)
            {
                case "15":
                    string installPath = this.GetVisualStudioInstallPath(visualStudioVersionNumber);
                    return Path.Combine(installPath, "Common7", "IDE", "MsTest.exe");
                default:
                    return string.Format(@"C:\Program Files (x86)\Microsoft Visual Studio {0}.0\Common7\IDE\MSTest.exe", this.visualStudioVersionNumber);
            }
        }

        private int GetNumberOfPassedTestsInVisualStudio2010(string trxFilePath)
        {
            int testsPassedCount = 0;
            using (StreamReader fileStreamReader = new StreamReader(trxFilePath))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(VisualStudio2010.TestRunType));
                VisualStudio2010.TestRunType testRunType = (VisualStudio2010.TestRunType)xmlSer.Deserialize(fileStreamReader);
                // Navigate to UnitTestResultType object and update the sheet with test result information
                foreach (object itob1 in testRunType.Items)
                {
                    VisualStudio2010.ResultsType resultsType = itob1 as VisualStudio2010.ResultsType;
                    if (resultsType != null)
                    {
                        foreach (object itob2 in resultsType.Items)
                        {
                            VisualStudio2010.UnitTestResultType unitTestResultType = itob2 as VisualStudio2010.UnitTestResultType;
                            if (unitTestResultType != null)
                            {
                                string errorMessage = null;
                                if (unitTestResultType.Items != null)
                                {
                                    VisualStudio2010.OutputType outputType = (VisualStudio2010.OutputType)unitTestResultType.Items[0];
                                    VisualStudio2010.OutputTypeErrorInfo errorInfo = outputType.ErrorInfo;
                                    if (errorInfo != null)
                                    {
                                        errorMessage = ((XmlNode[])errorInfo.Message)[0].Value;
                                    }
                                }

                                Assert.AreEqual("Passed", unitTestResultType.outcome, errorMessage);
                                testsPassedCount++;
                            }
                        }
                    }
                }
            }

            return testsPassedCount;
        }

        private int GetNumberOfPassedTestsInVisualStudio2012(string trxFilePath)
        {
            int testsPassedCount = 0;
            using (StreamReader fileStreamReader = new StreamReader(trxFilePath))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(VisualStudio2012.TestRunType));
                VisualStudio2012.TestRunType testRunType = (VisualStudio2012.TestRunType)xmlSer.Deserialize(fileStreamReader);
                // Navigate to UnitTestResultType object and update the sheet with test result information
                foreach (object itob1 in testRunType.Items)
                {
                    VisualStudio2012.ResultsType resultsType = itob1 as VisualStudio2012.ResultsType;
                    if (resultsType != null)
                    {
                        foreach (object itob2 in resultsType.Items)
                        {
                            VisualStudio2012.UnitTestResultType unitTestResultType = itob2 as VisualStudio2012.UnitTestResultType;
                            if (unitTestResultType != null)
                            {
                                string errorMessage = null;
                                if (unitTestResultType.Items != null)
                                {
                                    VisualStudio2012.OutputType outputType = (VisualStudio2012.OutputType)unitTestResultType.Items[0];
                                    VisualStudio2012.OutputTypeErrorInfo errorInfo = outputType.ErrorInfo;
                                    if (errorInfo != null)
                                    {
                                        errorMessage = ((XmlNode[])errorInfo.Message)[0].Value;
                                    }
                                }

                                Assert.AreEqual("Passed", unitTestResultType.outcome, errorMessage);
                                testsPassedCount++;
                            }
                        }
                    }
                }
            }

            return testsPassedCount;
        }

        private int GetNumberOfPassedTestsInVisualStudio2013(string trxFilePath)
        {
            int testsPassedCount = 0;
            using (StreamReader fileStreamReader = new StreamReader(trxFilePath))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(VisualStudio2013.TestRunType));
                VisualStudio2013.TestRunType testRunType = (VisualStudio2013.TestRunType)xmlSer.Deserialize(fileStreamReader);
                // Navigate to UnitTestResultType object and update the sheet with test result information
                foreach (object itob1 in testRunType.Items)
                {
                    VisualStudio2013.ResultsType resultsType = itob1 as VisualStudio2013.ResultsType;
                    if (resultsType != null)
                    {
                        foreach (object itob2 in resultsType.Items)
                        {
                            VisualStudio2013.UnitTestResultType unitTestResultType = itob2 as VisualStudio2013.UnitTestResultType;
                            if (unitTestResultType != null)
                            {
                                string errorMessage = null;
                                if (unitTestResultType.Items != null)
                                {
                                    VisualStudio2013.OutputType outputType = (VisualStudio2013.OutputType)unitTestResultType.Items[0];
                                    VisualStudio2013.OutputTypeErrorInfo errorInfo = outputType.ErrorInfo;
                                    if (errorInfo != null)
                                    {
                                        errorMessage = ((XmlNode[])errorInfo.Message)[0].Value;
                                    }
                                }

                                Assert.AreEqual("Passed", unitTestResultType.outcome, errorMessage);
                                testsPassedCount++;
                            }
                        }
                    }
                }
            }

            return testsPassedCount;
        }

        private int GetNumberOfPassedTestsInVisualStudio2015(string trxFilePath)
        {
            int testsPassedCount = 0;
            using (StreamReader fileStreamReader = new StreamReader(trxFilePath))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(VisualStudio2015.TestRunType));
                VisualStudio2015.TestRunType testRunType = (VisualStudio2015.TestRunType)xmlSer.Deserialize(fileStreamReader);
                // Navigate to UnitTestResultType object and update the sheet with test result information
                foreach (object itob1 in testRunType.Items)
                {
                    VisualStudio2015.ResultsType resultsType = itob1 as VisualStudio2015.ResultsType;
                    if (resultsType != null)
                    {
                        foreach (object itob2 in resultsType.Items)
                        {
                            VisualStudio2015.UnitTestResultType unitTestResultType = itob2 as VisualStudio2015.UnitTestResultType;
                            if (unitTestResultType != null)
                            {
                                string errorMessage = null;
                                if (unitTestResultType.Items != null)
                                {
                                    VisualStudio2015.OutputType outputType = (VisualStudio2015.OutputType)unitTestResultType.Items[0];
                                    VisualStudio2015.OutputTypeErrorInfo errorInfo = outputType.ErrorInfo;
                                    if (errorInfo != null)
                                    {
                                        errorMessage = ((XmlNode[])errorInfo.Message)[0].Value;
                                    }
                                }

                                Assert.AreEqual("Passed", unitTestResultType.outcome, errorMessage);
                                testsPassedCount++;
                            }
                        }
                    }
                }
            }

            return testsPassedCount;
        }

        private int GetNumberOfPassedTestsInVisualStudio2017(string trxFilePath)
        {
            int testsPassedCount = 0;
            using (StreamReader fileStreamReader = new StreamReader(trxFilePath))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(VisualStudio2017.TestRunType));
                VisualStudio2017.TestRunType testRunType = (VisualStudio2017.TestRunType)xmlSer.Deserialize(fileStreamReader);
                // Navigate to UnitTestResultType object and update the sheet with test result information
                foreach (object itob1 in testRunType.Items)
                {
                    VisualStudio2017.ResultsType resultsType = itob1 as VisualStudio2017.ResultsType;
                    if (resultsType != null)
                    {
                        foreach (object itob2 in resultsType.Items)
                        {
                            VisualStudio2017.UnitTestResultType unitTestResultType = itob2 as VisualStudio2017.UnitTestResultType;
                            if (unitTestResultType != null)
                            {
                                string errorMessage = null;
                                if (unitTestResultType.Items != null)
                                {
                                    VisualStudio2017.OutputType outputType = (VisualStudio2017.OutputType)unitTestResultType.Items[0];
                                    VisualStudio2017.OutputTypeErrorInfo errorInfo = outputType.ErrorInfo;
                                    if (errorInfo != null)
                                    {
                                        errorMessage = ((XmlNode[])errorInfo.Message)[0].Value;
                                    }
                                }

                                Assert.AreEqual("Passed", unitTestResultType.outcome, errorMessage);
                                testsPassedCount++;
                            }
                        }
                    }
                }
            }

            return testsPassedCount;
        }

        private string GetTestsOutput()
        {
            Window outputToolWindow = this.dte.Windows.Item(Constants.vsWindowKindOutput);
            OutputWindow outputWindow = (OutputWindow)outputToolWindow.Object;

            OutputWindowPane outputWindowPane = outputWindow.OutputWindowPanes.Item("Tests");

            // Create a reference to the pane contents.
            // Select the Tests pane in the Output window.
            outputWindowPane.Activate();
            TextDocument outputWindowPaneTextDocument = outputWindowPane.TextDocument;

            // Retrieve the text contents of the pane.
            EditPoint2 strtPt = (EditPoint2)outputWindowPaneTextDocument.StartPoint.CreateEditPoint();
            return strtPt.GetText(outputWindowPaneTextDocument.EndPoint);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this.visualStudio != null)
            {
                this.visualStudio.Dispose();
            }

            MessageFilter.Revoke();
        }
    }
}
