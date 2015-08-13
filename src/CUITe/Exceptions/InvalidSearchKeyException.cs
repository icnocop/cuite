using System;
using System.Collections.Generic;

namespace CUITe
{
    public class InvalidSearchKeyException : Exception
    {
        public InvalidSearchKeyException(string sKey, string searchParameters, List<string> controlProperties)
            : base(string.Format(
                "Search Pattern Key not supported -> '{0}' in '{1}'. Available Properties: {2}",
                sKey,
                searchParameters,
                string.Join(", ", controlProperties)))
        {
        }
    }
}