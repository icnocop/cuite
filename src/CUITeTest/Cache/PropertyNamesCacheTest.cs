using System.Linq;
using CUITe.Caches;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.Cache
{
    /// <summary>
    /// Property names cache test
    /// </summary>
    [CodedUITest]
    public class PropertyNamesCacheTest
    {
        private PropertyNamesCache propertyNamesCache;

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            propertyNamesCache = new PropertyNamesCache();
        }

        /// <summary>
        /// Gets the property names for a.
        /// </summary>
        [TestMethod]
        public void GetPropertyNamesForA()
        {
            // Arrange
            var expected = new[]
            {
                "PropertyOnA",
                "PropertyOnB",
                "PropertyOnC"
            };

            // Act
            string[] actual = propertyNamesCache.GetPropertyNamesFor<A>().ToArray();

            // Assert
            CollectionAssert.IsSubsetOf(expected, actual);
        }

        /// <summary>
        /// Gets the property names for b.
        /// </summary>
        [TestMethod]
        public void GetPropertyNamesForB()
        {
            // Arrange
            var expected = new[]
            {
                "PropertyOnB",
                "PropertyOnC"
            };

            // Act
            string[] actual = propertyNamesCache.GetPropertyNamesFor<B>().ToArray();

            // Assert
            CollectionAssert.IsSubsetOf(expected, actual);
        }

        /// <summary>
        /// Gets the property names for c.
        /// </summary>
        [TestMethod]
        public void GetPropertyNamesForC()
        {
            // Arrange
            var expected = new[]
            {
                "PropertyOnC"
            };

            // Act
            string[] actual = propertyNamesCache.GetPropertyNamesFor<C>().ToArray();

            // Assert
            CollectionAssert.IsSubsetOf(expected, actual);
        }
        
        #region Helper classes

        class A : B
        {
            public new class PropertyNames
            {
                public static readonly string PropertyOnA = "PropertyOnA";
            }
        }

        class B : C
        {
            public new class PropertyNames
            {
                public static readonly string PropertyOnB = "PropertyOnB";
            }
        }

        class C : UITestControl
        {
            public new class PropertyNames
            {
                public static readonly string PropertyOnC = "PropertyOnC";
            }
        }

        #endregion
    }
}