using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CUITe.Controls.WpfControls;

namespace Sample_CUITeTestProject_WpfControls.ObjectLibrary
{
    public class winWpfControls : CUITe_WpfWindow
    {
        public winWpfControls() : base("ClassName~ControlTemplateExamples.exe") { }

        public CUITe_WpfButton btnDefault { get { return Get<CUITe_WpfButton>("AutomationID=btnDefault"); } }

        public CUITe_WpfCheckBox chkNormal { get { return Get<CUITe_WpfCheckBox>("AutomationID=chkNormal"); } }
        public CUITe_WpfCheckBox chkChecked { get { return Get<CUITe_WpfCheckBox>("AutomationID=chkChecked"); } }
        public CUITe_WpfCheckBox chkIndeterminate { get { return Get<CUITe_WpfCheckBox>("AutomationID=chkIndeterminate"); } }

    }
}
