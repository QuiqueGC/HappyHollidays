namespace HappyHollidays.ModalForms
{
    partial class ActivitiesListModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesListModalForm));
            this.gbActivities = new System.Windows.Forms.GroupBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.imgFindActivity = new System.Windows.Forms.PictureBox();
            this.tbFindActivity = new System.Windows.Forms.TextBox();
            this.lblFindActivity = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lbActivities = new System.Windows.Forms.ListBox();
            this.bsActivities = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.gbActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActivities
            // 
            this.gbActivities.BackColor = System.Drawing.Color.Transparent;
            this.gbActivities.Controls.Add(this.tbGrade);
            this.gbActivities.Controls.Add(this.imgFindActivity);
            this.gbActivities.Controls.Add(this.tbFindActivity);
            this.gbActivities.Controls.Add(this.lblFindActivity);
            this.gbActivities.Controls.Add(this.lblGrade);
            this.gbActivities.Controls.Add(this.lbActivities);
            this.gbActivities.Location = new System.Drawing.Point(37, 39);
            this.gbActivities.Margin = new System.Windows.Forms.Padding(4);
            this.gbActivities.Name = "gbActivities";
            this.gbActivities.Padding = new System.Windows.Forms.Padding(4);
            this.gbActivities.Size = new System.Drawing.Size(471, 559);
            this.gbActivities.TabIndex = 0;
            this.gbActivities.TabStop = false;
            this.gbActivities.Text = "Lista de actividades";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(192, 503);
            this.tbGrade.MaxLength = 3;
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(100, 23);
            this.tbGrade.TabIndex = 2;
            this.tbGrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGrade_KeyDown);
            // 
            // imgFindActivity
            // 
            this.imgFindActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFindActivity.Image = global::HappyHollidays.Properties.Resources.ic_find;
            this.imgFindActivity.Location = new System.Drawing.Point(372, 21);
            this.imgFindActivity.Name = "imgFindActivity";
            this.imgFindActivity.Size = new System.Drawing.Size(50, 43);
            this.imgFindActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFindActivity.TabIndex = 6;
            this.imgFindActivity.TabStop = false;
            this.imgFindActivity.Click += new System.EventHandler(this.imgFindActivity_Click);
            // 
            // tbFindActivity
            // 
            this.tbFindActivity.Location = new System.Drawing.Point(116, 30);
            this.tbFindActivity.Name = "tbFindActivity";
            this.tbFindActivity.Size = new System.Drawing.Size(244, 23);
            this.tbFindActivity.TabIndex = 0;
            this.tbFindActivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFindActivity_KeyDown);
            // 
            // lblFindActivity
            // 
            this.lblFindActivity.AutoSize = true;
            this.lblFindActivity.Location = new System.Drawing.Point(47, 33);
            this.lblFindActivity.Name = "lblFindActivity";
            this.lblFindActivity.Size = new System.Drawing.Size(49, 18);
            this.lblFindActivity.TabIndex = 7;
            this.lblFindActivity.Text = "Buscar";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(140, 506);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(46, 18);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Grado";
            // 
            // lbActivities
            // 
            this.lbActivities.DataSource = this.bsActivities;
            this.lbActivities.DisplayMember = "descripcion";
            this.lbActivities.FormattingEnabled = true;
            this.lbActivities.ItemHeight = 18;
            this.lbActivities.Location = new System.Drawing.Point(22, 72);
            this.lbActivities.Margin = new System.Windows.Forms.Padding(4);
            this.lbActivities.Name = "lbActivities";
            this.lbActivities.Size = new System.Drawing.Size(422, 418);
            this.lbActivities.TabIndex = 1;
            this.lbActivities.TabStop = false;
            this.lbActivities.ValueMember = "id_act";
            // 
            // bsActivities
            // 
            this.bsActivities.DataSource = typeof(HappyHollidays.Models.actividades);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 615);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(383, 615);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(124, 33);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ActivitiesListModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(551, 679);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbActivities);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ActivitiesListModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de actividades";
            this.Load += new System.EventHandler(this.ActivitiesListModalForm_Load);
            this.gbActivities.ResumeLayout(false);
            this.gbActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFindActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActivities;
        private System.Windows.Forms.ListBox lbActivities;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox tbFindActivity;
        private System.Windows.Forms.Label lblFindActivity;
        private System.Windows.Forms.PictureBox imgFindActivity;
        private System.Windows.Forms.BindingSource bsActivities;
        private System.Windows.Forms.TextBox tbGrade;
    }
}