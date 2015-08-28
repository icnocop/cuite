using System;

namespace CUITe
{
    public class InvalidSearchParameterFormatException : Exception
    {
        public InvalidSearchParameterFormatException(string searchProperties)
            : base(string.Format(
                "Search Parameter Format is not valid -> '{0}', should be like 'sKey1=sValue1;sKey2=sValue2;'.",
                searchProperties))
        {
        }
    }
}