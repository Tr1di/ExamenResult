using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class EditPredlDialog : Form
    {
        public Predlojenie Predlojenie { get; }

        public EditPredlDialog(Predlojenie pred)
        {
            InitializeComponent();

            Predlojenie = pred ?? new Predlojenie();
        }

        private void EditPredlDialog_Load(object sender, EventArgs e)
        {
            client.DataSource = DataBase.Session.QueryOver<User>().List();
            rieltor.DataSource = DataBase.Session.QueryOver<User>().List();
            nedvij.DataSource = DataBase.Session.QueryOver<Nedvijimost>().List();
            sdelka.DataSource = DataBase.Session.QueryOver<Sdelka>().List();

            client.SelectedItem = Predlojenie.Client;
            rieltor.SelectedItem = Predlojenie.Rieltor;
            nedvij.SelectedItem = Predlojenie.Nedvijimost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Predlojenie.Client = client.SelectedItem as User;
            Predlojenie.Rieltor = rieltor.SelectedItem as User;
            Predlojenie.Nedvijimost = nedvij.SelectedItem as Nedvijimost;
            Predlojenie.Sdelka = sdelka.SelectedItem as Sdelka;
            Predlojenie.Price = (int)price.Value;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
