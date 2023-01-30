namespace CINE_FrontEnd
{
    partial class MenuPrincipal
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
            this.PanelVertival = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnFunciones = new System.Windows.Forms.Button();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMenuDespl = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelVertival.SuspendLayout();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenuDespl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelVertival
            // 
            this.PanelVertival.BackColor = System.Drawing.Color.Black;
            this.PanelVertival.Controls.Add(this.btnAyuda);
            this.PanelVertival.Controls.Add(this.btnClientes);
            this.PanelVertival.Controls.Add(this.btnPeliculas);
            this.PanelVertival.Controls.Add(this.btnReservas);
            this.PanelVertival.Controls.Add(this.btnFunciones);
            this.PanelVertival.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelVertival.Location = new System.Drawing.Point(0, 0);
            this.PanelVertival.Name = "PanelVertival";
            this.PanelVertival.Size = new System.Drawing.Size(200, 514);
            this.PanelVertival.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Silver;
            this.btnAyuda.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.Location = new System.Drawing.Point(72, 404);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(112, 35);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Silver;
            this.btnClientes.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.Location = new System.Drawing.Point(72, 335);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(112, 35);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.Color.Silver;
            this.btnPeliculas.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPeliculas.Location = new System.Drawing.Point(72, 267);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(112, 35);
            this.btnPeliculas.TabIndex = 2;
            this.btnPeliculas.Text = "Peliculas";
            this.btnPeliculas.UseVisualStyleBackColor = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.Silver;
            this.btnReservas.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservas.Location = new System.Drawing.Point(72, 199);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(112, 35);
            this.btnReservas.TabIndex = 1;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnFunciones
            // 
            this.btnFunciones.BackColor = System.Drawing.Color.Silver;
            this.btnFunciones.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFunciones.Location = new System.Drawing.Point(72, 135);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(112, 35);
            this.btnFunciones.TabIndex = 0;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.UseVisualStyleBackColor = false;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // PanelHorizontal
            // 
            this.PanelHorizontal.BackColor = System.Drawing.Color.CadetBlue;
            this.PanelHorizontal.Controls.Add(this.btnCerrar);
            this.PanelHorizontal.Controls.Add(this.BtnMenuDespl);
            this.PanelHorizontal.Controls.Add(this.btnMaximizar);
            this.PanelHorizontal.Controls.Add(this.btnMinimizar);
            this.PanelHorizontal.Controls.Add(this.btnMinus);
            this.PanelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontal.Location = new System.Drawing.Point(200, 0);
            this.PanelHorizontal.Name = "PanelHorizontal";
            this.PanelHorizontal.Size = new System.Drawing.Size(714, 56);
            this.PanelHorizontal.TabIndex = 1;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::CINE_FrontEnd.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(678, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BtnMenuDespl
            // 
            this.BtnMenuDespl.Image = global::CINE_FrontEnd.Properties.Resources.menu;
            this.BtnMenuDespl.Location = new System.Drawing.Point(16, 12);
            this.BtnMenuDespl.Name = "BtnMenuDespl";
            this.BtnMenuDespl.Size = new System.Drawing.Size(30, 30);
            this.BtnMenuDespl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenuDespl.TabIndex = 0;
            this.BtnMenuDespl.TabStop = false;
            this.BtnMenuDespl.Click += new System.EventHandler(this.BtnMenuDespl_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = global::CINE_FrontEnd.Properties.Resources.maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(652, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::CINE_FrontEnd.Properties.Resources.minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(652, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.Image = global::CINE_FrontEnd.Properties.Resources.minus;
            this.btnMinus.Location = new System.Drawing.Point(626, 12);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 25);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 1;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 56);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(714, 458);
            this.PanelContenedor.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 514);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.PanelVertival);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.PanelVertival.ResumeLayout(false);
            this.PanelHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenuDespl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelVertival;
        private Panel PanelHorizontal;
        private Panel PanelContenedor;
        private PictureBox BtnMenuDespl;
        private PictureBox btnMinus;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private Button btnFunciones;
        private Button btnAyuda;
        private Button btnClientes;
        private Button btnPeliculas;
        private Button btnReservas;
    }
}