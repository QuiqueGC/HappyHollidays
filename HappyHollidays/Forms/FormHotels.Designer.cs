namespace HappyHollidays.Forms
{
    partial class FormHotels
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
            this.gbHotels = new System.Windows.Forms.GroupBox();
            this.imgFindHotel = new System.Windows.Forms.PictureBox();
            this.tbFindHotel = new System.Windows.Forms.TextBox();
            this.lblFindHotel = new System.Windows.Forms.Label();
            this.dgvHotels = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHotels = new System.Windows.Forms.BindingSource(this.components);
            this.gbFiltersHotels = new System.Windows.Forms.GroupBox();
            this.imgCleanFiltersHotels = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.bsCities = new System.Windows.Forms.BindingSource(this.components);
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgFindActivity = new System.Windows.Forms.PictureBox();
            this.tbFindActivity = new System.Windows.Forms.TextBox();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.idactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsActivitiesInHotel = new System.Windows.Forms.BindingSource(this.components);
            this.lblFindActivity = new System.Windows.Forms.Label();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.btnModifyHotel = new System.Windows.Forms.Button();
            this.btnDeleteHotel = new System.Windows.Forms.Button();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.gbHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotels)).BeginInit();
            this.gbFiltersHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivitiesInHotel)).BeginInit();
            this.SuspendLayout();
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
            this.gbHotels.Location = new System.Drawing.Point(16, 17);
            this.gbHotels.Margin = new System.Windows.Forms.Padding(4);
            this.gbHotels.Name = "gbHotels";
            this.gbHotels.Padding = new System.Windows.Forms.Padding(4);
            this.gbHotels.Size = new System.Drawing.Size(789, 458);
            this.gbHotels.TabIndex = 0;
            this.gbHotels.TabStop = false;
            this.gbHotels.Text = "Lista de Hoteles";
            // 
            // imgFindHotel
            // 
            this.imgFindHotel.BackColor = System.Drawing.Color.Transparent;
            this.imgFindHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindHotel.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindHotel.Location = new System.Drawing.Point(589, 98);
            this.imgFindHotel.Name = "imgFindHotel";
            this.imgFindHotel.Size = new System.Drawing.Size(50, 43);
            this.imgFindHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindHotel.TabIndex = 6;
            this.imgFindHotel.TabStop = false;
            this.imgFindHotel.Click += new System.EventHandler(this.imgFindHotel_Click);
            // 
            // tbFindHotel
            // 
            this.tbFindHotel.Location = new System.Drawing.Point(243, 106);
            this.tbFindHotel.Name = "tbFindHotel";
            this.tbFindHotel.Size = new System.Drawing.Size(330, 23);
            this.tbFindHotel.TabIndex = 1;
            this.tbFindHotel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindHotel_KeyDown);
            // 
            // lblFindHotel
            // 
            this.lblFindHotel.AutoSize = true;
            this.lblFindHotel.BackColor = System.Drawing.Color.Transparent;
            this.lblFindHotel.Location = new System.Drawing.Point(174, 109);
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
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.idciudadDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn});
            this.dgvHotels.DataSource = this.bsHotels;
            this.dgvHotels.Location = new System.Drawing.Point(7, 151);
            this.dgvHotels.MultiSelect = false;
            this.dgvHotels.Name = "dgvHotels";
            this.dgvHotels.ReadOnly = true;
            this.dgvHotels.RowHeadersVisible = false;
            this.dgvHotels.RowHeadersWidth = 51;
            this.dgvHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHotels.Size = new System.Drawing.Size(774, 300);
            this.dgvHotels.TabIndex = 2;
            this.dgvHotels.TabStop = false;
            this.dgvHotels.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHotels_CellFormatting);
            this.dgvHotels.SelectionChanged += new System.EventHandler(this.dgvHotels_SelectionChanged);
            this.dgvHotels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvHotels_KeyDown);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.FillWeight = 50F;
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idciudadDataGridViewTextBoxColumn
            // 
            this.idciudadDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.idciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.idciudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idciudadDataGridViewTextBoxColumn.Name = "idciudadDataGridViewTextBoxColumn";
            this.idciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.FillWeight = 87.05584F;
            this.cifDataGridViewTextBoxColumn.HeaderText = "Cadena";
            this.cifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsHotels
            // 
            this.bsHotels.DataSource = typeof(HappyHollidays.Models.hoteles);
            // 
            // gbFiltersHotels
            // 
            this.gbFiltersHotels.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltersHotels.Controls.Add(this.imgCleanFiltersHotels);
            this.gbFiltersHotels.Controls.Add(this.lblType);
            this.gbFiltersHotels.Controls.Add(this.cbType);
            this.gbFiltersHotels.Controls.Add(this.lblCategory);
            this.gbFiltersHotels.Controls.Add(this.lblCity);
            this.gbFiltersHotels.Controls.Add(this.cbCity);
            this.gbFiltersHotels.Controls.Add(this.cbCategory);
            this.gbFiltersHotels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbFiltersHotels.Location = new System.Drawing.Point(9, 24);
            this.gbFiltersHotels.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiltersHotels.Name = "gbFiltersHotels";
            this.gbFiltersHotels.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltersHotels.Size = new System.Drawing.Size(772, 64);
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(350, 26);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 18);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Tipo";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Playa",
            "Montaña",
            "Ciudad",
            "Rural"});
            this.cbType.Location = new System.Drawing.Point(399, 22);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(165, 26);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(606, 26);
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
            this.cbCategory.Location = new System.Drawing.Point(695, 22);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(58, 26);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.imgFindActivity);
            this.groupBox1.Controls.Add(this.tbFindActivity);
            this.groupBox1.Controls.Add(this.dgvActivities);
            this.groupBox1.Controls.Add(this.lblFindActivity);
            this.groupBox1.Location = new System.Drawing.Point(824, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 443);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividades en el hotel seleccionado";
            // 
            // imgFindActivity
            // 
            this.imgFindActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindActivity.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindActivity.Location = new System.Drawing.Point(246, 37);
            this.imgFindActivity.Name = "imgFindActivity";
            this.imgFindActivity.Size = new System.Drawing.Size(50, 43);
            this.imgFindActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindActivity.TabIndex = 7;
            this.imgFindActivity.TabStop = false;
            this.imgFindActivity.Click += new System.EventHandler(this.imgFindActivity_Click);
            // 
            // tbFindActivity
            // 
            this.tbFindActivity.Location = new System.Drawing.Point(79, 45);
            this.tbFindActivity.Name = "tbFindActivity";
            this.tbFindActivity.Size = new System.Drawing.Size(164, 23);
            this.tbFindActivity.TabIndex = 1;
            this.tbFindActivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindActivity_KeyDown);
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.AllowUserToResizeRows = false;
            this.dgvActivities.AutoGenerateColumns = false;
            this.dgvActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idactDataGridViewTextBoxColumn,
            this.grado});
            this.dgvActivities.DataSource = this.bsActivitiesInHotel;
            this.dgvActivities.Location = new System.Drawing.Point(6, 86);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.RowHeadersVisible = false;
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(300, 351);
            this.dgvActivities.TabIndex = 2;
            this.dgvActivities.TabStop = false;
            this.dgvActivities.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActivities_CellFormatting);
            // 
            // idactDataGridViewTextBoxColumn
            // 
            this.idactDataGridViewTextBoxColumn.DataPropertyName = "id_act";
            this.idactDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.idactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idactDataGridViewTextBoxColumn.Name = "idactDataGridViewTextBoxColumn";
            this.idactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grado
            // 
            this.grado.DataPropertyName = "grado";
            this.grado.FillWeight = 50F;
            this.grado.HeaderText = "Grado";
            this.grado.MinimumWidth = 6;
            this.grado.Name = "grado";
            this.grado.ReadOnly = true;
            // 
            // bsActivitiesInHotel
            // 
            this.bsActivitiesInHotel.DataSource = typeof(HappyHollidays.Models.act_hotel);
            // 
            // lblFindActivity
            // 
            this.lblFindActivity.AutoSize = true;
            this.lblFindActivity.Location = new System.Drawing.Point(13, 48);
            this.lblFindActivity.Name = "lblFindActivity";
            this.lblFindActivity.Size = new System.Drawing.Size(49, 18);
            this.lblFindActivity.TabIndex = 4;
            this.lblFindActivity.Text = "Buscar";
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHotel.Location = new System.Drawing.Point(574, 482);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(231, 34);
            this.btnAddHotel.TabIndex = 3;
            this.btnAddHotel.Text = "Añadir hotel";
            this.btnAddHotel.UseVisualStyleBackColor = false;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddActivity.Location = new System.Drawing.Point(973, 466);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(163, 50);
            this.btnAddActivity.TabIndex = 6;
            this.btnAddActivity.Text = "Añadir actividad al hotel";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // btnModifyHotel
            // 
            this.btnModifyHotel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModifyHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyHotel.Location = new System.Drawing.Point(275, 482);
            this.btnModifyHotel.Name = "btnModifyHotel";
            this.btnModifyHotel.Size = new System.Drawing.Size(228, 34);
            this.btnModifyHotel.TabIndex = 2;
            this.btnModifyHotel.Text = "Modificar hotel seleccionado";
            this.btnModifyHotel.UseVisualStyleBackColor = false;
            this.btnModifyHotel.Click += new System.EventHandler(this.btnModifyHotel_Click);
            // 
            // btnDeleteHotel
            // 
            this.btnDeleteHotel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteHotel.Location = new System.Drawing.Point(16, 482);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(184, 34);
            this.btnDeleteHotel.TabIndex = 1;
            this.btnDeleteHotel.Text = "Borrar hotel seleccionado";
            this.btnDeleteHotel.UseVisualStyleBackColor = false;
            this.btnDeleteHotel.Click += new System.EventHandler(this.btnDeleteHotel_Click);
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteActivity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteActivity.Location = new System.Drawing.Point(824, 466);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(143, 50);
            this.btnDeleteActivity.TabIndex = 5;
            this.btnDeleteActivity.Text = "Borrar actividad seleccionada";
            this.btnDeleteActivity.UseVisualStyleBackColor = false;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // FormHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 561);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnDeleteHotel);
            this.Controls.Add(this.btnModifyHotel);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.btnAddHotel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHotels);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHotels";
            this.Text = "FormHotels";
            this.Load += new System.EventHandler(this.FormHotels_Load);
            this.gbHotels.ResumeLayout(false);
            this.gbHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotels)).EndInit();
            this.gbFiltersHotels.ResumeLayout(false);
            this.gbFiltersHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCleanFiltersHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivitiesInHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHotels;
        private System.Windows.Forms.GroupBox gbFiltersHotels;
        private System.Windows.Forms.TextBox tbFindHotel;
        private System.Windows.Forms.Label lblFindHotel;
        private System.Windows.Forms.DataGridView dgvHotels;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFindActivity;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.Label lblFindActivity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Button btnModifyHotel;
        private System.Windows.Forms.Button btnDeleteHotel;
        private System.Windows.Forms.PictureBox imgCleanFiltersHotels;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.PictureBox imgFindHotel;
        private System.Windows.Forms.PictureBox imgFindActivity;
        private System.Windows.Forms.BindingSource bsHotels;
        private System.Windows.Forms.BindingSource bsActivitiesInHotel;
        private System.Windows.Forms.BindingSource bsCities;
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grado;
    }
}