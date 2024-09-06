namespace almacenamientoDeDatos
{
    partial class Form1
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msiTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.msiXml = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRtf = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiTxt,
            this.msiCsv,
            this.msiXml,
            this.msiRtf});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(604, 72);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // msiTxt
            // 
            this.msiTxt.Image = global::almacenamientoDeDatos.Properties.Resources.txt;
            this.msiTxt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msiTxt.Name = "msiTxt";
            this.msiTxt.Size = new System.Drawing.Size(102, 68);
            this.msiTxt.Text = "&TXT";
            this.msiTxt.Click += new System.EventHandler(this.msiTxt_Click);
            // 
            // msiCsv
            // 
            this.msiCsv.Image = global::almacenamientoDeDatos.Properties.Resources.csv;
            this.msiCsv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msiCsv.Name = "msiCsv";
            this.msiCsv.Size = new System.Drawing.Size(104, 68);
            this.msiCsv.Text = "&CSV";
            this.msiCsv.Click += new System.EventHandler(this.msiCsv_Click);
            // 
            // msiXml
            // 
            this.msiXml.Image = global::almacenamientoDeDatos.Properties.Resources.xml;
            this.msiXml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msiXml.Name = "msiXml";
            this.msiXml.Size = new System.Drawing.Size(107, 68);
            this.msiXml.Text = "&XML";
            this.msiXml.Click += new System.EventHandler(this.msiXml_Click);
            // 
            // msiRtf
            // 
            this.msiRtf.Image = global::almacenamientoDeDatos.Properties.Resources.rtf;
            this.msiRtf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msiRtf.Name = "msiRtf";
            this.msiRtf.Size = new System.Drawing.Size(101, 68);
            this.msiRtf.Text = "&RTF";
            this.msiRtf.Click += new System.EventHandler(this.msiRtf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msiTxt;
        private System.Windows.Forms.ToolStripMenuItem msiCsv;
        private System.Windows.Forms.ToolStripMenuItem msiXml;
        private System.Windows.Forms.ToolStripMenuItem msiRtf;
    }
}

