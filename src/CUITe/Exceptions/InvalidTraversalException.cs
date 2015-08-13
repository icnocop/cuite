using System;

namespace CUITe
{
    public class InvalidTraversalException : Exception
    {
        public InvalidTraversalException(string sMessage)
            : base(string.Format(
                "You are trying to traverse to an element/control which is not present in the tree: {0}",
                sMessage))
        {
        }
    }
}