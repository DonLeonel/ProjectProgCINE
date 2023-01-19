namespace CINE_FrontEnd.Forms
{
    partial class FormAltaPelicula
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
            this.label7 = new System.Windows.Forms.Label();
            this.rbtAptaTodoP = new System.Windows.Forms.RadioButton();
            this.rbtSubtitulos = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtElenco = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFecEstreno = new System.Windows.Forms.DateTimePicker();
            this.cboCalificacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(315, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nueva Pelicula";
            // 
            // rbtAptaTodoP
            // 
            this.rbtAptaTodoP.AutoSize = true;
            this.rbtAptaTodoP.Location = new System.Drawing.Point(410, 263);
            this.rbtAptaTodoP.Name = "rbtAptaTodoP";
            this.rbtAptaTodoP.Size = new System.Drawing.Size(147, 19);
            this.rbtAptaTodoP.TabIndex = 60;
            this.rbtAptaTodoP.TabStop = true;
            this.rbtAptaTodoP.Text = "Apta para todo publico";
            this.rbtAptaTodoP.UseVisualStyleBackColor = true;
            // 
            // rbtSubtitulos
            // 
            this.rbtSubtitulos.AutoSize = true;
            this.rbtSubtitulos.Location = new System.Drawing.Point(577, 263);
            this.rbtSubtitulos.Name = "rbtSubtitulos";
            this.rbtSubtitulos.Size = new System.Drawing.Size(78, 19);
            this.rbtSubtitulos.TabIndex = 59;
            this.rbtSubtitulos.TabStop = true;
            this.rbtSubtitulos.Text = "Subtitulos";
            this.rbtSubtitulos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "Genero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 57;
            this.label9.Text = "Origen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 56;
            this.label8.Text = "Calificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Duracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Elenco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Idioma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Fecha de Estreno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Sinopsis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Titulo";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(473, 318);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(181, 23);
            this.cboGenero.TabIndex = 49;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(145, 318);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(178, 23);
            this.cboOrigen.TabIndex = 48;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(145, 262);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(178, 23);
            this.txtIdioma.TabIndex = 47;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(474, 149);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(181, 23);
            this.txtDuracion.TabIndex = 45;
            // 
            // txtElenco
            // 
            this.txtElenco.Location = new System.Drawing.Point(473, 91);
            this.txtElenco.Name = "txtElenco";
            this.txtElenco.Size = new System.Drawing.Size(181, 23);
            this.txtElenco.TabIndex = 44;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(145, 149);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(178, 23);
            this.txtSinopsis.TabIndex = 42;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(145, 91);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(178, 23);
            this.txtTitulo.TabIndex = 41;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(282, 388);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 23);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFecEstreno
            // 
            this.dtpFecEstreno.Location = new System.Drawing.Point(145, 204);
            this.dtpFecEstreno.Name = "dtpFecEstreno";
            this.dtpFecEstreno.Size = new System.Drawing.Size(216, 23);
            this.dtpFecEstreno.TabIndex = 63;
            // 
            // cboCalificacion
            // 
            this.cboCalificacion.FormattingEnabled = true;
            this.cboCalificacion.Location = new System.Drawing.Point(474, 204);
            this.cboCalificacion.Name = "cboCalificacion";
            this.cboCalificacion.Size = new System.Drawing.Size(180, 23);
            this.cboCalificacion.TabIndex = 64;
            // 
            // FormAltaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.cboCalificacion);
            this.Controls.Add(this.dtpFecEstreno);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbtAptaTodoP);
            this.Controls.Add(this.rbtSubtitulos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtElenco);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltaPelicula";
            this.Text = "FormAltaPelicula";
            this.Load += new System.EventHandler(this.FormAltaPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private RadioButton rbtAptaTodoP;
        private RadioButton rbtSubtitulos;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboGenero;
        private ComboBox cboOrigen;
        private TextBox txtIdioma;
        private TextBox txtDuracion;
        private TextBox txtElenco;
        private TextBox txtSinopsis;
        private TextBox txtTitulo;
        private Button btnGuardar;
        private DateTimePicker dtpFecEstreno;
        private ComboBox cboCalificacion;
    }
}