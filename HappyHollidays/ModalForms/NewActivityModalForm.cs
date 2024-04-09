using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays.ModalForms
{
    public partial class NewActivityModalForm : Form
    {
        int idActivity;

        public NewActivityModalForm(int idActivity)
        {
            InitializeComponent();
            this.idActivity = idActivity;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text.Trim() != "")
            {
                DoInsert();
            }
            else
            {
                MessageBox.Show("Debes ponerle una descripción a la actividad.", "Error");
            }
        }

        private void ActivityModalForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            { 
                btnAccept.PerformClick(); 
            }
        }

        /// <summary>
        /// Realiza el insert de la actividad en la BBDD
        /// </summary>
        private void DoInsert()
        {
            actividades activity = new actividades();
            activity.descripcion = tbDescription.Text;
            activity.id_act = idActivity;
            string msg = ActividadesOrm.Insert(activity);
            MyUtils.ShowPosibleError(msg);
            Close();
        }
    }
}
