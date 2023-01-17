namespace CINE_FrontEnd
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelVertical = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelVertical
            // 
            this.PanelVertical.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelVertical.Location = new System.Drawing.Point(0, 0);
            this.PanelVertical.Name = "PanelVertical";
            this.PanelVertical.Size = new System.Drawing.Size(200, 450);
            this.PanelVertical.TabIndex = 0;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.Sienna;
            this.PanelTitulo.Controls.Add(this.pictureBox1);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(200, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(600, 49);
            this.PanelTitulo.TabIndex = 1;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 49);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(600, 401);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CINE_FrontEnd.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.PanelVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Form1";
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelVertical;
        private Panel PanelTitulo;
        private PictureBox pictureBox1;
        private Panel PanelContenedor;
    }
}