using CUITe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample_CUITeTestProject
{
    [TestClass]
    public class DataManagerTests
    {
        [TestMethod]
        public void GetDataRow_UsingEmbeddedResourceThatDoesNotExist_ThrowsResourceNotFoundException()
        {
            try
            {
                DataManager.GetDataRow(typeof(DataManagerTests), "EmbeddedResourceThatDoesNotExist", "DoesNotExist");

                Assert.Fail("ResourceNotFoundException not thrown");
            }
            catch (ResourceNotFoundException)
            {
                //expected; success
            }
        }
    }
}
