using System;
using System.Collections.Generic;

namespace CUITe
{
    /// <summary>
    /// Exception thrown when search properties contains a key that isn't applicable on the control
    /// to search for.
    /// </summary>
    public class InvalidSearchKeyException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidSearchKeyException"/> class.
        /// </summary>
        /// <param name="invalidKey">The invalid search key.</param>
        /// <param name="searchProperties">The search properties.</param>
        /// <param name="controlProperties">The control properties.</param>
        public InvalidSearchKeyException(
            string invalidKey,
            string searchProperties,
            IEnumerable<string> controlProperties)
            : base(string.Format(
                "Search property key not supported -> '{0}' in '{1}'. Available Properties: {2}",
                invalidKey,
                searchProperties,
                string.Join(", ", controlProperties)))
        {
        }
    }
}