using System.Collections.Generic;
using CUITe.Caches;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.Cache
{
    [CodedUITest]
    public class PropertyNamesCacheTest
    {
        private PropertyNamesCache propertyNamesCache;

        [TestInitialize]
        public void TestInitialize()
        {
            propertyNamesCache = new PropertyNamesCache();
        }

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
            var actual = new List<string>(propertyNamesCache.GetPropertyNamesFor<A>());

            // Assert
            CollectionAssert.IsSubsetOf(expected, actual);
        }

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
            var actual = new List<string>(propertyNamesCache.GetPropertyNamesFor<B>());

            // Assert
            CollectionAssert.IsSubsetOf(expected, actual);
        }

        [TestMethod]
        public void GetPropertyNamesForC()
        {
            // Arrange
            var expected = new[]
            {
                "PropertyOnC"
            };

            // Act
            var actual = new List<string>(propertyNamesCache.GetPropertyNamesFor<C>());

            // Assert
            CollectionAssert.IsSubsetOf(expected, actual);
        }
        
        #region Helper classes

        class A : B
        {
            public class PropertyNames
            {
                public static readonly string PropertyOnA = "PropertyOnA";
            }
        }

        class B : C
        {
            public class PropertyNames
            {
                public static readonly string PropertyOnB = "PropertyOnB";
            }
        }

        class C : UITestControl
        {
            public class PropertyNames
            {
                public static readonly string PropertyOnC = "PropertyOnC";
            }
        }

        #endregion
    }
}