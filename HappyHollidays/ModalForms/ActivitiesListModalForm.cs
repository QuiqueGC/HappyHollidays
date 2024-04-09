using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays.ModalForms
{
    public partial class ActivitiesListModalForm : Form
    {
        hoteles hotel;
        int grade;
        public ActivitiesListModalForm(hoteles hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void ActivitiesListModalForm_Load(object sender, EventArgs e)
        {
            bsActivities.DataSource = ActividadesOrm.Select(tbFindActivity.Text);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(lbActivities.SelectedItem != null &&
                tbGrade.Text != "") 
            {
                grade = MyUtils.ParseNumfromString(tbGrade.Text);
                if (grade > 0 && grade <= 100) 
                {
                    DoInsert();
                }
                else
                {
                    MessageBox.Show("Debes introducir un número entero entre 0 y 100 en el grado.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una actividad y un grado.", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbFindActivity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bsActivities.DataSource = ActividadesOrm.Select(tbFindActivity.Text);
            }
        }

        private void imgFindActivity_Click(object sender, EventArgs e)
        {
            bsActivities.DataSource = ActividadesOrm.Select(tbFindActivity.Text);
        }

        private void tbGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        /// <summary>
        /// Realiza el insert en la BBDD
        /// </summary>
        private void DoInsert()
        {
            act_hotel act_hotel = SetActivityInHotelObject();
            string msg = ActividadesHotelesOrm.Insert(act_hotel);
            MyUtils.ShowPosibleError(msg);
            Close();
        }

        /// <summary>
        /// Crea el objeto act_hotel con todos sus campos
        /// rellenos y lo devuelve
        /// </summary>
        /// <returns>objeto act_hotel con los datos recogidos</returns>
        private act_hotel SetActivityInHotelObject()
        {
            act_hotel act_hotel = new act_hotel();
            act_hotel.actividades = (actividades)lbActivities.SelectedItem;
            act_hotel.grado = grade;
            act_hotel.hoteles = hotel;
            return act_hotel;
        }
    }
}
