 using System;
 using System.Collections.Generic;

namespace CUITe.Controls
{
    public interface IControlBase
    {
        Type GetBaseType();

        void Wrap(object control);

        void WrapReady(object control);

        void WaitForControlReady();

        void Click();

        void DoubleClick();

        bool Enabled
        {
            get;
        }

        bool Exists
        {
            get;
        }

        void SetFocus();

        void SetSearchProperty(string sPropertyName, string sValue);

        void SetSearchPropertyRegx(string sPropertyName, string sValue);

        IControlBase Parent { get; }

        IControlBase PreviousSibling { get; }

        IControlBase NextSibling { get; }

        IControlBase FirstChild { get; }

        List<IControlBase> GetChildren();
    }
}