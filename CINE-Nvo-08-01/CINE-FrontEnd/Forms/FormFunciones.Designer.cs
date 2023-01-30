namespace CINE_FrontEnd.Forms
{
    partial class FormFunciones
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
            this.PnlContFunciones = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNvaFuncion = new System.Windows.Forms.Button();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.PnlContFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContFunciones
            // 
            this.PnlContFunciones.Controls.Add(this.btnBorrar);
            this.PnlContFunciones.Controls.Add(this.btnEditar);
            this.PnlContFunciones.Controls.Add(this.btnNvaFuncion);
            this.PnlContFunciones.Controls.Add(this.dgvFunciones);
            this.PnlContFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContFunciones.Location = new System.Drawing.Point(0, 0);
            this.PnlContFunciones.Name = "PnlContFunciones";
            this.PnlContFunciones.Size = new System.Drawing.Size(800, 450);
            this.PnlContFunciones.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Location = new System.Drawing.Point(309, 393);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(187, 23);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(551, 393);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(187, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNvaFuncion
            // 
            this.btnNvaFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNvaFuncion.Location = new System.Drawing.Point(61, 393);
            this.btnNvaFuncion.Name = "btnNvaFuncion";
            this.btnNvaFuncion.Size = new System.Drawing.Size(187, 23);
            this.btnNvaFuncion.TabIndex = 17;
            this.btnNvaFuncion.Text = "Nueva";
            this.btnNvaFuncion.UseVisualStyleBackColor = true;
            this.btnNvaFuncion.Click += new System.EventHandler(this.btnNvaFuncion_Click);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Location = new System.Drawing.Point(63, 35);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.RowTemplate.Height = 25;
            this.dgvFunciones.Size = new System.Drawing.Size(677, 304);
            this.dgvFunciones.TabIndex = 16;
            // 
            // FormFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlContFunciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFunciones";
            this.Text = "FormFunciones";
            this.Load += new System.EventHandler(this.FormFunciones_Load);
            this.PnlContFunciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlContFunciones;
        private Button btnBorrar;
        private Button btnEditar;
        private Button btnNvaFuncion;
        private DataGridView dgvFunciones;
    }
}