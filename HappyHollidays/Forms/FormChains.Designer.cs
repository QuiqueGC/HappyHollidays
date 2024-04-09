namespace HappyHollidays.Forms
{
    partial class FormChains
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
            this.gbChains = new System.Windows.Forms.GroupBox();
            this.imgFindChain = new System.Windows.Forms.PictureBox();
            this.tbFindChain = new System.Windows.Forms.TextBox();
            this.dgvChains = new System.Windows.Forms.DataGridView();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirfisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsChains = new System.Windows.Forms.BindingSource(this.components);
            this.lblFindChain = new System.Windows.Forms.Label();
            this.btnAddChain = new System.Windows.Forms.Button();
            this.gbFiltersHotels = new System.Windows.Forms.GroupBox();
            this.imgCleanFiltersHotels = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.bsCities = new System.Windows.Forms.BindingSource(this.components);
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dgvHotels = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHotels = new System.Windows.Forms.BindingSource(this.components);
            this.lblFindHotel = new System.Windows.Forms.Label();
            this.tbFindHotel = new System.Windows.Forms.TextBox();
            this.gbHotels = new System.Windows.Forms.GroupBox();
            this.imgFindHotel = new System.Windows.Forms.PictureBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbChains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindChain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChains)).BeginInit();
            this.gbFiltersHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotels)).BeginInit();
            this.gbHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChains
            // 
            this.gbChains.BackColor = System.Drawing.Color.SeaGreen;
            this.gbChains.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbChains.Controls.Add(this.imgFindChain);
            this.gbChains.Controls.Add(this.tbFindChain);
            this.gbChains.Controls.Add(this.dgvChains);
            this.gbChains.Controls.Add(this.lblFindChain);
            this.gbChains.Location = new System.Drawing.Point(12, 12);
            this.gbChains.Name = "gbChains";
            this.gbChains.Size = new System.Drawing.Size(456, 458);
            this.gbChains.TabIndex = 0;
            this.gbChains.TabStop = false;
            this.gbChains.Text = "Cadenas";
            // 
            // imgFindChain
            // 
            this.imgFindChain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindChain.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindChain.Location = new System.Drawing.Point(365, 18);
            this.imgFindChain.Name = "imgFindChain";
            this.imgFindChain.Size = new System.Drawing.Size(50, 43);
            this.imgFindChain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindChain.TabIndex = 6;
            this.imgFindChain.TabStop = false;
            this.imgFindChain.Click += new System.EventHandler(this.imgFindChain_Click);
            // 
            // tbFindChain
            // 
            this.tbFindChain.Location = new System.Drawing.Point(101, 26);
            this.tbFindChain.Name = "tbFindChain";
            this.tbFindChain.Size = new System.Drawing.Size(244, 23);
            this.tbFindChain.TabIndex = 1;
            this.tbFindChain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindChain_KeyDown);
            // 
            // dgvChains
            // 
            this.dgvChains.AllowUserToAddRows = false;
            this.dgvChains.AllowUserToDeleteRows = false;
            this.dgvChains.AllowUserToResizeRows = false;
            this.dgvChains.AutoGenerateColumns = false;
            this.dgvChains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cifDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.dirfisDataGridViewTextBoxColumn});
            this.dgvChains.DataSource = this.bsChains;
            this.dgvChains.Location = new System.Drawing.Point(6, 68);
            this.dgvChains.MultiSelect = false;
            this.dgvChains.Name = "dgvChains";
            this.dgvChains.ReadOnly = true;
            this.dgvChains.RowHeadersVisible = false;
            this.dgvChains.RowHeadersWidth = 51;
            this.dgvChains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChains.Size = new System.Drawing.Size(444, 384);
            this.dgvChains.StandardTab = true;
            this.dgvChains.TabIndex = 2;
            this.dgvChains.SelectionChanged += new System.EventHandler(this.dgvChains_SelectionChanged);
            this.dgvChains.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvChains_KeyDown);
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.FillWeight = 50F;
            this.cifDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cifDataGridViewTextBoxColumn.MaxInputLength = 9;
            this.cifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 50F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirfisDataGridViewTextBoxColumn
            // 
            this.dirfisDataGridViewTextBoxColumn.DataPropertyName = "dir_fis";
            this.dirfisDataGridViewTextBoxColumn.HeaderText = "Dirección fiscal";
            this.dirfisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dirfisDataGridViewTextBoxColumn.Name = "dirfisDataGridViewTextBoxColumn";
            this.dirfisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsChains
            // 
            this.bsChains.DataSource = typeof(HappyHollidays.Models.cadenas);
            // 
            // lblFindChain
            // 
            this.lblFindChain.AutoSize = true;
            this.lblFindChain.Location = new System.Drawing.Point(32, 29);
            this.lblFindChain.Name = "lblFindChain";
            this.lblFindChain.Size = new System.Drawing.Size(49, 18);
            this.lblFindChain.TabIndex = 4;
            this.lblFindChain.Text = "Buscar";
            // 
            // btnAddChain
            // 
            this.btnAddChain.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddChain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddChain.Location = new System.Drawing.Point(331, 485);
            this.btnAddChain.Name = "btnAddChain";
            this.btnAddChain.Size = new System.Drawing.Size(137, 34);
            this.btnAddChain.TabIndex = 3;
            this.btnAddChain.Text = "Añadir cadena";
            this.btnAddChain.UseVisualStyleBackColor = false;
            this.btnAddChain.Click += new System.EventHandler(this.btnAddChain_Click);
            // 
            // gbFiltersHotels
            // 
            this.gbFiltersHotels.Controls.Add(this.imgCleanFiltersHotels);
            this.gbFiltersHotels.Controls.Add(this.lblCategory);
            this.gbFiltersHotels.Controls.Add(this.lblCity);
            this.gbFiltersHotels.Controls.Add(this.cbCity);
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
            this.lblCategory.Location = new System.Drawing.Point(383, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 18);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Categoría";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(67, 26);
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
            this.cbCity.Location = new System.Drawing.Point(136, 23);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(160, 26);
            this.cbCity.TabIndex = 0;
            this.cbCity.ValueMember = "id_ciudad";
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // bsCities
            // 
            this.bsCities.DataSource = typeof(HappyHollidays.Models.ciudades);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCategory.Location = new System.Drawing.Point(472, 23);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(58, 26);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
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
            this.nombreDataGridViewTextBoxColumn1,
            this.categoria,
            this.tipoDataGridViewTextBoxColumn,
            this.direccion,
            this.telefonoDataGridViewTextBoxColumn,
            this.id_ciudad});
            this.dgvHotels.DataSource = this.bsHotels;
            this.dgvHotels.Location = new System.Drawing.Point(7, 151);
            this.dgvHotels.MultiSelect = false;
            this.dgvHotels.Name = "dgvHotels";
            this.dgvHotels.ReadOnly = true;
            this.dgvHotels.RowHeadersVisible = false;
            this.dgvHotels.RowHeadersWidth = 51;
            this.dgvHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHotels.Size = new System.Drawing.Size(637, 349);
            this.dgvHotels.StandardTab = true;
            this.dgvHotels.TabIndex = 3;
            this.dgvHotels.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHotels_CellFormatting);
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.FillWeight = 50F;
            this.categoria.HeaderText = "Categoría";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_ciudad
            // 
            this.id_ciudad.DataPropertyName = "id_ciudad";
            this.id_ciudad.FillWeight = 50F;
            this.id_ciudad.HeaderText = "Ciudad";
            this.id_ciudad.MinimumWidth = 6;
            this.id_ciudad.Name = "id_ciudad";
            this.id_ciudad.ReadOnly = true;
            // 
            // bsHotels
            // 
            this.bsHotels.DataSource = typeof(HappyHollidays.Models.hoteles);
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
            // tbFindHotel
            // 
            this.tbFindHotel.Location = new System.Drawing.Point(191, 107);
            this.tbFindHotel.Name = "tbFindHotel";
            this.tbFindHotel.Size = new System.Drawing.Size(330, 23);
            this.tbFindHotel.TabIndex = 2;
            this.tbFindHotel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindHotel_KeyDown);
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
            this.gbHotels.Location = new System.Drawing.Point(475, 12);
            this.gbHotels.Margin = new System.Windows.Forms.Padding(4);
            this.gbHotels.Name = "gbHotels";
            this.gbHotels.Padding = new System.Windows.Forms.Padding(4);
            this.gbHotels.Size = new System.Drawing.Size(651, 507);
            this.gbHotels.TabIndex = 4;
            this.gbHotels.TabStop = false;
            this.gbHotels.Text = "Lista de hoteles pertenecientes a la cadena seleccionada";
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
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Location = new System.Drawing.Point(163, 485);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(158, 34);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modificar cadena";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(12, 485);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Borrar cadena";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FormChains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 561);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddChain);
            this.Controls.Add(this.gbHotels);
            this.Controls.Add(this.gbChains);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormChains";
            this.Text = "FormChains";
            this.Load += new System.EventHandler(this.FormChains_Load);
            this.gbChains.ResumeLayout(false);
            this.gbChains.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindChain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChains)).EndInit();
            this.gbFiltersHotels.ResumeLayout(false);
            this.gbFiltersHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotels)).EndInit();
            this.gbHotels.ResumeLayout(false);
            this.gbHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChains;
        private System.Windows.Forms.TextBox tbFindChain;
        private System.Windows.Forms.DataGridView dgvChains;
        private System.Windows.Forms.Label lblFindChain;
        private System.Windows.Forms.Button btnAddChain;
        private System.Windows.Forms.GroupBox gbFiltersHotels;
        private System.Windows.Forms.PictureBox imgCleanFiltersHotels;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dgvHotels;
        private System.Windows.Forms.Label lblFindHotel;
        private System.Windows.Forms.TextBox tbFindHotel;
        private System.Windows.Forms.GroupBox gbHotels;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox imgFindChain;
        private System.Windows.Forms.PictureBox imgFindHotel;
        private System.Windows.Forms.BindingSource bsChains;
        private System.Windows.Forms.BindingSource bsHotels;
        private System.Windows.Forms.BindingSource bsCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirfisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ciudad;
    }
}