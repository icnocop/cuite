 using System;
 using System.Collections.Generic;

namespace CUITe.Controls
{
    public interface IControlBase
    {
        IControlBase Parent { get; }

        IControlBase PreviousSibling { get; }

        IControlBase NextSibling { get; }

        IControlBase FirstChild { get; }

        bool Enabled { get; }

        bool Exists { get; }

        Type SourceType { get; }

        void Wrap(object control);

        void WrapReady(object control);

        void WaitForControlReady();

        void Click();

        void DoubleClick();
        
        void SetFocus();

        void SetSearchProperty(string sPropertyName, string sValue);

        void SetSearchPropertyRegx(string sPropertyName, string sValue);

        List<IControlBase> GetChildren();
    }
}