namespace HappyHollidays.Forms
{
    partial class FormActivities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.gbActivities = new System.Windows.Forms.GroupBox();
            this.imgFindActivity = new System.Windows.Forms.PictureBox();
            this.lbActivities = new System.Windows.Forms.ListBox();
            this.bsActivities = new System.Windows.Forms.BindingSource(this.components);
            this.tbFindActivity = new System.Windows.Forms.TextBox();
            this.lblFindActivity = new System.Windows.Forms.Label();
            this.gbHotels = new System.Windows.Forms.GroupBox();
            this.imgFindHotel = new System.Windows.Forms.PictureBox();
            this.tbFindHotel = new System.Windows.Forms.TextBox();
            this.lblFindHotel = new System.Windows.Forms.Label();
            this.dgvActivitiesInHotel = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsActivitiesInHotel = new System.Windows.Forms.BindingSource(this.components);
            this.gbFiltersHotels = new System.Windows.Forms.GroupBox();
            this.imgCleanFiltersHotels = new System.Windows.Forms.PictureBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.bsCities = new System.Windows.Forms.BindingSource(this.components);
            this.gbActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivities)).BeginInit();
            this.gbHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitiesInHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivitiesInHotel)).BeginInit();
            this.gbFiltersHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteActivity.Location = new System.Drawing.Point(12, 476);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(163, 34);
            this.btnDeleteActivity.TabIndex = 1;
            this.btnDeleteActivity.Text = "Borrar actividad";
            this.btnDeleteActivity.UseVisualStyleBackColor = false;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddActivity.Location = new System.Drawing.Point(181, 476);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(174, 34);
            this.btnAddActivity.TabIndex = 3;
            this.btnAddActivity.Text = "Añadir actividad";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // gbActivities
            // 
            this.gbActivities.BackColor = System.Drawing.Color.SeaGreen;
            this.gbActivities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbActivities.Controls.Add(this.imgFindActivity);
            this.gbActivities.Controls.Add(this.lbActivities);
            this.gbActivities.Controls.Add(this.tbFindActivity);
            this.gbActivities.Controls.Add(this.lblFindActivity);
            this.gbActivities.Location = new System.Drawing.Point(12, 12);
            this.gbActivities.Name = "gbActivities";
            this.gbActivities.Size = new System.Drawing.Size(343, 458);
            this.gbActivities.TabIndex = 0;
            this.gbActivities.TabStop = false;
            this.gbActivities.Text = "Actividades";
            // 
            // imgFindActivity
            // 
            this.imgFindActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindActivity.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindActivity.Location = new System.Drawing.Point(277, 19);
            this.imgFindActivity.Name = "imgFindActivity";
            this.imgFindActivity.Size = new System.Drawing.Size(50, 43);
            this.imgFindActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindActivity.TabIndex = 5;
            this.imgFindActivity.TabStop = false;
            this.imgFindActivity.Click += new System.EventHandler(this.imgFindActivity_Click);
            // 
            // lbActivities
            // 
            this.lbActivities.DataSource = this.bsActivities;
            this.lbActivities.DisplayMember = "descripcion";
            this.lbActivities.FormattingEnabled = true;
            this.lbActivities.ItemHeight = 18;
            this.lbActivities.Location = new System.Drawing.Point(6, 70);
            this.lbActivities.Name = "lbActivities";
            this.lbActivities.Size = new System.Drawing.Size(331, 382);
            this.lbActivities.TabIndex = 1;
            this.lbActivities.TabStop = false;
            this.lbActivities.ValueMember = "id_act";
            this.lbActivities.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            this.lbActivities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbActivities_KeyDown);
            // 
            // bsActivities
            // 
            this.bsActivities.DataSource = typeof(HappyHollidays.Models.actividades);
            // 
            // tbFindActivity
            // 
            this.tbFindActivity.Location = new System.Drawing.Point(77, 26);
            this.tbFindActivity.Name = "tbFindActivity";
            this.tbFindActivity.Size = new System.Drawing.Size(194, 23);
            this.tbFindActivity.TabIndex = 0;
            this.tbFindActivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindActivity_KeyDown);
            // 
            // lblFindActivity
            // 
            this.lblFindActivity.AutoSize = true;
            this.lblFindActivity.Location = new System.Drawing.Point(22, 29);
            this.lblFindActivity.Name = "lblFindActivity";
            this.lblFindActivity.Size = new System.Drawing.Size(49, 18);
            this.lblFindActivity.TabIndex = 4;
            this.lblFindActivity.Text = "Buscar";
            // 
            // gbHotels
            // 
            this.gbHotels.BackColor = System.Drawing.Color.SeaGreen;
            this.gbHotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbHotels.Controls.Add(this.imgFindHotel);
            this.gbHotels.Controls.Add(this.tbFindHotel);
            this.gbHotels.Controls.Add(this.lblFindHotel);
            this.gbHotels.Controls.Add(this.dgvActivitiesInHotel);
            this.gbHotels.Controls.Add(this.gbFiltersHotels);
            this.gbHotels.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbHotels.Location = new System.Drawing.Point(388, 13);
            this.gbHotels.Margin = new System.Windows.Forms.Padding(4);
            this.gbHotels.Name = "gbHotels";
            this.gbHotels.Padding = new System.Windows.Forms.Padding(4);
            this.gbHotels.Size = new System.Drawing.Size(747, 497);
            this.gbHotels.TabIndex = 4;
            this.gbHotels.TabStop = false;
            this.gbHotels.Text = "Lista de hoteles con la actividad seleccionada";
            // 
            // imgFindHotel
            // 
            this.imgFindHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindHotel.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindHotel.Location = new System.Drawing.Point(551, 98);
            this.imgFindHotel.Name = "imgFindHotel";
            this.imgFindHotel.Size = new System.Drawing.Size(50, 43);
            this.imgFindHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindHotel.TabIndex = 6;
            this.imgFindHotel.TabStop = false;
            this.imgFindHotel.Click += new System.EventHandler(this.imgFindHotel_Click);
            // 
            // tbFindHotel
            // 
            this.tbFindHotel.Location = new System.Drawing.Point(211, 107);
            this.tbFindHotel.Name = "tbFindHotel";
            this.tbFindHotel.Size = new System.Drawing.Size(330, 23);
            this.tbFindHotel.TabIndex = 2;
            this.tbFindHotel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindHotel_KeyDown);
            // 
            // lblFindHotel
            // 
            this.lblFindHotel.AutoSize = true;
            this.lblFindHotel.Location = new System.Drawing.Point(142, 110);
            this.lblFindHotel.Name = "lblFindHotel";
            this.lblFindHotel.Size = new System.Drawing.Size(49, 18);
            this.lblFindHotel.TabIndex = 2;
            this.lblFindHotel.Text = "Buscar";
            // 
            // dgvActivitiesInHotel
            // 
            this.dgvActivitiesInHotel.AllowUserToAddRows = false;
            this.dgvActivitiesInHotel.AllowUserToDeleteRows = false;
            this.dgvActivitiesInHotel.AllowUserToResizeRows = false;
            this.dgvActivitiesInHotel.AutoGenerateColumns = false;
            this.dgvActivitiesInHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivitiesInHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivitiesInHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.grado,
            this.idciudadDataGridViewTextBoxColumn});
            this.dgvActivitiesInHotel.DataSource = this.bsActivitiesInHotel;
            this.dgvActivitiesInHotel.Location = new System.Drawing.Point(7, 151);
            this.dgvActivitiesInHotel.MultiSelect = false;
            this.dgvActivitiesInHotel.Name = "dgvActivitiesInHotel";
            this.dgvActivitiesInHotel.ReadOnly = true;
            this.dgvActivitiesInHotel.RowHeadersVisible = false;
            this.dgvActivitiesInHotel.RowHeadersWidth = 51;
            this.dgvActivitiesInHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivitiesInHotel.Size = new System.Drawing.Size(733, 339);
            this.dgvActivitiesInHotel.TabIndex = 3;
            this.dgvActivitiesInHotel.TabStop = false;
            this.dgvActivitiesInHotel.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHotels_CellFormatting);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre hotel";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grado
            // 
            this.grado.DataPropertyName = "grado";
            this.grado.FillWeight = 50F;
            this.grado.HeaderText = "Grado";
            this.grado.Name = "grado";
            this.grado.ReadOnly = true;
            // 
            // idciudadDataGridViewTextBoxColumn
            // 
            this.idciudadDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.idciudadDataGridViewTextBoxColumn.Name = "idciudadDataGridViewTextBoxColumn";
            this.idciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsActivitiesInHotel
            // 
            this.bsActivitiesInHotel.DataSource = typeof(HappyHollidays.Models.act_hotel);
            // 
            // gbFiltersHotels
            // 
            this.gbFiltersHotels.Controls.Add(this.imgCleanFiltersHotels);
            this.gbFiltersHotels.Controls.Add(this.lblCity);
            this.gbFiltersHotels.Controls.Add(this.cbCity);
            this.gbFiltersHotels.Location = new System.Drawing.Point(106, 24);
            this.gbFiltersHotels.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiltersHotels.Name = "gbFiltersHotels";
            this.gbFiltersHotels.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltersHotels.Size = new System.Drawing.Size(560, 64);
            this.gbFiltersHotels.TabIndex = 0;
            this.gbFiltersHotels.TabStop = false;
            this.gbFiltersHotels.Text = "Filtros";
            // 
            // imgCleanFiltersHotels
            // 
            this.imgCleanFiltersHotels.BackColor = System.Drawing.Color.Transparent;
            this.imgCleanFiltersHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCleanFiltersHotels.Image = global::HappyHollidays.Properties.Resources.ic_remove_filters;
            this.imgCleanFiltersHotels.Location = new System.Drawing.Point(65, 21);
            this.imgCleanFiltersHotels.Name = "imgCleanFiltersHotels";
            this.imgCleanFiltersHotels.Size = new System.Drawing.Size(34, 28);
            this.imgCleanFiltersHotels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCleanFiltersHotels.TabIndex = 6;
            this.imgCleanFiltersHotels.TabStop = false;
            this.imgCleanFiltersHotels.Click += new System.EventHandler(this.imgCleanFiltersHotels_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(141, 26);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 18);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Ciudad";
            // 
            // cbCity
            // 
            this.cbCity.DataSource = this.bsCities;
            this.cbCity.DisplayMember = "nombre";
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(210, 23);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(178, 26);
            this.cbCity.TabIndex = 0;
            this.cbCity.ValueMember = "id_ciudad";
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // bsCities
            // 
            this.bsCities.DataSource = typeof(HappyHollidays.Models.ciudades);
            // 
            // FormActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 561);
            this.Controls.Add(this.gbHotels);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.gbActivities);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormActivities";
            this.Text = "FormActivities";
            this.Load += new System.EventHandler(this.FormActivities_Load);
            this.gbActivities.ResumeLayout(false);
            this.gbActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivities)).EndInit();
            this.gbHotels.ResumeLayout(false);
            this.gbHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivitiesInHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivitiesInHotel)).EndInit();
            this.gbFiltersHotels.ResumeLayout(false);
            this.gbFiltersHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.GroupBox gbActivities;
        private System.Windows.Forms.TextBox tbFindActivity;
        private System.Windows.Forms.Label lblFindActivity;
        private System.Windows.Forms.GroupBox gbHotels;
        private System.Windows.Forms.TextBox tbFindHotel;
        private System.Windows.Forms.Label lblFindHotel;
        private System.Windows.Forms.DataGridView dgvActivitiesInHotel;
        private System.Windows.Forms.GroupBox gbFiltersHotels;
        private System.Windows.Forms.PictureBox imgCleanFiltersHotels;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.PictureBox imgFindActivity;
        private System.Windows.Forms.PictureBox imgFindHotel;
        private System.Windows.Forms.BindingSource bsActivities;
        private System.Windows.Forms.BindingSource bsCities;
        private System.Windows.Forms.ListBox lbActivities;
        private System.Windows.Forms.BindingSource bsActivitiesInHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadDataGridViewTextBoxColumn;
    }
}