using System;

namespace CUITe.Controls
{
    /// <summary>
    /// Exception thrown when trying to traverse to a UI test control that isn't found in the UI
    /// tree.
    /// </summary>
    public class InvalidTraversalException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidTraversalException"/> class.
        /// </summary>
        /// <param name="controlTypeNotFound">The UI test control type not found.</param>
        public InvalidTraversalException(string controlTypeNotFound)
            : base(string.Format("The control '{0}' was not found when traversing the UI tree", controlTypeNotFound))
        {
        }
    }
}