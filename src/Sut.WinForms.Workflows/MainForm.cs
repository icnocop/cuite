using System;
using System.Linq;
using System.Windows.Forms;
using Sut.WinForms.Workflows.Pages;

namespace Sut.WinForms.Workflows
{
    public partial class MainForm : Form
    {
        private readonly UserControl[] pages;
        private UserControl currentPage;
        
        public MainForm()
        {
            InitializeComponent();

            pages = new UserControl[]
            {
                new NamePage(),
                new AddressPage(),
                new FinishedPage()
            };

            ShowPage(pages.First());
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int currentPageIndex = Array.IndexOf(pages, currentPage);
            ShowPage(pages[currentPageIndex + 1]);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int currentPageIndex = Array.IndexOf(pages, currentPage);
            ShowPage(pages[currentPageIndex - 1]);
        }

        private void ShowPage(UserControl page)
        {
            currentPage = page;
            panelPage.Controls.Clear();
            panelPage.Controls.Add(currentPage);

            buttonPrevious.Visible = currentPage != pages.Last();
            buttonPrevious.Enabled = currentPage != pages.First();

            buttonNext.Visible = currentPage != pages.Last();
            buttonNext.Enabled = currentPage != pages.Last();
        }
    }
}