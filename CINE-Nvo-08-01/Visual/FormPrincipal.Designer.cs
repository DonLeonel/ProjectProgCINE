namespace tpConeProgII
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.iconBajar = new System.Windows.Forms.PictureBox();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuVertical.Controls.Add(this.btnReservas);
            this.menuVertical.Controls.Add(this.btnClientes);
            this.menuVertical.Controls.Add(this.btnPeliculas);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 600);
            this.menuVertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.iconMaximizar);
            this.barraTitulo.Controls.Add(this.iconBajar);
            this.barraTitulo.Controls.Add(this.iconRestaurar);
            this.barraTitulo.Controls.Add(this.iconCerrar);
            this.barraTitulo.Controls.Add(this.btnMenu);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(350, 50);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // iconBajar
            // 
            this.iconBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBajar.Image = ((System.Drawing.Image)(resources.GetObject("iconBajar.Image")));
            this.iconBajar.Location = new System.Drawing.Point(272, 0);
            this.iconBajar.Name = "iconBajar";
            this.iconBajar.Size = new System.Drawing.Size(28, 28);
            this.iconBajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBajar.TabIndex = 3;
            this.iconBajar.TabStop = false;
            this.iconBajar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconRestaurar.Image")));
            this.iconRestaurar.Location = new System.Drawing.Point(297, 0);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(28, 28);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 2;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.btnTamaño_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(322, 0);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(28, 28);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(53, 50);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(350, 550);
            this.panelContenedor.TabIndex = 2;
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximizar.Image")));
            this.iconMaximizar.Location = new System.Drawing.Point(297, 0);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(28, 28);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 4;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.ForeColor = System.Drawing.Color.Yellow;
            this.btnPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnPeliculas.Image")));
            this.btnPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeliculas.Location = new System.Drawing.Point(0, 78);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(250, 40);
            this.btnPeliculas.TabIndex = 1;
            this.btnPeliculas.Text = "Peliculas";
            this.btnPeliculas.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Yellow;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 146);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 40);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.Yellow;
            this.btnReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnReservas.Image")));
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(0, 214);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(250, 40);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cine ";
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox iconBajar;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnClientes;
    }
}

