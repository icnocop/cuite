using System;
using System.Collections.Generic;
using System.Linq;
using CUITe.Controls;
using CUITe.Controls.TelerikControls;
using CUITe.SearchConfigurations;
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
            foreach (Type controlType in ControlTypes)
            {
                // Arrange
                By searchConfiguration = GetSearchPropertiesFor(controlType);

                // Act (this code throws exception if the control cannot be created)
                ControlBaseFactory.Create(controlType, searchConfiguration);
            }
        }

        [TestMethod]
        public void CreateUsingSourceControlAndSearchProperties()
        {
            foreach (Type controlType in ControlTypes)
            {
                // Arrange
                var sourceControl = GetSourceControlFor(controlType);
                By searchConfiguration = GetSearchPropertiesFor(controlType);
                
                // Act (this code throws exception if the control cannot be created)
                ControlBaseFactory.Create(controlType, sourceControl, searchConfiguration);
            }
        }

        #region Helper properties and methods

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

        private static UITestControl GetSourceControlFor(Type controlType)
        {
            while (!controlType.IsGenericType)
            {
                controlType = controlType.BaseType;
            }

            Type sourceControlType = controlType.GetGenericArguments().First();
            return (UITestControl)Activator.CreateInstance(sourceControlType);
        }

        /// <summary>
        /// Gets the search properties for specified UI test control. Some controls needs special
        /// search properties formatting, and this method provides for that.
        /// </summary>
        private static By GetSearchPropertiesFor(Type controlType)
        {
            if (controlType == typeof(ComboBox))
            {
                return By.Id("SomeId");
            }

            return null;
        }

        #endregion
    }
}