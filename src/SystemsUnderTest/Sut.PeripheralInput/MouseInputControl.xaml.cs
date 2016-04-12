using System.Windows.Input;

namespace Sut.PeripheralInput
{
    public partial class MouseInputControl
    {
        public MouseInputControl()
        {
            InitializeComponent();
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultTextBox.Text = GetResult(e);
        }

        private static string GetResult(MouseButtonEventArgs e)
        {
            if (e.ClickCount > 2)
                return string.Empty;

            return string.Format(
                "{0} {1}{2}",
                e.ChangedButton,
                e.ClickCount == 1 ? "click" : "double click",
                Keyboard.Modifiers != ModifierKeys.None ? " with " + Keyboard.Modifiers : string.Empty);
        }
    }
}