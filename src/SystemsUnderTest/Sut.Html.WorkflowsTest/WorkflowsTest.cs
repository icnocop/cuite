using System.IO;
using CUITe.PageObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Html.WorkflowsTest.PageObjects;
using Sut.Html.WorkflowsTest.Workflows;
using TestHelpers;

namespace Sut.Html.WorkflowsTest
{
    /// <summary>
    /// Summary description for WorkflowsTest
    /// </summary>
    [CodedUITest]
    public class WorkflowsTest
    {
        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Steps the through wizard.
        /// </summary>
        [TestMethod]
        public void StepThroughWizard()
        {
            using (var finishedWebPage = new TempWebPage(Finished))
            using (var addressWebPage = new TempWebPage(string.Format(Address, Path.GetFileName(finishedWebPage.FilePath))))
            using (var nameWebPage = new TempWebPage(string.Format(Name, Path.GetFileName(addressWebPage.FilePath))))
            {
                // Arrange
                var namePage = Page.Launch<NamePage>(nameWebPage.FilePath);
                var workflow = new WizardWorkflow(namePage);

                // Act
                FinishedPage finishedPage = workflow.StepThrough();

                // Assert
                Assert.IsTrue(finishedPage.CongratulationsExists);
            }
        }

        #region Helper properties

        private static string Name
        {
            get
            {
                return
                    @"<html>
                        <body>
                          <div>
                            <p>First name: <input type=""text"" id=""firstname"" /></p>
                            <p>Surname: <input type=""text"" id=""surname"" /></p>
                          </div>
                          <button id=""next"" onclick=""location.href='{0}';"">Next</button>
                        </body>
                      </html>";
            }
        }

        private static string Address
        {
            get
            {
                return
                    @"<html>
                        <body>
                          <div>
                            <p>Address: <input type=""text"" id=""address"" /></p>
                            <p>City: <input type=""text"" id=""city"" /></p>
                            <p>Postal Code: <input type=""text"" id=""postalcode"" /></p>
                            <p>State: <input type=""text"" id=""state"" /></p>
                          </div>
                          <button id=""next"" onclick=""location.href='{0}';"">Next</button>
                        </body>
                      </html>";
            }
        }

        private static string Finished
        {
            get
            {
                return
                    @"<html>
                        <body>
                          <p id=""congratulations"">Congratulations!!!</p>
                          <p>You made it through this worthless wizard.</p>
                        </body>
                      </html>";
            }
        }

        #endregion
    }
}