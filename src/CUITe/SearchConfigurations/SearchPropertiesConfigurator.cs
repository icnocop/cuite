using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.SearchConfigurations
{
    internal class SearchPropertiesConfigurator : ISearchPropertiesConfigurator
    {
        private readonly string searchProperties;

        public SearchPropertiesConfigurator(string searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            this.searchProperties = searchProperties;
        }

        public void Configure(PropertyExpressionCollection searchProperties)
        {
            // Split on groups of key/value pairs
            string[] saKeyValuePairs = this.searchProperties.Split(
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
                        throw new InvalidSearchPropertiesFormatException(this.searchProperties);
                    }
                }

                // Add the search property, value and type
                searchProperties.Add(saKeyVal[0], saKeyVal[1], compareOperator);
            }
        }

        ///// <param name="searchProperties">
        ///// The search properties in the 'Key1=Value1;Key2=Value2' format.
        ///// For example use 'Id=firstname' for a control that has an Id of 'firstname' or
        ///// 'Id~firstname' for a control that has an Id that contains the text 'firstname'.
        ///// </param>

        //private static PropertyExpressionCollection ParseSearchProperties(By searchConfiguration)
        //{
        //    var parsedSearchProperties = new PropertyExpressionCollection();

        //    if (searchProperties == null)
        //        return parsedSearchProperties;

        //    // Fill the UITestControl's search properties based on the search string provided.
        //    // Iterate through the class inheritance hierarchy to get a list of property names for
        //    // the specific control.
        //    // Note: Some properties may not be valid to use for search (ex. filter property names).
        //    // Microsoft does not provide and exact list.
        //    var controlProperties = new List<FieldInfo>();

        //    Type nestedType = typeof(T);
        //    Type nestedPropertyNamesType = nestedType.GetNestedType("PropertyNames");

        //    while (nestedType != typeof(object))
        //    {
        //        if (nestedPropertyNamesType != null)
        //        {
        //            controlProperties.AddRange(nestedPropertyNamesType.GetFields());
        //        }

        //        nestedType = nestedType.BaseType;
        //        nestedPropertyNamesType = nestedType.GetNestedType("PropertyNames");
        //    }

        //    // Split on groups of key/value pairs
        //    string[] saKeyValuePairs = searchProperties.Split(
        //        new[] { ';' },
        //        StringSplitOptions.RemoveEmptyEntries);

        //    foreach (string sKeyValue in saKeyValuePairs)
        //    {
        //        var compareOperator = PropertyExpressionOperator.EqualTo;

        //        // If split on '=' does not work, then try '~'
        //        // Split at the first instance of '='. Other instances are considered part of the value.
        //        string[] saKeyVal = sKeyValue.Split(
        //            new[] { '=' },
        //            2);

        //        if (saKeyVal.Length != 2)
        //        {
        //            // Otherwise try to split on '~'. If it works then compare type is Contains
        //            // Split at the first instance of '~'. Other instances are considered part of the value.
        //            saKeyVal = sKeyValue.Split(
        //                new[] { '~' },
        //                2);

        //            if (saKeyVal.Length == 2)
        //            {
        //                compareOperator = PropertyExpressionOperator.Contains;
        //            }
        //            else
        //            {
        //                throw new InvalidSearchPropertiesFormatException(searchProperties);
        //            }
        //        }

        //        // Find the first property in the list of known values
        //        string valueName = saKeyVal[0];

        //        if ((typeof(T).IsSubclassOf(typeof(CUITControls.HtmlControl))) && (valueName.Equals("Value", StringComparison.OrdinalIgnoreCase)))
        //        {
        //            // Support for backward compatibility where search properties like "Value=Log In" are used
        //            valueName += "Attribute";
        //        }

        //        FieldInfo foundField = controlProperties.Find(searchProperty =>
        //            searchProperty.Name.Equals(valueName, StringComparison.OrdinalIgnoreCase));

        //        if (foundField == null)
        //        {
        //            throw new InvalidSearchKeyException(valueName, searchConfiguration, controlProperties.Select(x => x.Name).ToList());
        //        }

        //        // Add the search property, value and type
        //        parsedSearchProperties.Add(foundField.GetValue(null).ToString(), saKeyVal[1], compareOperator);
        //    }

        //    return parsedSearchProperties;
        //}
        
    }
}