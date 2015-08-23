using System.Windows.Forms;
using Sut.WinForms.Controls.Models;

namespace Sut.WinForms.Controls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            comboBox.DataSource = new BindingSource
            {
                DataSource = Mocked.Persons
            };

            listBox.DataSource = new BindingSource
            {
                DataSource = Mocked.Persons
            };

            foreach (Person person in Mocked.Persons)
            {
                string name = person.Name;
                string customer = person.IsCustomer ? "True" : "False";
                string gender = person.Gender.ToString();

                listView.Items.Add(new ListViewItem(new[] { name, customer, gender }));
            }
        }
    }
}