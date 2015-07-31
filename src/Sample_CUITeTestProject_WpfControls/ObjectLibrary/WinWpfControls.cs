using CUITe.Controls.WpfControls;

namespace Sample_CUITeTestProject_WpfControls.ObjectLibrary
{
    public class WinWpfControls : CUITe_WpfWindow
    {
        public WinWpfControls() : base("ClassName~ControlTemplateExamples.exe") { }

        public CUITe_WpfButton btnDefault { get { return Get<CUITe_WpfButton>("AutomationID=btnDefault"); } }

        public CUITe_WpfCheckBox chkNormal { get { return Get<CUITe_WpfCheckBox>("AutomationID=chkNormal"); } }
        public CUITe_WpfCheckBox chkChecked { get { return Get<CUITe_WpfCheckBox>("AutomationID=chkChecked"); } }
        public CUITe_WpfCheckBox chkIndeterminate { get { return Get<CUITe_WpfCheckBox>("AutomationID=chkIndeterminate"); } }

        public CUITe_WpfTable dg1 { get { return Get<CUITe_WpfTable>("AutomationID=dg1"); } }

    }
}
