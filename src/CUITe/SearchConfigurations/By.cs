using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class providing mechanisms by how particular instances of <see cref="UITestControl"/> are
    /// found in the UI.
    /// </summary>
    public sealed class By
    {
        private readonly List<ISearchConfigurator> configurators;

        /// <summary>
        /// Initializes a new instance of the <see cref="By"/> class.
        /// </summary>
        internal By()
        {
            configurators = new List<ISearchConfigurator>();
        }

        #region Automation Id

        /// <summary>
        /// Adds a mechanism to find controls by specified automation id.
        /// </summary>
        /// <param name="automationId">The automation id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By AutomationId(string automationId)
        {
            var by = new By();
            by.configurators.Add(new AutomationIdConfigurator(automationId, PropertyExpressionOperator.EqualTo));
            return by;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the automation id.
        /// </summary>
        /// <param name="automationIdPart">The part of the automation id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By AutomationIdContains(string automationIdPart)
        {
            var by = new By();
            by.configurators.Add(new AutomationIdConfigurator(automationIdPart, PropertyExpressionOperator.Contains));
            return by;
        }

        #endregion

        #region Class

        /// <summary>
        /// Adds a mechanism to find controls by specified class.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Class(string @class)
        {
            return new By().AndClass(@class);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the class.
        /// </summary>
        /// <param name="classPart">The part of the class.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ClassContains(string classPart)
        {
            return new By().AndClassContains(classPart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified class.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndClass(string @class)
        {
            configurators.Add(new ClassConfigurator(@class, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the class.
        /// </summary>
        /// <param name="classPart">The part of the class.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndClassContains(string classPart)
        {
            configurators.Add(new ClassConfigurator(classPart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        #region Class Name

        /// <summary>
        /// Adds a mechanism to find controls by the specified class name.
        /// </summary>
        /// <param name="className">The class name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ClassName(string className)
        {
            return new By().AndClassName(className);
        }

        /// <summary>
        /// Adds a mechanism to find controls by the specified part of the class name.
        /// </summary>
        /// <param name="classNamePart">The part of the class name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ClassNameContains(string classNamePart)
        {
            return new By().AndClassNameContains(classNamePart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by the specified class name.
        /// </summary>
        /// <param name="className">The class name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndClassName(string className)
        {
            configurators.Add(new ClassNameConfigurator(className, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by the specified part of the class name.
        /// </summary>
        /// <param name="classNamePart">The part of the class name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndClassNameContains(string classNamePart)
        {
            configurators.Add(new ClassNameConfigurator(classNamePart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        #region Control Id

        /// <summary>
        /// Adds a mechanism to find controls by the specified control id.
        /// </summary>
        /// <param name="controlId">The control id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ControlId(string controlId)
        {
            return new By().AndControlId(controlId);
        }

        /// <summary>
        /// Adds a mechanism to find controls by the specified part of the control id.
        /// </summary>
        /// <param name="controlIdPart">The part of the control id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ControlIdContains(string controlIdPart)
        {
            return new By().AndControlIdContains(controlIdPart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by the specified control id.
        /// </summary>
        /// <param name="controlId">The control id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndControlId(string controlId)
        {
            configurators.Add(new ControlIdConfigurator(controlId, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by the specified part of the control id.
        /// </summary>
        /// <param name="controlIdPart">The part of the control id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndControlIdContains(string controlIdPart)
        {
            configurators.Add(new ControlIdConfigurator(controlIdPart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        #region Control Name

        /// <summary>
        /// Adds a mechanism to find controls by specified control name.
        /// </summary>
        /// <param name="controlName">The control name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ControlName(string controlName)
        {
            return new By().AndControlName(controlName);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the control name.
        /// </summary>
        /// <param name="controlNamePart">The part of the control name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ControlNameContains(string controlNamePart)
        {
            return new By().AndControlNameContains(controlNamePart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified control name.
        /// </summary>
        /// <param name="controlName">The control name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndControlName(string controlName)
        {
            configurators.Add(new ControlNameConfigurator(controlName, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the control name.
        /// </summary>
        /// <param name="controlNamePart">The part of the control name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndControlNameContains(string controlNamePart)
        {
            configurators.Add(new ControlNameConfigurator(controlNamePart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        #region Control Type

        /// <summary>
        /// Adds a mechanism to find controls by specified control type.
        /// </summary>
        /// <param name="controlType">The control type.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ControlType(string controlType)
        {
            return new By().AndControlType(controlType);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the control type.
        /// </summary>
        /// <param name="controlTypePart">The part of the control type.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ControlTypeContains(string controlTypePart)
        {
            return new By().AndControlTypeContains(controlTypePart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified control type.
        /// </summary>
        /// <param name="controlType">The control type.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndControlType(string controlType)
        {
            configurators.Add(new ControlTypeConfigurator(controlType, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the control type.
        /// </summary>
        /// <param name="controlTypePart">The part of the control type.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndControlTypeContains(string controlTypePart)
        {
            configurators.Add(new ControlTypeConfigurator(controlTypePart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion
        #region Id

        /// <summary>
        /// Adds a mechanism to find controls by specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Id(string id)
        {
            return new By().AndId(id);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the id.
        /// </summary>
        /// <param name="idPart">The part of the id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By IdContains(string idPart)
        {
            return new By().AndIdContains(idPart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndId(string id)
        {
            configurators.Add(new IdConfigurator(id, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the id.
        /// </summary>
        /// <param name="idPart">The part of the id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndIdContains(string idPart)
        {
            configurators.Add(new IdConfigurator(idPart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        #region Instance

        /// <summary>
        /// Adds a mechanism to find controls by the specified control instance.
        /// </summary>
        /// <param name="instance">The control instance.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ControlInstance(string instance)
        {
            return new By().AndControlInstance(instance);
        }

        /// <summary>
        /// Adds a mechanism to find controls by the specified control instance.
        /// </summary>
        /// <param name="instance">The control instance.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndControlInstance(string instance)
        {
            configurators.Add(new InstanceConfigurator(instance, PropertyExpressionOperator.EqualTo));
            return this;
        }

        #endregion

        #region Name

        /// <summary>
        /// Adds a mechanism to find controls by specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Name(string name)
        {
            return new By().AndName(name);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the name.
        /// </summary>
        /// <param name="namePart">The part of the name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By NameContains(string namePart)
        {
            return new By().AndNameContains(namePart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndName(string name)
        {
            configurators.Add(new NameConfigurator(name, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the name.
        /// </summary>
        /// <param name="namePart">The part of the name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndNameContains(string namePart)
        {
            configurators.Add(new NameConfigurator(namePart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        #region Search Properties

        /// <summary>
        /// Adds a mechanism to find controls by specified search properties.
        /// </summary>
        /// <param name="searchProperties">
        /// The search properties in the 'Name1=Value1;Name2=Value2' format.
        /// For example use the strict format of 'Id=firstname' for a control that has an Id of
        /// 'firstname', or the loose format of 'Id~firstname' for a control that has an Id that
        /// contains 'firstname'.
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By SearchProperties(string searchProperties)
        {
            return new By().AndSearchProperties(searchProperties);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified search properties.
        /// </summary>
        /// <param name="searchProperties">
        /// The search properties in the 'Name1=Value1;Name2=Value2' format.
        /// For example use the strict format of 'Id=firstname' for a control that has an Id of
        /// 'firstname', or the loose format of 'Id~firstname' for a control that has an Id that
        /// contains 'firstname'.
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndSearchProperties(string searchProperties)
        {
            configurators.Add(new SearchPropertiesConfigurator(searchProperties));
            return this;
        }

        #endregion

        #region Tag Name

        /// <summary>
        /// Adds a mechanism to find controls by specified tag name.
        /// </summary>
        /// <param name="tagName">The tag name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By TagName(string tagName)
        {
            return new By().AndTagName(tagName);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the tag name.
        /// </summary>
        /// <param name="tagNamePart">The part of the tag name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By TagNameContains(string tagNamePart)
        {
            return new By().AndTagNameContains(tagNamePart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified name.
        /// </summary>
        /// <param name="tagName">The tag name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndTagName(string tagName)
        {
            configurators.Add(new TagNameConfigurator(tagName, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the name.
        /// </summary>
        /// <param name="tagNamePart">The part of the tag name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndTagNameContains(string tagNamePart)
        {
            configurators.Add(new TagNameConfigurator(tagNamePart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        #region Value Attribute

        /// <summary>
        /// Adds a mechanism to find controls by specified value attribute.
        /// </summary>
        /// <param name="valueAttribute">The value attribute.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ValueAttribute(string valueAttribute)
        {
            return new By().AndValueAttribute(valueAttribute);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the value attribute.
        /// </summary>
        /// <param name="valueAttributePart">The part of the value attribute.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ValueAttributeContains(string valueAttributePart)
        {
            return new By().AndValueAttributeContains(valueAttributePart);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified value attribute.
        /// </summary>
        /// <param name="valueAttribute">The value attribute.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndValueAttribute(string valueAttribute)
        {
            configurators.Add(new ValueAttributeConfigurator(valueAttribute, PropertyExpressionOperator.EqualTo));
            return this;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified part of the value attribute.
        /// </summary>
        /// <param name="valueAttributePart">The part of the value attribute.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndValueAttributeContains(string valueAttributePart)
        {
            configurators.Add(new ValueAttributeConfigurator(valueAttributePart, PropertyExpressionOperator.Contains));
            return this;
        }

        #endregion

        /// <summary>
        /// Gets the search properties configuration of this instance.
        /// </summary>
        internal PropertyExpressionCollection Configuration
        {
            get
            {
                var searchProperties = new PropertyExpressionCollection();

                foreach (ISearchConfigurator configurator in configurators)
                {
                    configurator.Configure(searchProperties);
                }

                return searchProperties;
            }
        }
    }
}