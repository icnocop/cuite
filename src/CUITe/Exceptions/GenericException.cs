using System;

namespace CUITe
{
    public class GenericException : Exception
    {
        public GenericException(string sMessage)
            : base(sMessage)
        {
        }
    }
}