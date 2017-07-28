using System;
using System.Collections.Generic;
using System.Linq;
using CUITe.Controls;
using CUITe.Controls.HtmlControls.Telerik;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.Controls
{
    /// <summary>
    /// Constrol Base Factory Test
    /// </summary>
    [CodedUITest]
    public class ControlBaseFactoryTest
    {
        /// <summary>
        /// Creates the using search properties.
        /// </summary>
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

        /// <summary>
        /// Creates the using source control and search properties.
        /// </summary>
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

        /// <summary>
        /// Creates from source control.
        /// </summary>
        [TestMethod]
        public void CreateFromSourceControl()
        {
            foreach (Type sourceControlType in SourceControlTypes)
            {
                // Arrange
                var sourceControl = (UITestControl)Activator.CreateInstance(sourceControlType);
                
                // Act (this code throws exception if the control cannot be created)
                ControlBaseFactory.Create(sourceControl);
            }
        }

        /// <summary>
        /// Creates the win controls using parameterless constructor.
        /// </summary>
        [TestMethod]
        public void CreateWinControlsUsingParameterlessConstructor()
        {
            // Arrange
            foreach (Type controlType in ControlTypes.Where(x => typeof(WinControl).IsAssignableFrom(x)))
            {
                // Act (this code throws exception if the control cannot be created)
                ControlBaseFactory.Create(controlType);
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

        private static IEnumerable<Type> SourceControlTypes
        {
            get
            {
                return typeof(UITestControl).Assembly.GetTypes()
                    .Where(type => typeof(UITestControl).IsAssignableFrom(type))
                    .Where(type => type.IsPublic)
                    .Where(type => !type.IsAbstract)
                    .Where(type => !type.IsGenericType)
                    .Where(type => !typeof(ApplicationUnderTest).IsAssignableFrom(type))
                    .Except(new[] { typeof(UITestControl), typeof(HtmlControl), typeof(WinControl), typeof(WpfControl) });
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
        /// Gets the search configuration for specified UI test control. Some controls needs special
        /// search configuration, and this method provides for that.
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