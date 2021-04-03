using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class EditPotrebDialog : Form
    {
        public Potrebnost Potrebnost { get; set; }

        public EditPotrebDialog(Potrebnost potrebnost)
        {
            InitializeComponent();

            Potrebnost = potrebnost ?? new Potrebnost();
        }

        private void EditPotrebDialog_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DataBase.Session.QueryOver<User>().List();
            comboBox2.DataSource = DataBase.Session.QueryOver<User>().List();
            comboBox4.DataSource = DataBase.Session.QueryOver<Sdelka>().List();

            comboBox1.SelectedItem = Potrebnost.Client;
            comboBox2.SelectedItem = Potrebnost.Rieltor;
            comboBox3.SelectedItem = Potrebnost.NedvijType;
            comboBox4.SelectedItem = Potrebnost.Sdelka;
            
            UpdateFiels();
        }
        
        private void UpdateFiels()
        {
            kvartPanel.Visible = comboBox3.SelectedIndex == 0;
            domPanel.Visible = comboBox3.SelectedIndex == 1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFiels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Potrebnost.Client = comboBox1.SelectedItem as User;
            Potrebnost.Rieltor = comboBox2.SelectedItem as User;
            Potrebnost.NedvijType = comboBox3.SelectedItem as string;
            Potrebnost.Adres = textBox1.Text;
            Potrebnost.Sdelka = comboBox4.SelectedItem as Sdelka;
            Potrebnost.MinPrice = (int)numericUpDown1.Value;
            Potrebnost.MaxPrice = (int)numericUpDown2.Value;
            Potrebnost.MinPloshad = (int)numericUpDown3.Value;
            Potrebnost.MaxPloshad = (int)numericUpDown4.Value;
            Potrebnost.MinKomnat = (int)numericUpDown5.Value;
            Potrebnost.MaxKomnat = (int)numericUpDown6.Value;
            Potrebnost.MinEtaj = (int)numericUpDown7.Value;
            Potrebnost.MaxEtaj = (int)numericUpDown8.Value;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
