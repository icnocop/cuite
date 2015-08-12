using CUITe.Controls.WpfControls;

namespace Sample_CUITeTestProject_WpfControls.ObjectLibrary
{
    public class WinWpfControls : WpfWindow
    {
        public WinWpfControls() : base("ClassName~ControlTemplateExamples.exe") { }

        public WpfButton btnDefault { get { return Get<WpfButton>("AutomationID=btnDefault"); } }

        public WpfCheckBox chkNormal { get { return Get<WpfCheckBox>("AutomationID=chkNormal"); } }
        public WpfCheckBox chkChecked { get { return Get<WpfCheckBox>("AutomationID=chkChecked"); } }
        public WpfCheckBox chkIndeterminate { get { return Get<WpfCheckBox>("AutomationID=chkIndeterminate"); } }

        public WpfTable dg1 { get { return Get<WpfTable>("AutomationID=dg1"); } }

    }
}
