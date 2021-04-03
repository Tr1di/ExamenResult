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

        private void EditPred(Predlojenie pred = null)
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
            EditPred();
        }

        private void editPredlButton_Click(object sender, EventArgs e)
        {
            EditPred(predlList.SelectedItem as Predlojenie);
        }

        private void deletePredlButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pred = predlList.SelectedItem as Predlojenie;

                if (pred.Sdelka != null)
                {
                    MessageBox.Show("Данное предложение учавствует в сделке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataBase.Session.Delete(pred);
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
