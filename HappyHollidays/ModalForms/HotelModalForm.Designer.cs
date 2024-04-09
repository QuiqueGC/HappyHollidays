namespace HappyHollidays.Dialogs
{
    partial class HotelModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelModalForm));
            this.gbData = new System.Windows.Forms.GroupBox();
            this.imgCancel = new System.Windows.Forms.PictureBox();
            this.rbRural = new System.Windows.Forms.RadioButton();
            this.rbCity = new System.Windows.Forms.RadioButton();
            this.rbMountain = new System.Windows.Forms.RadioButton();
            this.rbBeach = new System.Windows.Forms.RadioButton();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbChain = new System.Windows.Forms.ComboBox();
            this.imgStar5 = new System.Windows.Forms.PictureBox();
            this.imgStar4 = new System.Windows.Forms.PictureBox();
            this.imgStar3 = new System.Windows.Forms.PictureBox();
            this.imgStar2 = new System.Windows.Forms.PictureBox();
            this.imgStar1 = new System.Windows.Forms.PictureBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblChain = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.bsCities = new System.Windows.Forms.BindingSource(this.components);
            this.bsChain = new System.Windows.Forms.BindingSource(this.components);
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChain)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.Color.Transparent;
            this.gbData.Controls.Add(this.imgCancel);
            this.gbData.Controls.Add(this.rbRural);
            this.gbData.Controls.Add(this.rbCity);
            this.gbData.Controls.Add(this.rbMountain);
            this.gbData.Controls.Add(this.rbBeach);
            this.gbData.Controls.Add(this.cbCity);
            this.gbData.Controls.Add(this.cbChain);
            this.gbData.Controls.Add(this.imgStar5);
            this.gbData.Controls.Add(this.imgStar4);
            this.gbData.Controls.Add(this.imgStar3);
            this.gbData.Controls.Add(this.imgStar2);
            this.gbData.Controls.Add(this.imgStar1);
            this.gbData.Controls.Add(this.tbPhone);
            this.gbData.Controls.Add(this.lblChain);
            this.gbData.Controls.Add(this.lblCity);
            this.gbData.Controls.Add(this.lblType);
            this.gbData.Controls.Add(this.lblPhone);
            this.gbData.Controls.Add(this.tbAddress);
            this.gbData.Controls.Add(this.tbName);
            this.gbData.Controls.Add(this.lblAddress);
            this.gbData.Controls.Add(this.lblCategory);
            this.gbData.Controls.Add(this.lblName);
            this.gbData.Location = new System.Drawing.Point(7, 29);
            this.gbData.Margin = new System.Windows.Forms.Padding(4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4);
            this.gbData.Size = new System.Drawing.Size(550, 368);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos";
            // 
            // imgCancel
            // 
            this.imgCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCancel.Image = global::HappyHollidays.Properties.Resources.icon_cancel;
            this.imgCancel.Location = new System.Drawing.Point(149, 86);
            this.imgCancel.Name = "imgCancel";
            this.imgCancel.Size = new System.Drawing.Size(34, 29);
            this.imgCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCancel.TabIndex = 16;
            this.imgCancel.TabStop = false;
            this.imgCancel.Click += new System.EventHandler(this.imgCancel_Click);
            // 
            // rbRural
            // 
            this.rbRural.AutoSize = true;
            this.rbRural.Location = new System.Drawing.Point(461, 227);
            this.rbRural.Name = "rbRural";
            this.rbRural.Size = new System.Drawing.Size(75, 26);
            this.rbRural.TabIndex = 6;
            this.rbRural.TabStop = true;
            this.rbRural.Text = "Rural";
            this.rbRural.UseVisualStyleBackColor = true;
            this.rbRural.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbBeach_KeyDown);
            // 
            // rbCity
            // 
            this.rbCity.AutoSize = true;
            this.rbCity.Location = new System.Drawing.Point(354, 227);
            this.rbCity.Name = "rbCity";
            this.rbCity.Size = new System.Drawing.Size(88, 26);
            this.rbCity.TabIndex = 5;
            this.rbCity.TabStop = true;
            this.rbCity.Text = "Ciudad";
            this.rbCity.UseVisualStyleBackColor = true;
            this.rbCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbBeach_KeyDown);
            // 
            // rbMountain
            // 
            this.rbMountain.AutoSize = true;
            this.rbMountain.Location = new System.Drawing.Point(233, 227);
            this.rbMountain.Name = "rbMountain";
            this.rbMountain.Size = new System.Drawing.Size(101, 26);
            this.rbMountain.TabIndex = 4;
            this.rbMountain.TabStop = true;
            this.rbMountain.Text = "Montaña";
            this.rbMountain.UseVisualStyleBackColor = true;
            this.rbMountain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbBeach_KeyDown);
            // 
            // rbBeach
            // 
            this.rbBeach.AutoSize = true;
            this.rbBeach.Location = new System.Drawing.Point(149, 227);
            this.rbBeach.Name = "rbBeach";
            this.rbBeach.Size = new System.Drawing.Size(74, 26);
            this.rbBeach.TabIndex = 3;
            this.rbBeach.TabStop = true;
            this.rbBeach.Text = "Playa";
            this.rbBeach.UseVisualStyleBackColor = true;
            this.rbBeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbBeach_KeyDown);
            // 
            // cbCity
            // 
            this.cbCity.DataSource = this.bsCities;
            this.cbCity.DisplayMember = "nombre";
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(149, 270);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(244, 29);
            this.cbCity.TabIndex = 7;
            this.cbCity.ValueMember = "id_ciudad";
            this.cbCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbBeach_KeyDown);
            // 
            // cbChain
            // 
            this.cbChain.DataSource = this.bsChain;
            this.cbChain.DisplayMember = "nombre";
            this.cbChain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChain.FormattingEnabled = true;
            this.cbChain.Location = new System.Drawing.Point(149, 321);
            this.cbChain.Name = "cbChain";
            this.cbChain.Size = new System.Drawing.Size(244, 29);
            this.cbChain.TabIndex = 8;
            this.cbChain.ValueMember = "cif";
            this.cbChain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbBeach_KeyDown);
            // 
            // imgStar5
            // 
            this.imgStar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStar5.Image = global::HappyHollidays.Properties.Resources.star;
            this.imgStar5.Location = new System.Drawing.Point(441, 86);
            this.imgStar5.Name = "imgStar5";
            this.imgStar5.Size = new System.Drawing.Size(34, 29);
            this.imgStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStar5.TabIndex = 15;
            this.imgStar5.TabStop = false;
            this.imgStar5.Click += new System.EventHandler(this.imgStar5_Click);
            // 
            // imgStar4
            // 
            this.imgStar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStar4.Image = global::HappyHollidays.Properties.Resources.star;
            this.imgStar4.Location = new System.Drawing.Point(383, 86);
            this.imgStar4.Name = "imgStar4";
            this.imgStar4.Size = new System.Drawing.Size(34, 29);
            this.imgStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStar4.TabIndex = 14;
            this.imgStar4.TabStop = false;
            this.imgStar4.Click += new System.EventHandler(this.imgStar4_Click);
            // 
            // imgStar3
            // 
            this.imgStar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStar3.Image = global::HappyHollidays.Properties.Resources.star;
            this.imgStar3.Location = new System.Drawing.Point(327, 86);
            this.imgStar3.Name = "imgStar3";
            this.imgStar3.Size = new System.Drawing.Size(34, 29);
            this.imgStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStar3.TabIndex = 13;
            this.imgStar3.TabStop = false;
            this.imgStar3.Click += new System.EventHandler(this.imgStar3_Click);
            // 
            // imgStar2
            // 
            this.imgStar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStar2.Image = global::HappyHollidays.Properties.Resources.star;
            this.imgStar2.Location = new System.Drawing.Point(269, 86);
            this.imgStar2.Name = "imgStar2";
            this.imgStar2.Size = new System.Drawing.Size(34, 29);
            this.imgStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStar2.TabIndex = 12;
            this.imgStar2.TabStop = false;
            this.imgStar2.Click += new System.EventHandler(this.imgStar2_Click);
            // 
            // imgStar1
            // 
            this.imgStar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStar1.Image = global::HappyHollidays.Properties.Resources.star;
            this.imgStar1.Location = new System.Drawing.Point(214, 86);
            this.imgStar1.Name = "imgStar1";
            this.imgStar1.Size = new System.Drawing.Size(34, 29);
            this.imgStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStar1.TabIndex = 11;
            this.imgStar1.TabStop = false;
            this.imgStar1.Click += new System.EventHandler(this.imgStar1_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(149, 176);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhone.MaxLength = 9;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(244, 27);
            this.tbPhone.TabIndex = 2;
            this.tbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhone_KeyDown);
            // 
            // lblChain
            // 
            this.lblChain.AutoSize = true;
            this.lblChain.Location = new System.Drawing.Point(18, 323);
            this.lblChain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChain.Name = "lblChain";
            this.lblChain.Size = new System.Drawing.Size(69, 22);
            this.lblChain.TabIndex = 6;
            this.lblChain.Text = "Cadena";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(18, 276);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(67, 22);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "Ciudad";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(18, 227);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 22);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipo";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(18, 179);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 22);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Teléfono";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(149, 129);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.MaxLength = 50;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(333, 27);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddress_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 43);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(333, 27);
            this.tbName.TabIndex = 0;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(18, 132);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 22);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Dirección";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 93);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 22);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Categoría";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(428, 416);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(124, 33);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // bsCities
            // 
            this.bsCities.DataSource = typeof(HappyHollidays.Models.ciudades);
            // 
            // bsChain
            // 
            this.bsChain.DataSource = typeof(HappyHollidays.Models.cadenas);
            // 
            // HotelModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.btnAccept);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HotelModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HotelDialog";
            this.Load += new System.EventHandler(this.HotelDialog_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblChain;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.PictureBox imgStar5;
        private System.Windows.Forms.PictureBox imgStar4;
        private System.Windows.Forms.PictureBox imgStar3;
        private System.Windows.Forms.PictureBox imgStar2;
        private System.Windows.Forms.PictureBox imgStar1;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbChain;
        private System.Windows.Forms.RadioButton rbRural;
        private System.Windows.Forms.RadioButton rbCity;
        private System.Windows.Forms.RadioButton rbMountain;
        private System.Windows.Forms.RadioButton rbBeach;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox imgCancel;
        private System.Windows.Forms.BindingSource bsCities;
        private System.Windows.Forms.BindingSource bsChain;
    }
}