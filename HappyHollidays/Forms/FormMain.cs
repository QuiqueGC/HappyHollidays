using HappyHollidays.Forms;
using HappyHollidays.Utils;
using System;
using System.Windows.Forms;

namespace HappyHollidays
{
    public partial class FormMain : Form
    {
        private FormActivities formActivities;
        private FormHotels formHotels;
        private FormChains formChains;
        private FormCities formCities;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tsmiChains.ShortcutKeys = Keys.Control | Keys.D1;
            tsmiHotels.ShortcutKeys = Keys.Control | Keys.D2;
            tsmiCities.ShortcutKeys = Keys.Control | Keys.D3;
            tsmiActivities.ShortcutKeys = Keys.Control | Keys.D4;
            tsmiChains.ShortcutKeys = Keys.Control | Keys.D1;
            tsmiExit.ShortcutKeys = Keys.Alt | Keys.F4;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyUtils.ShowConfirmDialogAndExit(e);
        }

        private void tsmiChains_Click(object sender, EventArgs e)
        {
            RemoveFormsFromPanel();
            formChains = new FormChains();
            AddingFormmToPanel(formChains);
        }

        private void tsmiHotels_Click(object sender, EventArgs e)
        {
            RemoveFormsFromPanel();
            formHotels = new FormHotels();
            AddingFormmToPanel(formHotels);
        }

        private void tsmiCities_Click(object sender, EventArgs e)
        {
            RemoveFormsFromPanel();
            formCities = new FormCities();
            AddingFormmToPanel(formCities);
        }

        private void tsmiActivities_Click(object sender, EventArgs e)
        {
            RemoveFormsFromPanel();
            formActivities = new FormActivities();
            AddingFormmToPanel(formActivities);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Añade un formulario al panel del MainForm y lo muestra
        /// </summary>
        /// <param name="form">El formulario que se mostrará en el panel</param>
        private void AddingFormmToPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// Vacía el panel principal
        /// </summary>
        private void RemoveFormsFromPanel()
        {
            panelMain.BackgroundImage = null;
            CheckingIfNullAndClose(formActivities);
            CheckingIfNullAndClose(formCities);
            CheckingIfNullAndClose(formHotels);
            CheckingIfNullAndClose(formChains);
        }

        /// <summary>
        /// Chequea si un formulario no es null y lo cierra
        /// </summary>
        /// <param name="form">El formulario que chequea</param>
        private void CheckingIfNullAndClose(Form form)
        {
            if (form != null)
            {
                form.Dispose();
                panelMain.Controls.Remove(form);
            }
        }
    }
}
