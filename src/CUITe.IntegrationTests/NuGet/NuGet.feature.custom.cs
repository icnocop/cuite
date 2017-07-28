using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITe.IntegrationTests.NuGet
{
    /// <summary>
    /// NuGet Feature
    /// </summary>
    [DeploymentItem("CUITe.Silverlight.VS2010.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.Silverlight.VS2012.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.Silverlight.VS2013.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.Silverlight.VS2015.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.VS2010.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.VS2012.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.VS2013.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.VS2015.2.0.0-beta.nupkg")]
    [DeploymentItem("CUITe.VS2017.2.0.0-beta.nupkg")]
    public partial class NuGetFeature
    {
        /// <summary>
        /// Test execution context.
        /// </summary>
        private TestContext testContext;

        /// <summary>
        /// Gets or sets test execution context.
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return this.testContext;
            }

            set
            {
                this.testContext = value;
                CustomFeatureContext.TestContext = value;
            }
        }
    }
}
