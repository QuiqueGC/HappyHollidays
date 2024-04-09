using HappyHollidays.Dialogs;
using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;
namespace HappyHollidays.Forms
{
    public partial class FormChains : Form
    {
        public FormChains()
        {
            InitializeComponent();
        }

        private void FormChains_Load(object sender, EventArgs e)
        {
            bsChains.DataSource = CadenasOrm.Select();
            bsCities.DataSource = CiudadesOrm.Select();
            cbCity.SelectedItem = null;
            cbCategory.SelectedItem = null;
        }

        private void btnAddChain_Click(object sender, EventArgs e)
        {
            ChainModalForm chainModalForm = new ChainModalForm(null);
            chainModalForm.FormClosed +=
                (closeSender, closeE) =>
                bsChains.DataSource = CadenasOrm.Select(tbFindChain.Text.Trim());
            chainModalForm.ShowDialog();
        }

        private void imgFindChain_Click(object sender, EventArgs e)
        {
            bsChains.DataSource = CadenasOrm.Select(tbFindChain.Text.Trim());
        }

        private void tbFindChain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                bsChains.DataSource = CadenasOrm.Select(tbFindChain.Text.Trim());
            }
        }

        private void dgvChains_SelectionChanged(object sender, EventArgs e)
        {
            TakeHotelsFromChain();
        }

        private void dgvHotels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                hoteles hotel = (hoteles)dgvHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = hotel.ciudades.nombre;
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvChains.SelectedRows.Count > 0)
            {
                SelectHotelsDependingOnFilters();
            }
        }

        private void imgCleanFiltersHotels_Click(object sender, EventArgs e)
        {
            cbCity.SelectedItem = null;
            cbCategory.SelectedItem = null;
            if (dgvChains.SelectedRows.Count > 0)
            {
                SelectHotelsDependingOnFilters();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteChain();
        }

        private void dgvChains_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteChain();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvChains.SelectedRows.Count > 0)
            {
                ChainModalForm chainModalForm =
                    new ChainModalForm((cadenas)dgvChains.SelectedRows[0].DataBoundItem);
                chainModalForm.FormClosed +=
                    (closeSender, closeE) =>
                    bsChains.DataSource = CadenasOrm.Select(tbFindChain.Text.Trim());
                chainModalForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar antes una cadena de la lista", "Error");
            }
        }

        private void tbFindHotel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                TakeHotelsFromChain();
            }
        }

        private void imgFindHotel_Click(object sender, EventArgs e)
        {
            TakeHotelsFromChain();
        }

        /// <summary>
        /// Extrae la lista de hoteles pertenecientes a la cadena
        /// en caso de que haya alguna seleccionada
        /// </summary>
        private void TakeHotelsFromChain()
        {
            if (dgvChains.SelectedRows.Count > 0)
            {
                SelectHotelsDependingOnFilters();
            }
        }

        /// <summary>
        /// Hace el select de hoteles dependiendo de los filtros y el textBox
        /// de búsqueda
        /// </summary>
        private void SelectHotelsDependingOnFilters()
        {
            if (cbCity.SelectedItem != null &&
                cbCategory.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    (cadenas)bsChains.Current,
                (ciudades)cbCity.SelectedItem,
                MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString())
                    );
            }
            else if (cbCategory.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    (cadenas)bsChains.Current,
                    MyUtils.ParseNumfromString(cbCategory.SelectedItem.ToString())
                    );

            }
            else if (cbCity.SelectedItem != null)
            {
                bsHotels.DataSource = HotelesOrm.Select(
                        tbFindHotel.Text.Trim(),
                        (cadenas)bsChains.Current,
                    (ciudades)cbCity.SelectedItem
                    );
            }
            else
            {
                bsHotels.DataSource = HotelesOrm.Select(
                    tbFindHotel.Text.Trim(),
                    (cadenas)dgvChains.SelectedRows[0].DataBoundItem
                    );
            }
        }

        /// <summary>
        /// comprueba que hay algún elemento seleccionado y lo borra
        /// </summary>
        private void DeleteChain()
        {
            if (dgvChains.SelectedRows.Count > 0)
            {
                if (MyUtils.ShowConfirmDialogAndDelete())
                {
                    string msg = CadenasOrm.Delete((cadenas)dgvChains.SelectedRows[0].DataBoundItem);
                    MyUtils.ShowPosibleError(msg);
                    bsChains.DataSource = CadenasOrm.Select(tbFindChain.Text.Trim());
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar antes una cadena de la lista", "Error");
            }
        }
    }


}
