using HappyHollidays.Models;
using HappyHollidays.Models.Queries;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays.Dialogs
{
    public partial class ChainModalForm : Form
    {
        cadenas chain;
        public ChainModalForm(cadenas chain)
        {
            InitializeComponent();
            this.chain = chain;
        }

        private void ChainModalForm_Load(object sender, EventArgs e)
        {
            if(chain != null)
            {
                tbCifLetter.Text = chain.cif[0].ToString();
                tbCifLetter.Enabled = false;
                tbCifNums.Text = chain.cif.Substring(1);
                tbCifNums.Enabled = false;
                tbName.Text = chain.nombre;
                tbFiscalAddress.Text = chain.dir_fis;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(tbCifLetter.Text.Trim() != "" &&
                tbCifNums.Text.Trim() != "" &&
                tbName.Text.Trim() != "" &&
                tbFiscalAddress.Text.Trim() != "")
            {
                CheckLetterCifAndSave();
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos.", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbCifLetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        /// <summary>
        /// Chequea si los datos del CIF son correctos y guarda la cadena de hoteles
        /// </summary>
        private void CheckLetterCifAndSave()
        {
            if (CheckCifAvailibleLetter(tbCifLetter.Text.Trim().ToUpper()))
            {
                CheckNumberCifAndSave();
            }
            else
            {
                MessageBox.Show("No has introducido una letra válida en el CIF.", "Error");
            }
        }

        /// <summary>
        /// Hace un último chequeo con los números del CIF y guarda los datos
        /// </summary>
        private void CheckNumberCifAndSave()
        {
            if (CheckCifAvailibleNum(tbCifNums.Text.Trim()))
            {
                if (chain == null)
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
                MessageBox.Show("El número del CIF debe estar compuesto por 8 números.", "Error");
            }
        }

        /// <summary>
        /// realiza las operaciones necesarias para hacer un update en la BBDD
        /// </summary>
        private void DoUpdate()
        {
            SetChainObject();
            string msg = Orm.Update();
            MyUtils.ShowPosibleError(msg);
            Close();
        }

        /// <summary>
        /// realiza las operaciones necesarias para hacer un insert en la BBDD
        /// </summary>
        private void DoInsert()
        {
            chain = new cadenas();
            SetChainObject();
            string msg = CadenasOrm.Insert(chain);
            CleanForm();
            chain = null;
            MyUtils.ShowPosibleError(msg);
        }

        /// <summary>
        /// crea un objeto de tipo cadenas dependiendo del parámetro
        /// que pasó por el constructor
        /// </summary>
        private void SetChainObject()
        {
            string cif = tbCifLetter.Text.Trim().ToUpper() + tbCifNums.Text.Trim();
            chain.cif = cif;
            chain.nombre = tbName.Text.Trim();
            chain.dir_fis = tbFiscalAddress.Text.Trim();
        }

        /// <summary>
        /// limpia todos los campos para seguir creando elementos
        /// </summary>
        private void CleanForm()
        {
            tbCifLetter.Clear();
            tbCifNums.Clear();
            tbName.Clear();
            tbFiscalAddress.Clear();
        }

        /// <summary>
        /// chequea si el número del cif está compuesto por 8 enteros
        /// </summary>
        /// <param name="nums">string para chequear</param>
        /// <returns>true si es correcto o false si no lo es</returns>
        private bool CheckCifAvailibleNum(string nums)
        {
            if (nums.Length == 8)
            {
                return int.TryParse(nums, out _);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Chequea si la letra introducida es correcta 
        /// </summary>
        /// <returns>true si es correcta o false si no</returns>
        private bool CheckCifAvailibleLetter(string letter)
        {
            if (letter == "A" ||
                letter == "B" ||
                letter == "C" ||
                letter == "D" ||
                letter == "E" ||
                letter == "F" ||
                letter == "G" ||
                letter == "H"
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
