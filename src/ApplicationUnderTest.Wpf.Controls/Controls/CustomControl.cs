using System.Windows;
using System.Windows.Controls;

namespace ApplicationUnderTest.Wpf.Controls.Controls
{
    public class CustomControl : Control
    {
        static CustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(CustomControl),
                new FrameworkPropertyMetadata(typeof(CustomControl)));
        }
    }
}