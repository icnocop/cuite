using System;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Exception thrown when search properties aren't correctly formatted.
    /// </summary>
    public class InvalidSearchPropertiesFormatException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSearchPropertiesFormatException"/>
        /// class.
        /// </summary>
        /// <param name="searchProperties">The invalid formatted search properties.</param>
        public InvalidSearchPropertiesFormatException(string searchProperties)
            : base(string.Format(
                "Search properties format is not valid -> '{0}', should be like 'Key1=Value1;Key2=Value2;'.",
                searchProperties))
        {
        }
    }
}