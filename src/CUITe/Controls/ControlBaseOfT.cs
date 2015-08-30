using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls
{
    /// <summary>
    /// Base class for all UI test controls. It provides properties and methods which are generic
    /// to controls across technologies.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="SourceControl"/>.</typeparam>
    public abstract class ControlBase<T> : ControlBase where T : UITestControl
    {
        private readonly T sourceControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlBase{T}"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchProperties">The search properties.</param>
        /// <exception cref="InvalidSearchPropertiesFormatException">
        /// Search properties are not correctly formatted.
        /// </exception>
        /// <exception cref="InvalidSearchKeyException">
        /// Search properties contains key that isn't applicable on the control.
        /// </exception>
        protected ControlBase(T sourceControl, string searchProperties = null)
            : base(sourceControl)
        {
            if (sourceControl == null)
                throw new ArgumentNullException("sourceControl");

            this.sourceControl = sourceControl;
            
            AddSearchProperties(ParseSearchProperties(searchProperties));
        }

        /// <summary>
        /// Gets the source control.
        /// </summary>
        public new T SourceControl
        {
            get { return sourceControl; }
        }

        /// <summary>
        /// Adds a search property by using the provided property name and property value.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="propertyValue">The property value to search for.</param>
        public void AddSearchProperty(string propertyName, string propertyValue)
        {
            SourceControl.SearchProperties.Add(propertyName, propertyValue);
        }

        /// <summary>
        /// Adds a search property by using the provided property name, value, and operator.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="propertyValue">The property value to search for.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        public void AddSearchProperty(
            string propertyName,
            string propertyValue,
            PropertyExpressionOperator conditionOperator)
        {
            SourceControl.SearchProperties.Add(propertyName, propertyValue, conditionOperator);
        }

        /// <summary>
        /// Adds all search property in the provided collection.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public void AddSearchProperties(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            SourceControl.SearchProperties.AddRange(searchProperties);
        }
        
        /// <summary>
        /// Finds the control object from the descendants of this control using the specified
        /// search properties.
        /// </summary>
        /// <typeparam name="TControl">The type of control to find.</typeparam>
        /// <param name="searchProperties">
        /// The search properties in the 'Key1=Value1;Key2=Value2' format.
        /// For example use 'Id=firstname' for a control that has an Id of 'firstname' or
        /// 'Id~firstname' for a control that has an Id that contains the text 'firstname'.
        /// </param>
        /// <exception cref="InvalidSearchPropertiesFormatException">
        /// Search properties are not correctly formatted.
        /// </exception>
        /// <exception cref="InvalidSearchKeyException">
        /// Search properties contains key that isn't applicable on the control.
        /// </exception>
        public TControl Find<TControl>(string searchProperties = null) where TControl : ControlBase
        {
            var control = ControlBaseFactory.Create<TControl>(searchProperties);
            control.SourceControl.Container = sourceControl;
            return control;
        }

        private static PropertyExpressionCollection ParseSearchProperties(string searchProperties)
        {
            var parsedSearchProperties = new PropertyExpressionCollection();

            if (searchProperties == null)
                return parsedSearchProperties;

            // Fill the UITestControl's search properties based on the search string provided.
            // Iterate through the class inheritance hierarchy to get a list of property names for
            // the specific control.
            // Note: Some properties may not be valid to use for search (ex. filter property names).
            // Microsoft does not provide and exact list.
            var controlProperties = new List<FieldInfo>();

            Type nestedType = typeof(T);
            Type nestedPropertyNamesType = nestedType.GetNestedType("PropertyNames");

            while (nestedType != typeof(object))
            {
                if (nestedPropertyNamesType != null)
                {
                    controlProperties.AddRange(nestedPropertyNamesType.GetFields());
                }

                nestedType = nestedType.BaseType;
                nestedPropertyNamesType = nestedType.GetNestedType("PropertyNames");
            }

            // Split on groups of key/value pairs
            string[] saKeyValuePairs = searchProperties.Split(
                new[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string sKeyValue in saKeyValuePairs)
            {
                var compareOperator = PropertyExpressionOperator.EqualTo;

                // If split on '=' does not work, then try '~'
                // Split at the first instance of '='. Other instances are considered part of the value.
                string[] saKeyVal = sKeyValue.Split(
                    new[] { '=' },
                    2);

                if (saKeyVal.Length != 2)
                {
                    // Otherwise try to split on '~'. If it works then compare type is Contains
                    // Split at the first instance of '~'. Other instances are considered part of the value.
                    saKeyVal = sKeyValue.Split(
                        new[] { '~' },
                        2);

                    if (saKeyVal.Length == 2)
                    {
                        compareOperator = PropertyExpressionOperator.Contains;
                    }
                    else
                    {
                        throw new InvalidSearchPropertiesFormatException(searchProperties);
                    }
                }

                // Find the first property in the list of known values
                string valueName = saKeyVal[0];

                if ((typeof(T).IsSubclassOf(typeof(CUITControls.HtmlControl))) && (valueName.Equals("Value", StringComparison.OrdinalIgnoreCase)))
                {
                    // Support for backward compatibility where search properties like "Value=Log In" are used
                    valueName += "Attribute";
                }

                FieldInfo foundField = controlProperties.Find(searchProperty =>
                    searchProperty.Name.Equals(valueName, StringComparison.OrdinalIgnoreCase));

                if (foundField == null)
                {
                    throw new InvalidSearchKeyException(valueName, searchProperties, controlProperties.Select(x => x.Name).ToList());
                }

                // Add the search property, value and type
                parsedSearchProperties.Add(foundField.GetValue(null).ToString(), saKeyVal[1], compareOperator);
            }

            return parsedSearchProperties;
        }
    }
}