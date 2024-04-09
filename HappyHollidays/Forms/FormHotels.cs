using HappyHollidays.Dialogs;
using HappyHollidays.ModalForms;
using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays.Forms
{
    public partial class FormHotels : Form
    {
        public FormHotels()
        {
            InitializeComponent();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if (dgvHotels.SelectedRows.Count > 0) 
            {
                ActivitiesListModalForm activitiesListModalForm = new ActivitiesListModalForm(
                    (hoteles)dgvHotels.SelectedRows[0].DataBoundItem);
                activitiesListModalForm.FormClosed +=
                    (closeSender, closeE) =>
                    SelectActivitiesDependingOnFilters();
                activitiesListModalForm.ShowDialog();
            }
        }

        private void FormHotels_Load(object sender, EventArgs e)
        {
            SelectHotelsDependingOnFilters();
            bsCities.DataSource = CiudadesOrm.Select();
            cbCity.SelectedItem = null;
            cbCategory.SelectedItem = null;
            cbType.SelectedItem = null;
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectHotelsDependingOnFilters();
        }

        private void imgCleanFiltersHotels_Click(object sender, EventArgs e)
        {
            cbType.SelectedItem = null;
            cbCity.SelectedItem = null;
            cbCategory.SelectedItem = null;
            SelectHotelsDependingOnFilters();
        }

        private void tbFindHotel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                SelectHotelsDependingOnFilters();
            }
        }

        private void imgFindHotel_Click(object sender, EventArgs e)
        {
            SelectHotelsDependingOnFilters();
        }

        private void dgvHotels_SelectionChanged(object sender, EventArgs e)
        {
            TakeActivitiesFromHotel();
        }

        private void dgvActivities_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                act_hotel act_hotel = (act_hotel)dgvActivities.Rows[e.RowIndex].DataBoundItem;
                e.Value = act_hotel.actividades.descripcion;
            }
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            TakeActivitiesFromHotel();
        }

        private void imgFindActivity_Click(object sender, EventArgs e)
        {
            TakeActivitiesFromHotel();
        }

        private void tbFindActivity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                TakeActivitiesFromHotel();
            }
        }

        private void imgCleanFiltersActivities_Click(object sender, EventArgs e)
        {
            TakeActivitiesFromHotel();
        }

        private void dgvHotels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                hoteles hotel = (hoteles)dgvHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = hotel.ciudades.nombre;
            }

            if (e.ColumnIndex == 6)
            {
                hoteles hotel = (hoteles)dgvHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = hotel.cadenas.nombre;
            }
        }

        private void btnModifyHotel_Click(object sender, EventArgs e)
        {
            HotelModalForm hotelModalForm = new HotelModalForm(
                (hoteles)dgvHotels.SelectedRows[0].DataBoundItem
                );
            hotelModalForm.FormClosed +=
                (closeSender, closeE) =>
                SelectHotelsDependingOnFilters();
            hotelModalForm.ShowDialog();
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            HotelModalForm hotelModalForm = new HotelModalForm(null);
            hotelModalForm.FormClosed +=
                (closeSender, closeE) =>
                SelectHotelsDependingOnFilters();
            hotelModalForm.ShowDialog();
        }

        private void btnDeleteHotel_Click(object sender, EventArgs e)
        {
            DeleteHotel();
        }

        private void dgvHotels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteHotel();
            }
        }

        private void DeleteHotel()
        {
            if (dgvHotels.SelectedRows.Count > 0)
            {
                if (MyUtils.ShowConfirmDialogAndDelete())
                {
                    string msg = HotelesOrm.Delete((hoteles)dgvHotels.SelectedRows[0].DataBoundItem);
                    MyUtils.ShowPosibleError(msg);
                    SelectHotelsDependingOnFilters();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar antes un hotel de la lista", "Error");
            }
        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            DeleteActivity();
        }

        /// <summary>
        /// Realiza el delete en la BBDD de actividades en hoteles o muestra un diálogo de error
        /// </summary>
        private void DeleteActivity()
        {
            if (dgvActivities.SelectedRows.Count > 0)
            {
                if (MyUtils.ShowConfirmDialogAndDelete())
                {
                    string msg = ActividadesHotelesOrm.Delete((act_hotel)dgvActivities.SelectedRows[0].DataBoundItem);
                    MyUtils.ShowPosibleError(msg);
                    dgvActivities.ClearSelection();
                    SelectActivitiesDependingOnFilters();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar antes una actividad de la lista", "Error");
            }
        }

        /// <summary>
        /// Extrae la lista de actividades pertenecientes al hotel
        /// en caso de que haya alguno seleccionado
        /// </summary>
        private void TakeActivitiesFromHotel()
        {
            if (dgvHotels.SelectedRows.Count > 0)
            {
                SelectActivitiesDependingOnFilters();
            }
        }

        /// <summary>
        /// hace el select de actividades dependiendo de los filtros aplicados
        /// </summary>
        private void SelectActivitiesDependingOnFilters()
        {
            bsActivitiesInHotel.DataSource =
                    ActividadesHotelesOrm.Select(
                    tbFindActivity.Text,
                    (hoteles)dgvHotels.SelectedRows[0].DataBoundItem
                    );
        }

        /// <summary>
        /// Hace el select de hoteles dependiendo de los filtros y 
        /// del textBox de búsqueda
        /// </summary>
        private void SelectHotelsDependingOnFilters()
        {
            if (cbCity.SelectedItem != null &&
                cbCategory.SelectedItem != null &&
                cbType.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    cbType.SelectedItem.ToString(),
                    MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString()),
                    (ciudades)cbCity.SelectedItem
                );

            }
            else if (cbCategory.SelectedItem != null &&
                cbCity.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString()),
                    (ciudades)cbCity.SelectedItem
                );

            }
            else if (cbType.SelectedItem != null &&
                cbCity.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    cbType.SelectedItem.ToString(),
                    (ciudades)cbCity.SelectedItem
                );

            }
            else if (cbCategory.SelectedItem != null &&
                cbType.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    cbType.SelectedItem.ToString(),
                    MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString())
                );

            }
            else if (cbCategory.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString())
                    );

            }
            else if (cbCity.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                        tbFindHotel.Text.Trim(),
                    (ciudades)cbCity.SelectedItem
                        );

            }
            else if (cbType.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                        tbFindHotel.Text.Trim(),
                    cbType.SelectedItem.ToString()
                        );
            }
            else
            {
                bsHotels.DataSource = HotelesOrm.Select(tbFindHotel.Text);
            }
        }
    }
}
