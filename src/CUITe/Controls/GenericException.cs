using System;

namespace CUITe.Controls
{
    /// <summary>
    /// Generic exception
    /// </summary>
    public class GenericException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public GenericException(string message)
            : base(message)
        {
        }
    }
}