namespace CUITe.IntegrationTests.NuGet
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;
    using System.Xml;
    using System.Xml.Serialization;
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Win32;
    using TechTalk.SpecFlow;
    using TestHelpers;
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

        private const string ProjectName = "TestProject";

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
                { "2015", "14" }
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
                case "14":
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
            using (new TemporaryEnvironmentVariable("VisualStudioVersion", string.Format("{0}.0", this.visualStudioVersionNumber)))
            {
                Type type = Type.GetTypeFromProgID(this.visualStudioProgramId);
                Object obj = Activator.CreateInstance(type, true);

                this.dte = (DTE)obj;
            }

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

            VSProject vsProject = this.testProject.Object as VSProject;
            if (vsProject == null)
            {
                throw new Exception("Failed to convert Project to VSProject.");
            }

            foreach (Reference projectReference in vsProject.References)
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

            string registryValueName = "CacheFolder";
            object cacheFolder = Registry.GetValue(registryKeyName, registryValueName, null);
            if (cacheFolder == null)
            {
                throw new Exception(string.Format("Failed to get registry value '{0}' from key '{1}'", registryValueName, registryKeyName));
            }

            return cacheFolder.ToString();
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
            this.InstallNuGetPackage(this.testProject, nugetPackageId, ProjectName);
        }

        private void InstallNuGetPackage(Project project, string package, string projectName)
        {
            // activate Package Manager Console window
            const string packageManagerConsoleGuid = "{0AD07096-BBA9-4900-A651-0598D26F6D24}";

            Window packageManagerConsoleWindow = this.dte.Windows.Item(packageManagerConsoleGuid);
            packageManagerConsoleWindow.Activate();
            
            string commandName = "View.PackageManagerConsole";

            // Execute Install-Command in Package Manager Console
            string[] nugetCommandArguments =
            {
                string.Format("Install-Package {0}", package),
                string.Format("-Source \"{0}\"", Directory.GetCurrentDirectory()),
                string.Format("-ProjectName {0}", projectName),
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

            this.ExecuteCommand(commandName, nugetCommand);

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
                    // Activate "Test Explorer" window
                    const string testExplorerGuid = "{E1B7D1F8-9B3C-49B1-8F4F-BFC63A88835D}";

                    Window testExplorerWindow = this.dte.Windows.Item(testExplorerGuid);
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
                    Assert.AreEqual(expectedPassedTests, testsRunMatch.Groups.Count, output);
                    Group testsRunGroup = testsRunMatch.Groups[1];
                    string testsRunString = testsRunGroup.Value;
                    Assert.AreEqual(expectedPassedTests.ToString(), testsRunString, output);
                    int testsRun = Int32.Parse(testsRunString);
                    Assert.AreEqual(expectedPassedTests, testsRun, output);

                    // results file must not exist
                    File.Delete(testResultsFile.FilePath);

                    string fileName = string.Format(@"C:\Program Files (x86)\Microsoft Visual Studio {0}.0\Common7\IDE\MSTest.exe", this.visualStudioVersionNumber);
                    string[] arguments =
                    {
                        string.Format("/testcontainer:{0}", Path.Combine(this.testProjectPath, "bin", "Debug", string.Format("{0}.dll", ProjectName))),
                        string.Format("/resultsfile:{0}", testResultsFile.FilePath)
                    };

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
                    default:
                        throw new NotSupportedException(this.visualStudioVersionNumber);
                }

                Assert.AreEqual(expectedPassedTests, testsPassedCount, File.ReadAllText(testResultsFilePath));
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
