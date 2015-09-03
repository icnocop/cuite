using System;
using System.Collections.Generic;

namespace CUITe
{
    /// <summary>
    /// Exception thrown when search properties contains a key that isn't applicable on the control
    /// to search for.
    /// </summary>
    public class InvalidSearchPropertyNamesException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSearchPropertyNamesException"/> class.
        /// </summary>
        /// <param name="invalidsearchPropertyNames">The invalid search property names.</param>
        /// <param name="validsearchPropertyNames">The valid search property names.</param>
        public InvalidSearchPropertyNamesException(
            IEnumerable<string> invalidsearchPropertyNames,
            IEnumerable<string> validsearchPropertyNames)
            : base(string.Format(
                "The following search property names are not supported: '{0}'. Supported properties: '{1}'",
                string.Join(", ", invalidsearchPropertyNames),
                string.Join(", ", validsearchPropertyNames)))
        {
        }
    }
}