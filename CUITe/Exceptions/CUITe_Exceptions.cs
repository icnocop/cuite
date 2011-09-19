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

    public class CUITe_WrongPageExpectedException : Exception
    {
        public CUITe_WrongPageExpectedException(string sMessage) : base(sMessage) { }
    }

    public class CUITe_InvalidSearchKey : Exception
    {
        public CUITe_InvalidSearchKey(string sKey) : base(string.Format("Search Pattern Key not supported -> {0}.", sKey)) { }
    }
}
