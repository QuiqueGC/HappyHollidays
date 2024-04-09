using HappyHollidays.ModalForms;
using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays.Forms
{
    public partial class FormCities : Form
    {
        public FormCities()
        {
            InitializeComponent();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            CityModalForm cityModalForm = new CityModalForm();
            cityModalForm.FormClosed +=
                (closeSender, closeE) =>
                DoSelectCities();
            cityModalForm.ShowDialog();
        }

        private void FormCities_Load(object sender, EventArgs e)
        {
            bsChains.DataSource = CadenasOrm.Select();
            DoSelectCities();
            doSelectHotelsDependingOnFilters();
            ClearFilters();
        }

        private void tbFindCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                DoSelectCities();
            }
        }

        private void imgFindCity_Click(object sender, EventArgs e)
        {
            DoSelectCities();
        }

        private void cbChain_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSelectHotelsDependingOnFilters();
        }

        private void tbFindHotel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                doSelectHotelsDependingOnFilters();
            }
        }

        private void imgFindHotel_Click(object sender, EventArgs e)
        {
            doSelectHotelsDependingOnFilters();
        }

        private void imgCleanFiltersHotels_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
        
        private void lbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSelectHotelsDependingOnFilters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DoDeleteCity();
        }

        private void lbCities_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DoDeleteCity();
            }
        }

        /// <summary>
        /// hace el select de hoteles en la BBDD
        /// dependiendo de los filtros
        /// </summary>
        private void doSelectHotelsDependingOnFilters()
        {
            if (lbCities.SelectedItem != null)
            {
                if (cbChain.SelectedItem != null &&
                    cbCategory.SelectedItem != null)
                {
                    bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    (cadenas)cbChain.SelectedItem,
                    (ciudades)lbCities.SelectedItem,
                    MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString())
                    );
                }
                else if (cbCategory.SelectedItem != null)
                {
                    bsHotels.DataSource = HotelesOrm.Select(
                     tbFindHotel.Text.Trim(),
                     MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString()),
                     (ciudades)lbCities.SelectedItem
                     );
                }
                else if (cbChain.SelectedItem != null)
                {
                    bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    (cadenas)cbChain.SelectedItem,
                    (ciudades)lbCities.SelectedItem);
                }
                else
                {
                    bsHotels.DataSource = HotelesOrm.Select(
                        tbFindHotel.Text.Trim(),
                        (ciudades)lbCities.SelectedItem);
                }
            }
        }

        /// <summary>
        /// hace el select de ciudades dependiendo del
        /// texto que aparece en el textbox de búsqueda
        /// </summary>
        private void DoSelectCities()
        {
            bsCities.DataSource = CiudadesOrm.Select(tbFindCity.Text.Trim());
        }

        /// <summary>
        /// limpia los comboboxes
        /// </summary>
        private void ClearFilters()
        {
            cbCategory.SelectedItem = null;
            cbChain.SelectedItem = null;
        }

        /// <summary>
        /// Realiza el delete de la ciudad en la BBDD
        /// y devuelve un mensaje si fue exitoso o si hubo un error
        /// </summary>
        private void DoDeleteCity()
        {
            if (lbCities.SelectedItems.Count > 0)
            {
                if (MyUtils.ShowConfirmDialogAndDelete())
                {
                    string msg = CiudadesOrm.Delete((ciudades)lbCities.SelectedItems[0]);
                    MyUtils.ShowPosibleError(msg);
                    DoSelectCities();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna ciudad seleccionada.", "Error");
            }
        }
    }
}
