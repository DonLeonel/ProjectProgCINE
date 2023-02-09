namespace CINE_FrontEnd.Forms
{
    partial class FormDetalleReserva
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
            this.dgvDetalleReserva = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleReserva
            // 
            this.dgvDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo,
            this.fecha,
            this.hora_inicio,
            this.precio,
            this.id_sala,
            this.sala});
            this.dgvDetalleReserva.Location = new System.Drawing.Point(30, 44);
            this.dgvDetalleReserva.Name = "dgvDetalleReserva";
            this.dgvDetalleReserva.RowTemplate.Height = 25;
            this.dgvDetalleReserva.Size = new System.Drawing.Size(681, 281);
            this.dgvDetalleReserva.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // hora_inicio
            // 
            this.hora_inicio.HeaderText = "Hora Inicio";
            this.hora_inicio.Name = "hora_inicio";
            this.hora_inicio.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // id_sala
            // 
            this.id_sala.HeaderText = "Sala Nro";
            this.id_sala.Name = "id_sala";
            this.id_sala.ReadOnly = true;
            // 
            // sala
            // 
            this.sala.HeaderText = "Tipo Sala";
            this.sala.Name = "sala";
            this.sala.ReadOnly = true;
            // 
            // FormDetalleReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 374);
            this.Controls.Add(this.dgvDetalleReserva);
            this.Name = "FormDetalleReserva";
            this.Text = "FormDetalleReserva";
            this.Load += new System.EventHandler(this.FormDetalleReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDetalleReserva;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn hora_inicio;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn id_sala;
        private DataGridViewTextBoxColumn sala;
    }
}