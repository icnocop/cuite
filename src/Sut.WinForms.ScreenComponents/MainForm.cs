using System.Windows.Forms;

namespace Sut.WinForms.ScreenComponents
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenModalDialog_Click(object sender, System.EventArgs e)
        {
            new Dialog().ShowDialog(this);
        }

        private void buttonOpenNonModalDialog_Click(object sender, System.EventArgs e)
        {
            new Dialog().Show(this);
        }
    }
}