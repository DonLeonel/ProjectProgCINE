namespace CINE_FrontEnd
{
    partial class FormPeliculas
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
            this.PanelContPeliculas = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNvaPelicula = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.PanelContPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContPeliculas
            // 
            this.PanelContPeliculas.Controls.Add(this.btnBorrar);
            this.PanelContPeliculas.Controls.Add(this.btnEditar);
            this.PanelContPeliculas.Controls.Add(this.btnNvaPelicula);
            this.PanelContPeliculas.Controls.Add(this.dgvPeliculas);
            this.PanelContPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContPeliculas.Location = new System.Drawing.Point(0, 0);
            this.PanelContPeliculas.Name = "PanelContPeliculas";
            this.PanelContPeliculas.Size = new System.Drawing.Size(730, 450);
            this.PanelContPeliculas.TabIndex = 4;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Location = new System.Drawing.Point(273, 372);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(187, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(494, 372);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(187, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNvaPelicula
            // 
            this.btnNvaPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNvaPelicula.Location = new System.Drawing.Point(49, 372);
            this.btnNvaPelicula.Name = "btnNvaPelicula";
            this.btnNvaPelicula.Size = new System.Drawing.Size(187, 23);
            this.btnNvaPelicula.TabIndex = 5;
            this.btnNvaPelicula.Text = "Nueva";
            this.btnNvaPelicula.UseVisualStyleBackColor = true;
            this.btnNvaPelicula.Click += new System.EventHandler(this.btnNvaPelicula_Click_1);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(49, 56);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowTemplate.Height = 25;
            this.dgvPeliculas.Size = new System.Drawing.Size(632, 249);
            this.dgvPeliculas.TabIndex = 4;
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.PanelContPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeliculas";
            this.Text = "FormPeliculas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            this.PanelContPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelContPeliculas;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnNvaPelicula;
        private DataGridView dgvPeliculas;
    }
}