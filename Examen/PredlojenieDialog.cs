using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class PredlojenieDialog : Form
    {
        public PredlojenieDialog()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            predlList.DataSource = DataBase.Session.QueryOver<Predlojenie>().List();
        }

        private void EditPred(Predlojenie pred)
        {
            var dialog = new EditPredlDialog(pred);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataBase.Session.SaveOrUpdate(dialog.Predlojenie);
                DataBase.Session.Flush();
                UpdateList();
            }
        }

        private void newPredlButton_Click(object sender, EventArgs e)
        {
            EditPred(new Predlojenie());
        }

        private void editPredlButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditPred(predlList.SelectedItem as Predlojenie);
            }
            catch { }
        }

        private void deletePredlButton_Click(object sender, EventArgs e)
        {
            try
            {
                // if (pred.Sdelka != 0)
                // {
                //     MessageBox.Show("Данное предложение учавствует в сделке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //     return;
                // }

                DataBase.Session.Delete(predlList.SelectedItem);
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
