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

            Potrebnost = potrebnost ?? new PotrebKvartira();

            UpdateFiels();
        }

        private void UpdateFiels()
        {
            kvartPanel.Visible = Potrebnost is PotrebKvartira;
            domPanel.Visible = Potrebnost is PotrebDom;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    Potrebnost = new PotrebKvartira();
                    break;
                case 1:
                    Potrebnost = new PotrebDom();
                    break;
                case 2:
                    Potrebnost = new PotrebZem();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

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

            switch (Potrebnost)
            {
                case PotrebKvartira kvar:
                    kvar.MinPloshad = (int)numericUpDown3.Value;
                    kvar.MaxPloshad = (int)numericUpDown4.Value;

                    kvar.MinKomnat = (int)numericUpDown5.Value;
                    kvar.MaxKomnat = (int)numericUpDown6.Value;

                    kvar.MinEtaj = (int)numericUpDown7.Value;
                    kvar.MaxEtaj = (int)numericUpDown8.Value;
                    break;
                case PotrebDom dom:
                    dom.MinPloshad = (int)numericUpDown3.Value;
                    dom.MaxPloshad = (int)numericUpDown4.Value;

                    dom.MinKomnat = (int)numericUpDown9.Value;
                    dom.MaxKomnat = (int)numericUpDown10.Value;

                    dom.MinEtajnost = (int)numericUpDown11.Value;
                    dom.MaxEtajnost = (int)numericUpDown12.Value;
                    break;
                case PotrebZem zem:
                    zem.MinPloshad = (int)numericUpDown3.Value;
                    zem.MaxPloshad = (int)numericUpDown4.Value;
                    break;
                default:
                    return;
            }

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void EditPotrebDialog_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DataBase.Session.QueryOver<User>().List();
            comboBox2.DataSource = DataBase.Session.QueryOver<User>().List();
            comboBox4.DataSource = DataBase.Session.QueryOver<Sdelka>().List();

            try
            {
                comboBox1.SelectedItem = Potrebnost.Client;
                comboBox2.SelectedItem = Potrebnost.Rieltor;
                comboBox3.SelectedItem = Potrebnost.NedvijType;
                comboBox4.SelectedItem = Potrebnost.Sdelka;
            }
            catch { }
        }
    }
}
