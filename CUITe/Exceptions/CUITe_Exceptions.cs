using System;
using System.Collections.Generic;

namespace CUITe
{
    public class CUITe_GenericException : Exception
    {
        public CUITe_GenericException(string sMessage) : base(sMessage) { }
    }

    public class CUITe_InvalidSearchParameterFormat : Exception
    {
        public CUITe_InvalidSearchParameterFormat(string searchParameters)
            : base(string.Format("Search Parameter Format is not valid -> '{0}', should be like 'sKey1=sValue1;sKey2=sValue2;'.", searchParameters))
        { }
    }

    public class CUITe_WrongPageExpectedException : Exception
    {
        public CUITe_WrongPageExpectedException(string sMessage) : base(sMessage) { }
    }

    public class CUITe_InvalidSearchKey : Exception
    {
        public CUITe_InvalidSearchKey(string sKey, string searchParameters, List<string> controlProperties)
            : base(string.Format("Search Pattern Key not supported -> '{0}' in '{1}'. Available Properties: {2}", sKey, searchParameters,
            string.Join(", ", controlProperties)))
        { }
    }

    public class CUITe_InvalidTraversal : Exception
    {
        public CUITe_InvalidTraversal(string sMessage)
            : base(string.Format("You are trying to traverse to an element/control which is not present in the tree: {0}", sMessage))
        { }
    }
}
