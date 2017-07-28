using System;
using System.IO;
using System.Linq;
using System.Text;
using CUITe.IntegrationTests.NuGet;
using CUITe.IntegrationTests.ObjectRecorder.Screens;
using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CUITe.IntegrationTests.ObjectRecorder.Steps
{
    /// <summary>
    /// Recoding Steps
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    [Binding]
    public class RecordingSteps : IDisposable
    {
        private TempFile tempFile;
        private MainScreen mainScreen;

        /// <summary>
        /// Given an HTML file with the contents.
        /// </summary>
        /// <param name="multilineText">The multiline text.</param>
        [Given(@"an html file with the contents")]
        public void GivenAnHtmlFileWithTheContents(string multilineText)
        {
            tempFile = new TempFile();
            File.WriteAllText(tempFile.FilePath, multilineText);
        }

        /// <summary>
        /// Given the HTML file is launched with the recorder.
        /// </summary>
        [Given(@"the html file is launched with the recorder")]
        public void GivenTheHtmlFileIsLaunchedWithTheRecorder()
        {
            string applicationFilePath = Path.Combine(Directory.GetCurrentDirectory(), "CUITe_ObjectRecorder.exe");

            mainScreen = Screen.Launch<MainScreen>(applicationFilePath);
            mainScreen.AddressTextBox.Text = tempFile.FilePath;
            mainScreen.GoButton.Click();
        }

        /// <summary>
        /// When the recording is started.
        /// </summary>
        [When(@"recording is started")]
        public void WhenRecordingIsStarted()
        {
            mainScreen.RecordButton.Click();
        }

        /// <summary>
        /// When the textbox is clicked.
        /// </summary>
        [When(@"the textbox is clicked")]
        public void WhenTheTextboxIsClicked()
        {
            mainScreen.TestTextBox.Click();
        }

        /// <summary>
        /// Then the generated file should contain.
        /// </summary>
        /// <param name="multilineText">The multiline text.</param>
        [Then(@"the generated file should contain")]
        public void ThenTheGeneratedFileShouldContain(string multilineText)
        {
            mainScreen.GenerateCodeButton.Click();

            // find notepad
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("notepad");
            Notepad notepad = Screen.FromProcess<Notepad>(processes.First(), "CUITe_ObjectRecorder_temp.txt - Notepad");

            string actual = notepad.TextBox.Text;

            multilineText += "\r\n";

            if (actual == multilineText)
            {
                // they are equal
                return;
            }

            // find the difference
            char[] actualCode = actual.ToCharArray();
            char[] expectedCode = multilineText.ToCharArray();

            int expectedCodeDiffIndex = 0;
            int actualCodeDiffIndex = 0;

            bool foundDiff = false;

            for (int i = 0; i < expectedCode.Length; i++)
            {
                if (i >= actualCode.Length)
                {
                    expectedCodeDiffIndex = i;
                    actualCodeDiffIndex = actualCode.Length - 1;
                    foundDiff = true;
                    break;
                }

                char c = expectedCode[i];

                if (c != actualCode[i])
                {
                    expectedCodeDiffIndex = i;
                    actualCodeDiffIndex = i;
                    foundDiff = true;
                    break;
                }
            }

            if (!foundDiff && (expectedCode.Length < actualCode.Length))
            {
                expectedCodeDiffIndex = expectedCode.Length - 1;
                actualCodeDiffIndex = expectedCodeDiffIndex;
            }

            string[] message =
            {
                string.Format("Found difference on position {0}.", expectedCodeDiffIndex),
                string.Format("Expected string length: {0}", multilineText.Length),
                string.Format("Actual string length: {0}", actual.Length),
                string.Format("Character at position {0} in expected string: '{1}' (ASCII: {2}).", expectedCodeDiffIndex, expectedCode[expectedCodeDiffIndex], Encoding.ASCII.GetBytes(new[] { expectedCode[expectedCodeDiffIndex] }).First()),
                string.Format("Character at position {0} in actual string: '{1}' (ASCII: {2}).", actualCodeDiffIndex, actualCode[actualCodeDiffIndex], Encoding.ASCII.GetBytes(new[] { actualCode[actualCodeDiffIndex] }).First())
            };

            Assert.AreEqual(
                multilineText,
                notepad.TextBox.Text,
                string.Join(Environment.NewLine, message));
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            tempFile.Dispose();
        }
    }
}
