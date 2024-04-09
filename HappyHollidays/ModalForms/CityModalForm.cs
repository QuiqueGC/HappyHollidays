using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays.ModalForms
{
    public partial class CityModalForm : Form
    {
        public CityModalForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Trim() != "") 
            {
                DoInsert();
            }
            else
            {
                MessageBox.Show("Debes ponerle un nombre a la ciudad.", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CityModalForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        /// <summary>
        /// Realiza el insert de la ciudad en la BBDD
        /// y muestra un diálogo conforme ha sido éxito o ha habido un error
        /// </summary>
        private void DoInsert()
        {
            ciudades city = new ciudades();
            city.nombre = tbName.Text;
            string msg = CiudadesOrm.Insert(city);
            MyUtils.ShowPosibleError(msg);
            Close();
        }
    }
}
