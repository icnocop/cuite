using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CUITe
{
    public class CUITe_GenericException : Exception
    {
        public CUITe_GenericException(string sMessage) : base("CUITe_GenericException: " + sMessage) { }
    }

    public class CUITe_WrongPageExpectedException : Exception
    {
        public CUITe_WrongPageExpectedException(string sMessage) : base("CUITe_WrongPageExpectedException: " + sMessage) { }
    }
}
