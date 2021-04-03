using System;
using System.Windows.Forms;

namespace Examen
{
    public partial class UsersDialog : Form
    {
        public UsersDialog()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = listBox1.SelectedItem as User;
            listBox2.DataSource = user?.Potrebnosti;
            listBox3.DataSource = user?.Predlojeniya;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = DataBase.Session.QueryOver<User>().List();
        }
    }
}
