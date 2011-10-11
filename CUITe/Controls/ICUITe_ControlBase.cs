﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using SHDocVw;
using mshtml;

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
    }
}