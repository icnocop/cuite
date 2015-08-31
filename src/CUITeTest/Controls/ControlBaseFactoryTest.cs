using System;
using System.Collections.Generic;
using System.Linq;
using CUITe.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.Controls
{
    [CodedUITest]
    public class ControlBaseFactoryTest
    {
        [TestMethod]
        public void CreateUsingSearchProperties()
        {
            // Arrange
            string searchProperties = "Name=SomeName";

            // Act
            foreach (Type controlType in ControlTypes)
            {
                // This code throws exception if the control cannot be created
                ControlBaseFactory.Create(controlType, searchProperties);
            }
        }

        [TestMethod]
        public void CreateUsingSourceControlAndSearchProperties()
        {
            // Arrange
            UITestControl sourceControl = new UITestControl();
            string searchProperties = "Name=SomeName";

            // Act
            foreach (Type controlType in ControlTypes)
            {
                // This code throws exception if the control cannot be created
                ControlBaseFactory.Create(controlType, sourceControl, searchProperties);
            }
        }

        private static IEnumerable<Type> ControlTypes
        {
            get
            {
                return typeof(ControlBaseFactory).Assembly.GetTypes()
                    .Where(type => typeof(ControlBase).IsAssignableFrom(type))
                    .Where(type => type.IsPublic)
                    .Where(type => !type.IsAbstract)
                    .Where(type => !type.IsGenericType);
            }
        }
    }
}