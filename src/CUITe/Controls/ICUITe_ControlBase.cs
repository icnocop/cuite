 using System;
 using System.Collections.Generic;

namespace CUITe.Controls
{
    public interface ICUITe_ControlBase
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

        ICUITe_ControlBase Parent { get; }

        ICUITe_ControlBase PreviousSibling { get; }

        ICUITe_ControlBase NextSibling { get; }

        ICUITe_ControlBase FirstChild { get; }

        List<ICUITe_ControlBase> GetChildren();
    }
}