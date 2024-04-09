using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HappyHollidays.Dialogs
{
    public partial class HotelModalForm : Form
    {
        hoteles hotel;
        private List<PictureBox> stars = new List<PictureBox>();
        int category = 0;

        public HotelModalForm(hoteles hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
            stars.Add(imgStar1);
            stars.Add(imgStar2);
            stars.Add(imgStar3);
            stars.Add(imgStar4);
            stars.Add(imgStar5);
        }

        private void HotelDialog_Load(object sender, EventArgs e)
        {
            bsCities.DataSource = CiudadesOrm.Select();
            bsChain.DataSource = CadenasOrm.Select();
            if(hotel != null)
            {
                setDataInForm();
            }
            else
            {
                cbCity.SelectedItem = null;
                cbChain.SelectedItem = null;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Trim() != "" &&
               tbAddress.Text.Trim() != "" &&
               tbPhone.Text.Trim() != "" &&
               cbCity.SelectedItem != null &&
               cbChain.SelectedItem != null
               )
            {
                CheckRadioButtonsAndSave();
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos y seleccionar tanto ciudad como cadena.", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgStar1_Click(object sender, EventArgs e)
        {
            SetStarsAndCategory(1);
        }

        private void imgStar2_Click(object sender, EventArgs e)
        {
            SetStarsAndCategory(2);
        }

        private void imgStar3_Click(object sender, EventArgs e)
        {
            SetStarsAndCategory(3);
        }

        private void imgStar4_Click(object sender, EventArgs e)
        {
            SetStarsAndCategory(4);
        }

        private void imgStar5_Click(object sender, EventArgs e)
        {
            SetStarsAndCategory(5);
        }

        private void imgCancel_Click(object sender, EventArgs e)
        {
            SetStarsAndCategory(0);
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        private void tbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        private void tbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        private void rbBeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        /// <summary>
        /// Establece los datos del hotel que llega por parámetros
        /// en el formulario
        /// </summary>
        private void setDataInForm()
        {
            tbName.Text = hotel.nombre;
            tbName.Enabled = false;
            SetStarsAndCategory(hotel.categoria);
            tbAddress.Text = hotel.direccion;
            tbPhone.Text = hotel.telefono.ToString();
            switch (hotel.tipo)
            {
                case "PLAYA":
                    rbBeach.Checked = true;
                    break;
                case "MONTAÑA":
                    rbMountain.Checked = true;
                    break;
                case "CIUDAD":
                    rbCity.Checked = true;
                    break;
                case "RURAL":
                    rbRural.Checked = true;
                    break;
            }
            cbChain.SelectedItem = hotel.cadenas;
            cbCity.SelectedItem = hotel.ciudades;
            cbCity.Enabled = false;
        }

        /// <summary>
        /// Chequea que haya algún radioButton seleccionado
        /// </summary>
        private void CheckRadioButtonsAndSave()
        {
            if (rbBeach.Checked ||
                rbCity.Checked ||
                rbMountain.Checked ||
                rbRural.Checked)
            {
                CheckIfRightPhoneAndSave();
            }
            else
            {
                MessageBox.Show("Debes seleccionar algún tipo.", "Error");
            }
        }

        /// <summary>
        /// Chequea que el número de teléfono introducido es correcto y guarda el hotel
        /// </summary>
        private void CheckIfRightPhoneAndSave()
        {
            if (int.TryParse(tbPhone.Text, out _))
            {

                if (hotel == null)
                {
                    DoInsert();
                }
                else
                {
                    DoUpdate();
                }
            }
            else
            {
                MessageBox.Show("Debes introducir sólo números enteros en el teléfono.", "Error");
            }
        }

        /// <summary>
        /// realiza el update en la BBDD
        /// </summary>
        private void DoUpdate()
        {
            SetHotelObject();
            string msg = Orm.Update();
            MyUtils.ShowPosibleError(msg);
            Close();
        }

        /// <summary>
        /// realiza el insert en la BBDD
        /// </summary>
        private void DoInsert()
        {
            hotel = new hoteles();
            SetHotelObject();
            string msg = HotelesOrm.Insert(hotel);
            CleanForm();
            hotel = null;
            MyUtils.ShowPosibleError(msg);
        }

        /// <summary>
        /// Limpia el formulario para seguir añadiendo hoteles
        /// </summary>
        private void CleanForm()
        {
            SetStarsAndCategory(0);
            cbCity.SelectedItem = null;
            tbName.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
            rbBeach.Checked = false;
            rbCity.Checked = false;
            rbMountain.Checked = false;
            rbRural.Checked = false;
            cbChain.SelectedItem = null;
        }

        /// <summary>
        /// Rellena el objeto hotel con los datos del formulario
        /// </summary>
        private void SetHotelObject()
        {
            hotel.id_ciudad = MyUtils.ParseNumfromString(cbCity.SelectedValue.ToString());
            hotel.nombre = tbName.Text.Trim();
            hotel.categoria = category;
            hotel.direccion = tbAddress.Text.Trim();
            hotel.telefono = MyUtils.ParseNumfromString(tbPhone.Text.Trim());
            hotel.tipo = TakeTypeFromRadioButtons();
            hotel.cif = cbChain.SelectedValue.ToString();
        }

        /// <summary>
        /// establece la categoría en base al radioButton seleccionado
        /// </summary>
        /// <returns>string con la categoría</returns>
        private string TakeTypeFromRadioButtons()
        {
            string category = "";

            if (rbBeach.Checked)
            {
                category = "PLAYA";
            }
            else if (rbMountain.Checked)
            {
                category = "MONTAÑA";
            }
            else if (rbCity.Checked)
            {
                category = "CIUDAD";
            }
            else if (rbRural.Checked)
            {
                category = "RURAL";
            }
            return category;
        }

        /// <summary>
        /// Cambia la imagen de las estrellas en base a la que clicas
        /// </summary>
        /// <param name="imgIndex">La posición de la estrella (0 es el cancelar)</param>
        private void SetStarsAndCategory(int imgIndex)
        {
            category = imgIndex;
            foreach (PictureBox star in stars)
            {
                star.Image = Properties.Resources.star;
            }

            for (int i = 0; i < imgIndex; i++)
            {
                stars[i].Image = Properties.Resources.yellowStar;
            }
        }
    }


}
