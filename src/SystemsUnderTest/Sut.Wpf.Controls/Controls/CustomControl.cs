using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Sut.Wpf.Controls.Controls
{
    public class CustomControl : Control
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(CustomControl),
            new FrameworkPropertyMetadata(
                string.Empty,
                FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsMeasure));

        static CustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(CustomControl),
                new FrameworkPropertyMetadata(typeof(CustomControl)));
        }

        public CustomControl()
        {
            Text = "This is a custom control";
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new CustomControlAutomationPeer(this);
        }
    }
}