using System;

namespace CUITe.Controls
{
    public class GenericException : Exception
    {
        public GenericException(string sMessage)
            : base(sMessage)
        {
        }
    }
}