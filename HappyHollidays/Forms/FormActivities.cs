using HappyHollidays.ModalForms;
using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays.Forms
{
    public partial class FormActivities : Form
    {
        public FormActivities()
        {
            InitializeComponent();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            int idActivity = GenerateIdForActivity();
            NewActivityModalForm newActivityModalForm = new NewActivityModalForm(idActivity);
            newActivityModalForm.FormClosed +=
                (closeSender, closeE) =>
                SelectActivities();
            newActivityModalForm.ShowDialog();
        }

        private void FormActivities_Load(object sender, EventArgs e)
        {
            doSelectActivitiesInHotelDependingOnFilters();
            SelectActivities();
            bsCities.DataSource = CiudadesOrm.Select();
            cbCity.SelectedItem = null;
        }

        private void imgFindActivity_Click(object sender, EventArgs e)
        {
            SelectActivities();
        }

        private void tbFindActivity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SelectActivities();
            }
        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            DeleteActivity();
        }

        private void lbActivities_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteActivity();
            }
        }

        private void lbActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSelectActivitiesInHotelDependingOnFilters();
        }

        private void dgvHotels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                act_hotel act_hotel = (act_hotel)dgvActivitiesInHotel.Rows[e.RowIndex].DataBoundItem;
                e.Value = act_hotel.hoteles.ciudades.nombre;
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSelectActivitiesInHotelDependingOnFilters();
        }

        private void imgCleanFiltersHotels_Click(object sender, EventArgs e)
        {
            cbCity.SelectedItem = null;
            doSelectActivitiesInHotelDependingOnFilters();
        }

        private void imgFindHotel_Click(object sender, EventArgs e)
        {
            doSelectActivitiesInHotelDependingOnFilters();
        }

        private void tbFindHotel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doSelectActivitiesInHotelDependingOnFilters();
            }
        }

        /// <summary>
        /// genera el id de la nueva actividad que se generará
        /// (esta tabla no tiene el id autoincremental en la BBDD)
        /// </summary>
        /// <returns>int con el id</returns>
        private int GenerateIdForActivity()
        {
            int idActivity = -1;
            foreach (actividades activity in bsActivities)
            {
                if (activity.id_act > idActivity)
                {
                    idActivity = activity.id_act;
                }
            }
            return idActivity + 1;
        }

        /// <summary>
        /// Hace el select de actividades en base a lo que
        /// pone en el textBox de búsqueda
        /// </summary>
        private void SelectActivities()
        {
            bsActivities.DataSource = ActividadesOrm.Select(tbFindActivity.Text);
        }

        /// <summary>
        /// hace el select de los hoteles en la BBDD
        /// OJO! El select es en la tabla de act_hotel
        /// y no en la de hoteles
        /// </summary>
        private void doSelectActivitiesInHotelDependingOnFilters()
        {
            if (lbActivities.SelectedItems.Count > 0)
            {
                if (cbCity.SelectedItem != null)
                {
                    bsActivitiesInHotel.DataSource =
                        ActividadesHotelesOrm.Select(
                            tbFindHotel.Text.Trim(),
                            (ciudades)cbCity.SelectedItem,
                            (actividades)lbActivities.SelectedItem
                            );
                }
                else
                {
                    bsActivitiesInHotel.DataSource =
                        ActividadesHotelesOrm.Select(
                            tbFindHotel.Text.Trim(),
                            (actividades)lbActivities.SelectedItem
                            );
                }
            }
        }

        /// <summary>
        /// Hace el delete de la actividad seleccionanda en la BBDD 
        /// </summary>
        private void DeleteActivity()
        {
            if (lbActivities.SelectedItems.Count > 0)
            {
                if (MyUtils.ShowConfirmDialogAndDelete())
                {
                    string msg = ActividadesOrm.Delete((actividades)lbActivities.SelectedItem);
                    MyUtils.ShowPosibleError(msg);
                    lbActivities.ClearSelected();
                    SelectActivities();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar antes una actividad de la lista", "Error");
            }
        }
    }
}
