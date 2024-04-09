namespace HappyHollidays.Dialogs
{
    partial class ChainModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChainModalForm));
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lblNums = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.tbCifLetter = new System.Windows.Forms.TextBox();
            this.tbFiscalAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCifNums = new System.Windows.Forms.TextBox();
            this.lblFiscalAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCif = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.Color.Transparent;
            this.gbData.Controls.Add(this.lblNums);
            this.gbData.Controls.Add(this.lblLetter);
            this.gbData.Controls.Add(this.tbCifLetter);
            this.gbData.Controls.Add(this.tbFiscalAddress);
            this.gbData.Controls.Add(this.tbName);
            this.gbData.Controls.Add(this.tbCifNums);
            this.gbData.Controls.Add(this.lblFiscalAddress);
            this.gbData.Controls.Add(this.lblName);
            this.gbData.Controls.Add(this.lblCif);
            this.gbData.Location = new System.Drawing.Point(13, 32);
            this.gbData.Margin = new System.Windows.Forms.Padding(4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4);
            this.gbData.Size = new System.Drawing.Size(508, 179);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos";
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Location = new System.Drawing.Point(216, 28);
            this.lblNums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(82, 22);
            this.lblNums.TabIndex = 5;
            this.lblNums.Text = "Números";
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(169, 28);
            this.lblLetter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(51, 22);
            this.lblLetter.TabIndex = 4;
            this.lblLetter.Text = "Letra";
            // 
            // tbCifLetter
            // 
            this.tbCifLetter.Location = new System.Drawing.Point(172, 52);
            this.tbCifLetter.Margin = new System.Windows.Forms.Padding(4);
            this.tbCifLetter.MaxLength = 1;
            this.tbCifLetter.Name = "tbCifLetter";
            this.tbCifLetter.Size = new System.Drawing.Size(32, 27);
            this.tbCifLetter.TabIndex = 0;
            this.tbCifLetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCifLetter_KeyDown);
            // 
            // tbFiscalAddress
            // 
            this.tbFiscalAddress.Location = new System.Drawing.Point(172, 137);
            this.tbFiscalAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbFiscalAddress.MaxLength = 50;
            this.tbFiscalAddress.Name = "tbFiscalAddress";
            this.tbFiscalAddress.Size = new System.Drawing.Size(320, 27);
            this.tbFiscalAddress.TabIndex = 3;
            this.tbFiscalAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCifLetter_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(172, 97);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 27);
            this.tbName.TabIndex = 2;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCifLetter_KeyDown);
            // 
            // tbCifNums
            // 
            this.tbCifNums.Location = new System.Drawing.Point(218, 51);
            this.tbCifNums.Margin = new System.Windows.Forms.Padding(4);
            this.tbCifNums.MaxLength = 8;
            this.tbCifNums.Name = "tbCifNums";
            this.tbCifNums.Size = new System.Drawing.Size(274, 27);
            this.tbCifNums.TabIndex = 1;
            this.tbCifNums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCifLetter_KeyDown);
            // 
            // lblFiscalAddress
            // 
            this.lblFiscalAddress.AutoSize = true;
            this.lblFiscalAddress.Location = new System.Drawing.Point(8, 141);
            this.lblFiscalAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiscalAddress.Name = "lblFiscalAddress";
            this.lblFiscalAddress.Size = new System.Drawing.Size(135, 22);
            this.lblFiscalAddress.TabIndex = 2;
            this.lblFiscalAddress.Text = "Dirección fiscal";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 101);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Location = new System.Drawing.Point(8, 55);
            this.lblCif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(38, 22);
            this.lblCif.TabIndex = 0;
            this.lblCif.Text = "CIF";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(394, 230);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(124, 33);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChainModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 275);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbData);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChainModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir Cadena";
            this.Load += new System.EventHandler(this.ChainModalForm_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox tbFiscalAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCifNums;
        private System.Windows.Forms.Label lblFiscalAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCif;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbCifLetter;
        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.Label lblLetter;
    }
}