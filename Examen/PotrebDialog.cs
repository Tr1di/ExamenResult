using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class PotrebDialog : Form
    {
        public PotrebDialog()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            listBox1.DataSource = DataBase.Session.QueryOver<Potrebnost>().List();
        }

        private void EditPotreb(Potrebnost potrebnost = null)
        {
            var dialog = new EditPotrebDialog(potrebnost);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataBase.Session.SaveOrUpdate(dialog.Potrebnost);
                DataBase.Session.Flush();

                UpdateList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPotreb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            EditPotreb(listBox1.SelectedItem as Potrebnost);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var potreb = listBox1.SelectedItem as Potrebnost;

                if (potreb.Sdelka == null)
                {
                    MessageBox.Show("Данная потребность учавствует в сделке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataBase.Session.Delete(potreb);
                DataBase.Session.Flush();

                UpdateList();
            }
            catch (ArgumentNullException) 
            {
                MessageBox.Show("Нечего удалять", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
