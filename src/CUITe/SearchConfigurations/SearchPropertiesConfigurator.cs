using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties according to a advanced text
    /// syntax.
    /// </summary>
    internal class SearchPropertiesConfigurator : ISearchConfigurator
    {
        private readonly string searchProperties;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPropertiesConfigurator"/> class.
        /// </summary>
        /// <param name="searchProperties">
        /// The search properties in the 'Name1=Value1;Name2=Value2' format.
        /// For example use the strict format of 'Id=firstname' for a control that has an Id of
        /// 'firstname', or the loose format of 'Id~firstname' for a control that has an Id that
        /// contains 'firstname'.
        /// </param>
        internal SearchPropertiesConfigurator(string searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            this.searchProperties = searchProperties;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        /// <exception cref="InvalidSearchPropertiesFormatException">
        /// Format of search properties is invalid.
        /// </exception>
        public void Configure(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            // Split on groups of name/value pairs
            string[] nameValuePairs = this.searchProperties.Split(
                new[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string nameValuePair in nameValuePairs)
            {
                var compareOperator = PropertyExpressionOperator.EqualTo;

                // If split on '=' does not work, then try '~'
                // Split at the first instance of '='. Other instances are considered part of the value.
                string[] splittedNameValuePair = nameValuePair.Split(
                    new[] { '=' },
                    2);

                if (splittedNameValuePair.Length != 2)
                {
                    // Otherwise try to split on '~'. If it works then compare type is Contains
                    // Split at the first instance of '~'. Other instances are considered part of the value.
                    splittedNameValuePair = nameValuePair.Split(
                        new[] { '~' },
                        2);

                    if (splittedNameValuePair.Length == 2)
                    {
                        compareOperator = PropertyExpressionOperator.Contains;
                    }
                    else
                    {
                        throw new InvalidSearchPropertiesFormatException(this.searchProperties);
                    }
                }

                // Add the search property, value and type
                searchProperties.Add(splittedNameValuePair[0], splittedNameValuePair[1], compareOperator);
            }
        }
    }
}