using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CUITe
{
    public class CUITe_GenericException : Exception
    {
        public CUITe_GenericException(string sMessage) : base(sMessage) { }
    }

    public class CUITe_InvalidSearchParameterFormat : Exception
    {
        public CUITe_InvalidSearchParameterFormat(string sSearchParameters) : base(string.Format("Search Parameter Format is not valid -> '{0}', should be like 'sKey1=sValue1;sKey2=sValue2;'.", sSearchParameters)) { }
    }

    public class CUITe_WrongPageExpectedException : Exception
    {
        public CUITe_WrongPageExpectedException(string sMessage) : base(sMessage) { }
    }

    public class CUITe_InvalidSearchKey : Exception
    {
        public CUITe_InvalidSearchKey(string sKey, string sSearchParameters) : base(string.Format("Search Pattern Key not supported -> '{0}' in '{1}'.", sKey, sSearchParameters)) { }
    }
}
