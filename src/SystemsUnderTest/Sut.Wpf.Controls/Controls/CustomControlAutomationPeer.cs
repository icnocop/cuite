using System.Windows;
using System.Windows.Automation.Peers;

namespace Sut.Wpf.Controls.Controls
{
    public class CustomControlAutomationPeer : FrameworkElementAutomationPeer
    {
        public CustomControlAutomationPeer(FrameworkElement owner)
            : base(owner)
        {
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Custom;
        }

        protected override string GetClassNameCore()
        {
            return "CustomControl";
        }

        protected override string GetNameCore()
        {
            var customControl = (CustomControl)Owner;
            return customControl.Text;
        }
    }
}