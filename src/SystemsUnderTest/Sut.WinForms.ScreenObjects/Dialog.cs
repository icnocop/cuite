using System;
using System.Windows.Forms;

namespace Sut.WinForms.ScreenObjects
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}