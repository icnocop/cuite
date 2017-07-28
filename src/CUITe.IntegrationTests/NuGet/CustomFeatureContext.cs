using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITe.IntegrationTests.NuGet
{
    /// <summary>
    /// Custom Feature Context
    /// </summary>
    public class CustomFeatureContext
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>
        /// The test context.
        /// </value>
        public static TestContext TestContext { get; set; }
    }
}