namespace HappyHollidays
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChains = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHotels = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCities = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActivities = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStripMain.Size = new System.Drawing.Size(1148, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChains,
            this.tsmiHotels,
            this.tsmiCities,
            this.tsmiActivities,
            this.lToolStripMenuItem,
            this.tsmiExit});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmiChains
            // 
            this.tsmiChains.Image = global::HappyHollidays.Properties.Resources.ic_city;
            this.tsmiChains.Name = "tsmiChains";
            this.tsmiChains.Size = new System.Drawing.Size(147, 22);
            this.tsmiChains.Text = "Cadenas";
            this.tsmiChains.Click += new System.EventHandler(this.tsmiChains_Click);
            // 
            // tsmiHotels
            // 
            this.tsmiHotels.Image = global::HappyHollidays.Properties.Resources.ic_hotel;
            this.tsmiHotels.Name = "tsmiHotels";
            this.tsmiHotels.Size = new System.Drawing.Size(147, 22);
            this.tsmiHotels.Text = "Hoteles";
            this.tsmiHotels.Click += new System.EventHandler(this.tsmiHotels_Click);
            // 
            // tsmiCities
            // 
            this.tsmiCities.Image = global::HappyHollidays.Properties.Resources.ic_map;
            this.tsmiCities.Name = "tsmiCities";
            this.tsmiCities.Size = new System.Drawing.Size(147, 22);
            this.tsmiCities.Text = "Ciudades";
            this.tsmiCities.Click += new System.EventHandler(this.tsmiCities_Click);
            // 
            // tsmiActivities
            // 
            this.tsmiActivities.Image = global::HappyHollidays.Properties.Resources.ic_cocktail;
            this.tsmiActivities.Name = "tsmiActivities";
            this.tsmiActivities.Size = new System.Drawing.Size(147, 22);
            this.tsmiActivities.Text = "Actividades";
            this.tsmiActivities.Click += new System.EventHandler(this.tsmiActivities_Click);
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(144, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::HappyHollidays.Properties.Resources.ic_exit;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(147, 22);
            this.tsmiExit.Text = "Salir";
            this.tsmiExit.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 28);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1148, 533);
            this.panelMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1148, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Hollidays";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChains;
        private System.Windows.Forms.ToolStripMenuItem tsmiHotels;
        private System.Windows.Forms.ToolStripMenuItem tsmiCities;
        private System.Windows.Forms.ToolStripMenuItem tsmiActivities;
        private System.Windows.Forms.ToolStripSeparator lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Panel panelMain;
    }
}

