using System.Collections;
using CUITe.DataSources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.DataSources
{
    /// <summary>
    /// XML Data Source Test
    /// </summary>
    [TestClass]
    public class XmlDataSourceTest
    {
        /// <summary>
        /// Invalid data source.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(XmlDataSourceNotFoundException))]
        public void InvalidDataSource()
        {
            // Act
            XmlDataSource.GetDataBlock(typeof(XmlDataSourceTest), "InvalidFileName.xml", "indifferent");
        }

        /// <summary>
        /// Invalid identifier.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DataBlockIdNotFoundException))]
        public void InvalidId()
        {
            // Act
            XmlDataSource.GetDataBlock(typeof(XmlDataSourceTest), "XmlDataSource.xml", "invalidid");
        }

        /// <summary>
        /// Non overridden data.
        /// </summary>
        [TestMethod]
        public void NonOverriddenData()
        {
            // Act
            Hashtable data = XmlDataSource.GetDataBlock(typeof(XmlDataSourceTest), "XmlDataSource.xml", "motorcycle");

            // Assert
            Assert.AreEqual("2", data["numberofwheels"]);
        }

        /// <summary>
        /// Overridden data.
        /// </summary>
        [TestMethod]
        public void OverriddenData()
        {
            // Act
            Hashtable data = XmlDataSource.GetDataBlock(typeof(XmlDataSourceTest), "XmlDataSource.xml", "motorcyclewithsidecar");

            // Assert
            Assert.AreEqual("3", data["numberofwheels"]);
        }

        /// <summary>
        /// First generation data.
        /// </summary>
        [TestMethod]
        public void FirstGenerationData()
        {
            // Act
            Hashtable data = XmlDataSource.GetDataBlock(typeof(XmlDataSourceTest), "XmlDataSource.xml", "name");

            // Assert
            AssertName(data);
        }

        /// <summary>
        /// Second generation data.
        /// </summary>
        [TestMethod]
        public void SecondGenerationData()
        {
            // Act
            Hashtable data = XmlDataSource.GetDataBlock(typeof(XmlDataSourceTest), "XmlDataSource.xml", "dateofbirth");

            // Assert
            AssertDateOfBirth(data);
        }

        /// <summary>
        /// Third generation data.
        /// </summary>
        [TestMethod]
        public void ThirdGenerationData()
        {
            // Act
            Hashtable data = XmlDataSource.GetDataBlock(typeof(XmlDataSourceTest), "XmlDataSource.xml", "currentaddress");

            // Assert
            AssertCurrentAddress(data);
        }

        private static void AssertName(Hashtable data)
        {
            Assert.AreEqual("Suresh", data["firstname"]);
            Assert.AreEqual("Balasubramanian", data["lastname"]);
        }

        private static void AssertDateOfBirth(Hashtable data)
        {
            AssertName(data);

            Assert.AreEqual("04/19/1973", data["date"]);
            Assert.AreEqual("38", data["age"]);
        }

        private void AssertCurrentAddress(Hashtable data)
        {
            AssertName(data);
            AssertDateOfBirth(data);

            Assert.AreEqual("Kondapur, Hyderabad", data["address"]);
            Assert.AreEqual("Indian", data["nationality"]);
        }
    }
}