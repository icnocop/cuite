namespace Sut.Wpf.Controls.Controls
{
    public partial class RichTextBoxControl
    {
        public RichTextBoxControl()
        {
            InitializeComponent();

            richTextBox.AppendText("This is a rich text box");
        }
    }
}