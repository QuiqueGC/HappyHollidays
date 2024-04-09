namespace HappyHollidays.Forms
{
    partial class FormCities
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
            this.btnAddCity = new System.Windows.Forms.Button();
            this.gbCities = new System.Windows.Forms.GroupBox();
            this.imgFindCity = new System.Windows.Forms.PictureBox();
            this.lbCities = new System.Windows.Forms.ListBox();
            this.bsCities = new System.Windows.Forms.BindingSource(this.components);
            this.tbFindCity = new System.Windows.Forms.TextBox();
            this.lblFindCity = new System.Windows.Forms.Label();
            this.gbHotels = new System.Windows.Forms.GroupBox();
            this.imgFindHotel = new System.Windows.Forms.PictureBox();
            this.tbFindHotel = new System.Windows.Forms.TextBox();
            this.lblFindHotel = new System.Windows.Forms.Label();
            this.dgvHotels = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHotels = new System.Windows.Forms.BindingSource(this.components);
            this.gbFiltersHotels = new System.Windows.Forms.GroupBox();
            this.cbChain = new System.Windows.Forms.ComboBox();
            this.bsChains = new System.Windows.Forms.BindingSource(this.components);
            this.imgCleanFiltersHotels = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblChain = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).BeginInit();
            this.gbHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotels)).BeginInit();
            this.gbFiltersHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsChains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCity.Location = new System.Drawing.Point(318, 476);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(131, 34);
            this.btnAddCity.TabIndex = 3;
            this.btnAddCity.Text = "Añadir ciudad";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // gbCities
            // 
            this.gbCities.BackColor = System.Drawing.Color.SeaGreen;
            this.gbCities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbCities.Controls.Add(this.imgFindCity);
            this.gbCities.Controls.Add(this.lbCities);
            this.gbCities.Controls.Add(this.tbFindCity);
            this.gbCities.Controls.Add(this.lblFindCity);
            this.gbCities.Location = new System.Drawing.Point(12, 12);
            this.gbCities.Name = "gbCities";
            this.gbCities.Size = new System.Drawing.Size(437, 458);
            this.gbCities.TabIndex = 0;
            this.gbCities.TabStop = false;
            this.gbCities.Text = "Ciudades";
            // 
            // imgFindCity
            // 
            this.imgFindCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindCity.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindCity.Location = new System.Drawing.Point(371, 16);
            this.imgFindCity.Name = "imgFindCity";
            this.imgFindCity.Size = new System.Drawing.Size(50, 43);
            this.imgFindCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindCity.TabIndex = 6;
            this.imgFindCity.TabStop = false;
            this.imgFindCity.Click += new System.EventHandler(this.imgFindCity_Click);
            // 
            // lbCities
            // 
            this.lbCities.DataSource = this.bsCities;
            this.lbCities.DisplayMember = "nombre";
            this.lbCities.FormattingEnabled = true;
            this.lbCities.ItemHeight = 18;
            this.lbCities.Location = new System.Drawing.Point(6, 70);
            this.lbCities.Name = "lbCities";
            this.lbCities.Size = new System.Drawing.Size(425, 382);
            this.lbCities.TabIndex = 1;
            this.lbCities.TabStop = false;
            this.lbCities.ValueMember = "id_ciudad";
            this.lbCities.SelectedIndexChanged += new System.EventHandler(this.lbCities_SelectedIndexChanged);
            this.lbCities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbCities_KeyDown);
            // 
            // bsCities
            // 
            this.bsCities.DataSource = typeof(HappyHollidays.Models.ciudades);
            // 
            // tbFindCity
            // 
            this.tbFindCity.Location = new System.Drawing.Point(117, 23);
            this.tbFindCity.Name = "tbFindCity";
            this.tbFindCity.Size = new System.Drawing.Size(244, 23);
            this.tbFindCity.TabIndex = 0;
            this.tbFindCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindCity_KeyDown);
            // 
            // lblFindCity
            // 
            this.lblFindCity.AutoSize = true;
            this.lblFindCity.Location = new System.Drawing.Point(48, 26);
            this.lblFindCity.Name = "lblFindCity";
            this.lblFindCity.Size = new System.Drawing.Size(49, 18);
            this.lblFindCity.TabIndex = 4;
            this.lblFindCity.Text = "Buscar";
            // 
            // gbHotels
            // 
            this.gbHotels.BackColor = System.Drawing.Color.SeaGreen;
            this.gbHotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbHotels.Controls.Add(this.imgFindHotel);
            this.gbHotels.Controls.Add(this.tbFindHotel);
            this.gbHotels.Controls.Add(this.lblFindHotel);
            this.gbHotels.Controls.Add(this.dgvHotels);
            this.gbHotels.Controls.Add(this.gbFiltersHotels);
            this.gbHotels.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbHotels.Location = new System.Drawing.Point(473, 12);
            this.gbHotels.Margin = new System.Windows.Forms.Padding(4);
            this.gbHotels.Name = "gbHotels";
            this.gbHotels.Padding = new System.Windows.Forms.Padding(4);
            this.gbHotels.Size = new System.Drawing.Size(662, 498);
            this.gbHotels.TabIndex = 4;
            this.gbHotels.TabStop = false;
            this.gbHotels.Text = "Lista de hoteles en la ciudad seleccionada";
            // 
            // imgFindHotel
            // 
            this.imgFindHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindHotel.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindHotel.Location = new System.Drawing.Point(532, 98);
            this.imgFindHotel.Name = "imgFindHotel";
            this.imgFindHotel.Size = new System.Drawing.Size(50, 43);
            this.imgFindHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindHotel.TabIndex = 7;
            this.imgFindHotel.TabStop = false;
            this.imgFindHotel.Click += new System.EventHandler(this.imgFindHotel_Click);
            // 
            // tbFindHotel
            // 
            this.tbFindHotel.Location = new System.Drawing.Point(191, 107);
            this.tbFindHotel.Name = "tbFindHotel";
            this.tbFindHotel.Size = new System.Drawing.Size(330, 23);
            this.tbFindHotel.TabIndex = 1;
            this.tbFindHotel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindHotel_KeyDown);
            // 
            // lblFindHotel
            // 
            this.lblFindHotel.AutoSize = true;
            this.lblFindHotel.Location = new System.Drawing.Point(122, 110);
            this.lblFindHotel.Name = "lblFindHotel";
            this.lblFindHotel.Size = new System.Drawing.Size(49, 18);
            this.lblFindHotel.TabIndex = 2;
            this.lblFindHotel.Text = "Buscar";
            // 
            // dgvHotels
            // 
            this.dgvHotels.AllowUserToAddRows = false;
            this.dgvHotels.AllowUserToDeleteRows = false;
            this.dgvHotels.AllowUserToResizeRows = false;
            this.dgvHotels.AutoGenerateColumns = false;
            this.dgvHotels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dgvHotels.DataSource = this.bsHotels;
            this.dgvHotels.Location = new System.Drawing.Point(7, 151);
            this.dgvHotels.MultiSelect = false;
            this.dgvHotels.Name = "dgvHotels";
            this.dgvHotels.ReadOnly = true;
            this.dgvHotels.RowHeadersVisible = false;
            this.dgvHotels.RowHeadersWidth = 51;
            this.dgvHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHotels.Size = new System.Drawing.Size(648, 340);
            this.dgvHotels.TabIndex = 2;
            this.dgvHotels.TabStop = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.FillWeight = 50F;
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsHotels
            // 
            this.bsHotels.DataSource = typeof(HappyHollidays.Models.hoteles);
            // 
            // gbFiltersHotels
            // 
            this.gbFiltersHotels.Controls.Add(this.cbChain);
            this.gbFiltersHotels.Controls.Add(this.imgCleanFiltersHotels);
            this.gbFiltersHotels.Controls.Add(this.lblCategory);
            this.gbFiltersHotels.Controls.Add(this.lblChain);
            this.gbFiltersHotels.Controls.Add(this.cbCategory);
            this.gbFiltersHotels.Location = new System.Drawing.Point(52, 26);
            this.gbFiltersHotels.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiltersHotels.Name = "gbFiltersHotels";
            this.gbFiltersHotels.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltersHotels.Size = new System.Drawing.Size(564, 64);
            this.gbFiltersHotels.TabIndex = 0;
            this.gbFiltersHotels.TabStop = false;
            this.gbFiltersHotels.Text = "Filtros";
            // 
            // cbChain
            // 
            this.cbChain.DataSource = this.bsChains;
            this.cbChain.DisplayMember = "nombre";
            this.cbChain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChain.FormattingEnabled = true;
            this.cbChain.Location = new System.Drawing.Point(127, 23);
            this.cbChain.Name = "cbChain";
            this.cbChain.Size = new System.Drawing.Size(180, 26);
            this.cbChain.TabIndex = 7;
            this.cbChain.ValueMember = "cif";
            // 
            // bsChains
            // 
            this.bsChains.DataSource = typeof(HappyHollidays.Models.cadenas);
            // 
            // imgCleanFiltersHotels
            // 
            this.imgCleanFiltersHotels.BackColor = System.Drawing.Color.Transparent;
            this.imgCleanFiltersHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCleanFiltersHotels.Image = global::HappyHollidays.Properties.Resources.ic_remove_filters;
            this.imgCleanFiltersHotels.Location = new System.Drawing.Point(18, 25);
            this.imgCleanFiltersHotels.Name = "imgCleanFiltersHotels";
            this.imgCleanFiltersHotels.Size = new System.Drawing.Size(34, 28);
            this.imgCleanFiltersHotels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCleanFiltersHotels.TabIndex = 6;
            this.imgCleanFiltersHotels.TabStop = false;
            this.imgCleanFiltersHotels.Click += new System.EventHandler(this.imgCleanFiltersHotels_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(383, 27);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 18);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Categoría";
            // 
            // lblChain
            // 
            this.lblChain.AutoSize = true;
            this.lblChain.Location = new System.Drawing.Point(67, 26);
            this.lblChain.Name = "lblChain";
            this.lblChain.Size = new System.Drawing.Size(54, 18);
            this.lblChain.TabIndex = 2;
            this.lblChain.Text = "Cadena";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCategory.Location = new System.Drawing.Point(472, 23);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(58, 26);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbChain_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(186, 476);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Borrar ciudad";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbHotels);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.gbCities);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCities";
            this.Text = "FormCities";
            this.Load += new System.EventHandler(this.FormCities_Load);
            this.gbCities.ResumeLayout(false);
            this.gbCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).EndInit();
            this.gbHotels.ResumeLayout(false);
            this.gbHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotels)).EndInit();
            this.gbFiltersHotels.ResumeLayout(false);
            this.gbFiltersHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsChains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.GroupBox gbCities;
        private System.Windows.Forms.TextBox tbFindCity;
        private System.Windows.Forms.Label lblFindCity;
        private System.Windows.Forms.ListBox lbCities;
        private System.Windows.Forms.GroupBox gbHotels;
        private System.Windows.Forms.TextBox tbFindHotel;
        private System.Windows.Forms.Label lblFindHotel;
        private System.Windows.Forms.DataGridView dgvHotels;
        private System.Windows.Forms.GroupBox gbFiltersHotels;
        private System.Windows.Forms.PictureBox imgCleanFiltersHotels;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblChain;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox imgFindCity;
        private System.Windows.Forms.PictureBox imgFindHotel;
        private System.Windows.Forms.BindingSource bsCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsHotels;
        private System.Windows.Forms.BindingSource bsChains;
        private System.Windows.Forms.ComboBox cbChain;
    }
}