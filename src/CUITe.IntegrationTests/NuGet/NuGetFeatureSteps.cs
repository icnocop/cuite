namespace CUITe.IntegrationTests.NuGet
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Xml;
    using EnvDTE;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Win32;
    using TechTalk.SpecFlow;
    using VSLangProj;

    [Binding]
    public class NuGetFeatureSteps : IDisposable
    {
        private string visualStudioProgramId;

        private string visualStudioProjectTemplateCachePath;

        private string visualStudioItemTemplateCachePath;

        private TempDirectory solutionDirectory;

        private DTE dte;

        private VisualStudioAutomation visualStudio;

        private Solution solution;

        private Project testProject;

        private string testProjectPath;

        private string visualStudioVersionNumber;

        private string codedUiTestTemplatePath;

        private string visualStudioVersion;

        private string testProjectTemplatePath;

        public NuGetFeatureSteps()
        {
            MessageFilter.Register();
        }

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
                { "2015", "13" }
            };

            if (!visualStudioVersionMap.ContainsKey(visualStudioVersion))
            {
                throw new NotSupportedException(string.Format("Visual Studio version {0} not support", visualStudioVersion));
            }

            this.visualStudioVersionNumber = visualStudioVersionMap[visualStudioVersion];

            Trace.WriteLine(string.Format("Visual Studio Version Number: {0}", this.visualStudioVersionNumber));

            this.visualStudioProgramId = string.Format("VisualStudio.DTE.{0}.0", this.visualStudioVersionNumber);

            Trace.WriteLine(string.Format("Visual Studio Program Id: {0}", this.visualStudioProgramId));

            this.visualStudioProjectTemplateCachePath = this.GetVisualStudioProjectTemplateCachePath(this.visualStudioVersionNumber);

            Trace.WriteLine(string.Format("Visual Studio Project Template Cache Path: {0}", this.visualStudioProjectTemplateCachePath));

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
                case "13":
                    this.testProjectTemplatePath = Path.Combine(this.visualStudioProjectTemplateCachePath, @"CSharp\Test\1033\TestProject");
                    this.codedUiTestTemplatePath = Path.Combine(this.visualStudioItemTemplateCachePath, @"CSharp\Test\1033\CodedUITest");
                    break;
                default:
                    throw new NotSupportedException(string.Format("Visual Studio version {0} not support", this.visualStudioVersionNumber));
            }

            Trace.WriteLine(string.Format("Visual Studio Coded UI Test Template Path: {0}", this.codedUiTestTemplatePath));
        }

        [When(@"a new Coded UI test project is created with platform (.*)")]
        public void WhenANewCodedUITestProjectIsCreatedWithPlatform(string platform)
        {
            Type type = Type.GetTypeFromProgID(this.visualStudioProgramId);
            Object obj = Activator.CreateInstance(type, true);
            this.dte = (DTE)obj;

            this.dte.MainWindow.Visible = true;
            this.dte.UserControl = true;

            // create a new solution
            this.solutionDirectory = new TempDirectory();
            // this.solutionDirectory.DeleteDirectoryOnDispose = false;

            this.dte.Solution.Create(this.solutionDirectory.DirectoryPath, "NewSolution");
            this.visualStudio = new VisualStudioAutomation(this.dte);
            // this.visualStudio.QuitVisualStudioOnDispose = false;
            this.solution = this.dte.Solution;

            // create a test project
            string projectName = "TestProject";
            this.testProjectPath = Path.Combine(this.solutionDirectory.DirectoryPath, projectName);

            using (TempDirectory projectTemplateDirectory = new TempDirectory())
            {
                this.ConfigureTemplate(this.testProjectTemplatePath, "TestProject.vstemplate", projectTemplateDirectory.DirectoryPath);

                string testProjectTemplateFilePath = Path.Combine(projectTemplateDirectory.DirectoryPath, "TestProject.vstemplate");

                Trace.WriteLine(string.Format("Creating test project '{0}' in '{1}' using template '{2}'...", projectName, this.testProjectPath, testProjectTemplateFilePath));

                this.solution.AddFromTemplate(string.Format("{0}|$targetframeworkversion$={1}", testProjectTemplateFilePath, platform), this.testProjectPath, projectName);

                foreach (Project project in this.solution.Projects)
                {
                    if (project.Name != projectName)
                    {
                        continue;
                    }

                    this.testProject = project;

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

                this.testProject.ProjectItems.AddFromTemplate(templateFile, name);
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
            };

            registryKeys.AddRange(new[]
            {
                "Microsoft",
                "VisualStudio",
                string.Format("{0}.0", visualStudioVersion),
                "VSTemplate",
                templateType
            });

            string registryKeyName = string.Join(@"\", registryKeys);

            return Registry.GetValue(registryKeyName, "CacheFolder", null).ToString();
        }

        private string GetVisualStudioProjectTemplateCachePath(string visualStudioVersion)
        {
            return this.GetVisualStudioTemplateCachePath(visualStudioVersion, "Project");
        }

        private string GetVisualStudioItemTemplateCachePath(string visualStudioVersion)
        {
            return this.GetVisualStudioTemplateCachePath(visualStudioVersion, "Item");
        }

        [When(@"the CUITe nuget package ""(.*)"" is added to the project")]
        public void WhenTheCUITeNugetPackageIsAddedToTheProject(string nugetPackageId)
        {
            this.InstallNuGetPackage(this.testProject, nugetPackageId);
        }

        private void InstallNuGetPackage(Project project, string package)
        {
            string[] nugetCommandArguments =
            {
                string.Format("Install-Package {0}", package),
                string.Format("-Source \"{0}\"", Directory.GetCurrentDirectory()),
                "-ProjectName TestProject",
                "-IncludePrerelease"
            };

            string nugetCommand = string.Join(" ", nugetCommandArguments);

            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            this.dte.Events.CommandEvents.BeforeExecute += (string guid, int id, object @in, object @out, ref bool cancelDefault) =>
            {
                Trace.WriteLine(string.Format("Before Executing Command Guid: {0} In: {1} Out: {2}", this.ConvertGuidAndId(guid, id), @in, @out));
            };

            this.dte.Events.CommandEvents.AfterExecute += (guid, id, @in, @out) =>
            {
                Trace.WriteLine(string.Format("After Executing Command Guid: {0} In: {1} Out: {2}", this.ConvertGuidAndId(guid, id), @in, @out));

                if ((@in != null) && (@in.ToString().Trim() == nugetCommand))
                {
                    autoResetEvent.Set();
                }
            };
            
            this.dte.ExecuteCommand("View.PackageManagerConsole");

            // Wait for 5 secs for the powershell host to initialize before executing the next command
            // TODO: implement a better approach because this may fail randomly
            Trace.WriteLine("Waiting 5 seconds");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            Trace.WriteLine("Finished waiting 5 seconds");

            this.dte.ExecuteCommand("View.PackageManagerConsole", nugetCommand);
            autoResetEvent.WaitOne();

            Trace.WriteLine(string.Format("Finished executing command {0}", nugetCommand));

            VSProject vsproject = project.Object as VSProject;

            Assert.IsNotNull(vsproject);

            while (true)
            {
                if (vsproject.References.Cast<Reference>()
                    .Where(reference => reference.SourceProject == null)
                    .Any(reference => reference.Name == "CUITe"))
                {
                    Trace.WriteLine("Found project reference to CUITe");
                    return;
                }

                Trace.WriteLine("Could not find project reference to CUITe");
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

        [When(@"test methods are added to the project which use CUITe to test the sample application\(s\)")]
        public void WhenTestMethodsAreAddedToTheProjectWhichUseCUITeToTestTheSampleApplicationS()
        {
            // HTML
            Assembly assembly = Assembly.GetExecutingAssembly();

            string htmlTestsCsFilePath = Path.Combine(this.testProjectPath, "HtmlTests.cs");
            AssemblyResourceLoader.ExtractEmbeddedResource(assembly, "CUITe.IntegrationTests.NuGet.HtmlTests.cs", htmlTestsCsFilePath);
            this.testProject.ProjectItems.AddFromFile(htmlTestsCsFilePath);

            string tempWebPageCsFilePath = Path.Combine(this.testProjectPath, "TempWebPage.cs");
            AssemblyResourceLoader.ExtractEmbeddedResource(assembly, "CUITe.IntegrationTests.NuGet.TempWebPage.cs", tempWebPageCsFilePath);
            this.testProject.ProjectItems.AddFromFile(tempWebPageCsFilePath);

            // TODO: Silverlight
        }
        
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

            this.RunAllTests();
        }

        private void RunAllTests()
        {
            Trace.WriteLine("Running all tets...");

            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            if (this.visualStudioVersion == "2010")
            {
                this.dte.ExecuteCommand("Test.RunAllTestsInSolution");
            }
            else
            {
                this.dte.ExecuteCommand("TestExplorer.ShowTestExplorer");

                System.Threading.Thread.Sleep(TimeSpan.FromMinutes(1));

                this.dte.ExecuteCommand("TestExplorer.RunAllTests");
            }

            autoResetEvent.WaitOne(30000);

            Trace.WriteLine("Test execution finished.");

            ScenarioContext.Current.Pending();
        }

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
