namespace CINE_FrontEnd.Forms
{
    partial class FormAltaReserva
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
            this.dgvFuncReser = new System.Windows.Forms.DataGridView();
            this.txtNombFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContButacas = new System.Windows.Forms.Panel();
            this.b50 = new System.Windows.Forms.Button();
            this.b49 = new System.Windows.Forms.Button();
            this.b48 = new System.Windows.Forms.Button();
            this.b46 = new System.Windows.Forms.Button();
            this.b47 = new System.Windows.Forms.Button();
            this.b45 = new System.Windows.Forms.Button();
            this.b44 = new System.Windows.Forms.Button();
            this.b43 = new System.Windows.Forms.Button();
            this.b42 = new System.Windows.Forms.Button();
            this.b41 = new System.Windows.Forms.Button();
            this.b40 = new System.Windows.Forms.Button();
            this.b39 = new System.Windows.Forms.Button();
            this.b38 = new System.Windows.Forms.Button();
            this.b36 = new System.Windows.Forms.Button();
            this.b37 = new System.Windows.Forms.Button();
            this.b35 = new System.Windows.Forms.Button();
            this.b34 = new System.Windows.Forms.Button();
            this.b33 = new System.Windows.Forms.Button();
            this.b32 = new System.Windows.Forms.Button();
            this.b31 = new System.Windows.Forms.Button();
            this.b30 = new System.Windows.Forms.Button();
            this.b29 = new System.Windows.Forms.Button();
            this.b28 = new System.Windows.Forms.Button();
            this.b26 = new System.Windows.Forms.Button();
            this.b27 = new System.Windows.Forms.Button();
            this.b25 = new System.Windows.Forms.Button();
            this.b24 = new System.Windows.Forms.Button();
            this.b23 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b20 = new System.Windows.Forms.Button();
            this.b19 = new System.Windows.Forms.Button();
            this.b18 = new System.Windows.Forms.Button();
            this.b16 = new System.Windows.Forms.Button();
            this.b17 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.b14 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agotado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncReser)).BeginInit();
            this.pnlContButacas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncReser
            // 
            this.dgvFuncReser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncReser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_funcion,
            this.id_pelicula,
            this.id_sala,
            this.fecha,
            this.hora_inicio,
            this.precio,
            this.titulo,
            this.tipo,
            this.agotado});
            this.dgvFuncReser.Location = new System.Drawing.Point(33, 86);
            this.dgvFuncReser.Name = "dgvFuncReser";
            this.dgvFuncReser.RowTemplate.Height = 25;
            this.dgvFuncReser.Size = new System.Drawing.Size(622, 150);
            this.dgvFuncReser.TabIndex = 0;
            // 
            // txtNombFunc
            // 
            this.txtNombFunc.Location = new System.Drawing.Point(320, 26);
            this.txtNombFunc.Name = "txtNombFunc";
            this.txtNombFunc.Size = new System.Drawing.Size(297, 23);
            this.txtNombFunc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por nombre de Funcion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(320, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(517, 387);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(126, 23);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(467, 320);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(224, 23);
            this.cboClientes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(503, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Selecciones el cliente";
            // 
            // pnlContButacas
            // 
            this.pnlContButacas.Controls.Add(this.b50);
            this.pnlContButacas.Controls.Add(this.b49);
            this.pnlContButacas.Controls.Add(this.b48);
            this.pnlContButacas.Controls.Add(this.b46);
            this.pnlContButacas.Controls.Add(this.b47);
            this.pnlContButacas.Controls.Add(this.b45);
            this.pnlContButacas.Controls.Add(this.b44);
            this.pnlContButacas.Controls.Add(this.b43);
            this.pnlContButacas.Controls.Add(this.b42);
            this.pnlContButacas.Controls.Add(this.b41);
            this.pnlContButacas.Controls.Add(this.b40);
            this.pnlContButacas.Controls.Add(this.b39);
            this.pnlContButacas.Controls.Add(this.b38);
            this.pnlContButacas.Controls.Add(this.b36);
            this.pnlContButacas.Controls.Add(this.b37);
            this.pnlContButacas.Controls.Add(this.b35);
            this.pnlContButacas.Controls.Add(this.b34);
            this.pnlContButacas.Controls.Add(this.b33);
            this.pnlContButacas.Controls.Add(this.b32);
            this.pnlContButacas.Controls.Add(this.b31);
            this.pnlContButacas.Controls.Add(this.b30);
            this.pnlContButacas.Controls.Add(this.b29);
            this.pnlContButacas.Controls.Add(this.b28);
            this.pnlContButacas.Controls.Add(this.b26);
            this.pnlContButacas.Controls.Add(this.b27);
            this.pnlContButacas.Controls.Add(this.b25);
            this.pnlContButacas.Controls.Add(this.b24);
            this.pnlContButacas.Controls.Add(this.b23);
            this.pnlContButacas.Controls.Add(this.b22);
            this.pnlContButacas.Controls.Add(this.b21);
            this.pnlContButacas.Controls.Add(this.b20);
            this.pnlContButacas.Controls.Add(this.b19);
            this.pnlContButacas.Controls.Add(this.b18);
            this.pnlContButacas.Controls.Add(this.b16);
            this.pnlContButacas.Controls.Add(this.b17);
            this.pnlContButacas.Controls.Add(this.b15);
            this.pnlContButacas.Controls.Add(this.b14);
            this.pnlContButacas.Controls.Add(this.b13);
            this.pnlContButacas.Controls.Add(this.b12);
            this.pnlContButacas.Controls.Add(this.b11);
            this.pnlContButacas.Controls.Add(this.b10);
            this.pnlContButacas.Controls.Add(this.b9);
            this.pnlContButacas.Controls.Add(this.b8);
            this.pnlContButacas.Controls.Add(this.b6);
            this.pnlContButacas.Controls.Add(this.b7);
            this.pnlContButacas.Controls.Add(this.b5);
            this.pnlContButacas.Controls.Add(this.b4);
            this.pnlContButacas.Controls.Add(this.b3);
            this.pnlContButacas.Controls.Add(this.b2);
            this.pnlContButacas.Controls.Add(this.b1);
            this.pnlContButacas.Controls.Add(this.label2);
            this.pnlContButacas.Location = new System.Drawing.Point(33, 242);
            this.pnlContButacas.Name = "pnlContButacas";
            this.pnlContButacas.Size = new System.Drawing.Size(421, 202);
            this.pnlContButacas.TabIndex = 57;
            // 
            // b50
            // 
            this.b50.BackColor = System.Drawing.Color.Lime;
            this.b50.Location = new System.Drawing.Point(372, 165);
            this.b50.Name = "b50";
            this.b50.Size = new System.Drawing.Size(33, 23);
            this.b50.TabIndex = 106;
            this.b50.Text = "50";
            this.b50.UseVisualStyleBackColor = false;
            this.b50.Click += new System.EventHandler(this.b50_Click);
            // 
            // b49
            // 
            this.b49.BackColor = System.Drawing.Color.Lime;
            this.b49.Location = new System.Drawing.Point(333, 165);
            this.b49.Name = "b49";
            this.b49.Size = new System.Drawing.Size(33, 23);
            this.b49.TabIndex = 105;
            this.b49.Text = "49";
            this.b49.UseVisualStyleBackColor = false;
            this.b49.Click += new System.EventHandler(this.b49_Click);
            // 
            // b48
            // 
            this.b48.BackColor = System.Drawing.Color.Lime;
            this.b48.Location = new System.Drawing.Point(294, 165);
            this.b48.Name = "b48";
            this.b48.Size = new System.Drawing.Size(33, 23);
            this.b48.TabIndex = 104;
            this.b48.Text = "48";
            this.b48.UseVisualStyleBackColor = false;
            this.b48.Click += new System.EventHandler(this.b48_Click);
            // 
            // b46
            // 
            this.b46.BackColor = System.Drawing.Color.Lime;
            this.b46.Location = new System.Drawing.Point(216, 165);
            this.b46.Name = "b46";
            this.b46.Size = new System.Drawing.Size(33, 23);
            this.b46.TabIndex = 102;
            this.b46.Text = "46";
            this.b46.UseVisualStyleBackColor = false;
            this.b46.Click += new System.EventHandler(this.b46_Click);
            // 
            // b47
            // 
            this.b47.BackColor = System.Drawing.Color.Lime;
            this.b47.Location = new System.Drawing.Point(255, 165);
            this.b47.Name = "b47";
            this.b47.Size = new System.Drawing.Size(33, 23);
            this.b47.TabIndex = 103;
            this.b47.Text = "47";
            this.b47.UseVisualStyleBackColor = false;
            this.b47.Click += new System.EventHandler(this.b47_Click);
            // 
            // b45
            // 
            this.b45.BackColor = System.Drawing.Color.Lime;
            this.b45.Location = new System.Drawing.Point(176, 165);
            this.b45.Name = "b45";
            this.b45.Size = new System.Drawing.Size(33, 23);
            this.b45.TabIndex = 101;
            this.b45.Text = "45";
            this.b45.UseVisualStyleBackColor = false;
            this.b45.Click += new System.EventHandler(this.b45_Click);
            // 
            // b44
            // 
            this.b44.BackColor = System.Drawing.Color.Lime;
            this.b44.Location = new System.Drawing.Point(136, 165);
            this.b44.Name = "b44";
            this.b44.Size = new System.Drawing.Size(33, 23);
            this.b44.TabIndex = 100;
            this.b44.Text = "44";
            this.b44.UseVisualStyleBackColor = false;
            this.b44.Click += new System.EventHandler(this.b44_Click);
            // 
            // b43
            // 
            this.b43.BackColor = System.Drawing.Color.Lime;
            this.b43.Location = new System.Drawing.Point(96, 165);
            this.b43.Name = "b43";
            this.b43.Size = new System.Drawing.Size(33, 23);
            this.b43.TabIndex = 99;
            this.b43.Text = "43";
            this.b43.UseVisualStyleBackColor = false;
            this.b43.Click += new System.EventHandler(this.b43_Click);
            // 
            // b42
            // 
            this.b42.BackColor = System.Drawing.Color.Lime;
            this.b42.Location = new System.Drawing.Point(57, 165);
            this.b42.Name = "b42";
            this.b42.Size = new System.Drawing.Size(33, 23);
            this.b42.TabIndex = 98;
            this.b42.Text = "42";
            this.b42.UseVisualStyleBackColor = false;
            this.b42.Click += new System.EventHandler(this.b42_Click);
            // 
            // b41
            // 
            this.b41.BackColor = System.Drawing.Color.Lime;
            this.b41.Location = new System.Drawing.Point(17, 165);
            this.b41.Name = "b41";
            this.b41.Size = new System.Drawing.Size(33, 23);
            this.b41.TabIndex = 97;
            this.b41.Text = "41";
            this.b41.UseVisualStyleBackColor = false;
            this.b41.Click += new System.EventHandler(this.b41_Click);
            // 
            // b40
            // 
            this.b40.BackColor = System.Drawing.Color.Lime;
            this.b40.Location = new System.Drawing.Point(372, 136);
            this.b40.Name = "b40";
            this.b40.Size = new System.Drawing.Size(33, 23);
            this.b40.TabIndex = 96;
            this.b40.Text = "40";
            this.b40.UseVisualStyleBackColor = false;
            this.b40.Click += new System.EventHandler(this.b40_Click);
            // 
            // b39
            // 
            this.b39.BackColor = System.Drawing.Color.Lime;
            this.b39.Location = new System.Drawing.Point(333, 136);
            this.b39.Name = "b39";
            this.b39.Size = new System.Drawing.Size(33, 23);
            this.b39.TabIndex = 95;
            this.b39.Text = "39";
            this.b39.UseVisualStyleBackColor = false;
            this.b39.Click += new System.EventHandler(this.b39_Click);
            // 
            // b38
            // 
            this.b38.BackColor = System.Drawing.Color.Lime;
            this.b38.Location = new System.Drawing.Point(294, 136);
            this.b38.Name = "b38";
            this.b38.Size = new System.Drawing.Size(33, 23);
            this.b38.TabIndex = 94;
            this.b38.Text = "38";
            this.b38.UseVisualStyleBackColor = false;
            this.b38.Click += new System.EventHandler(this.b38_Click);
            // 
            // b36
            // 
            this.b36.BackColor = System.Drawing.Color.Lime;
            this.b36.Location = new System.Drawing.Point(216, 136);
            this.b36.Name = "b36";
            this.b36.Size = new System.Drawing.Size(33, 23);
            this.b36.TabIndex = 92;
            this.b36.Text = "36";
            this.b36.UseVisualStyleBackColor = false;
            this.b36.Click += new System.EventHandler(this.b36_Click);
            // 
            // b37
            // 
            this.b37.BackColor = System.Drawing.Color.Lime;
            this.b37.Location = new System.Drawing.Point(255, 136);
            this.b37.Name = "b37";
            this.b37.Size = new System.Drawing.Size(33, 23);
            this.b37.TabIndex = 93;
            this.b37.Text = "37";
            this.b37.UseVisualStyleBackColor = false;
            this.b37.Click += new System.EventHandler(this.b37_Click);
            // 
            // b35
            // 
            this.b35.BackColor = System.Drawing.Color.Lime;
            this.b35.Location = new System.Drawing.Point(176, 136);
            this.b35.Name = "b35";
            this.b35.Size = new System.Drawing.Size(33, 23);
            this.b35.TabIndex = 91;
            this.b35.Text = "35";
            this.b35.UseVisualStyleBackColor = false;
            this.b35.Click += new System.EventHandler(this.b35_Click);
            // 
            // b34
            // 
            this.b34.BackColor = System.Drawing.Color.Lime;
            this.b34.Location = new System.Drawing.Point(136, 136);
            this.b34.Name = "b34";
            this.b34.Size = new System.Drawing.Size(33, 23);
            this.b34.TabIndex = 90;
            this.b34.Text = "34";
            this.b34.UseVisualStyleBackColor = false;
            this.b34.Click += new System.EventHandler(this.b34_Click);
            // 
            // b33
            // 
            this.b33.BackColor = System.Drawing.Color.Lime;
            this.b33.Location = new System.Drawing.Point(96, 136);
            this.b33.Name = "b33";
            this.b33.Size = new System.Drawing.Size(33, 23);
            this.b33.TabIndex = 89;
            this.b33.Text = "33";
            this.b33.UseVisualStyleBackColor = false;
            this.b33.Click += new System.EventHandler(this.b33_Click);
            // 
            // b32
            // 
            this.b32.BackColor = System.Drawing.Color.Lime;
            this.b32.Location = new System.Drawing.Point(57, 136);
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(33, 23);
            this.b32.TabIndex = 88;
            this.b32.Text = "32";
            this.b32.UseVisualStyleBackColor = false;
            this.b32.Click += new System.EventHandler(this.b32_Click);
            // 
            // b31
            // 
            this.b31.BackColor = System.Drawing.Color.Lime;
            this.b31.Location = new System.Drawing.Point(17, 136);
            this.b31.Name = "b31";
            this.b31.Size = new System.Drawing.Size(33, 23);
            this.b31.TabIndex = 87;
            this.b31.Text = "31";
            this.b31.UseVisualStyleBackColor = false;
            this.b31.Click += new System.EventHandler(this.b31_Click);
            // 
            // b30
            // 
            this.b30.BackColor = System.Drawing.Color.Lime;
            this.b30.Location = new System.Drawing.Point(372, 107);
            this.b30.Name = "b30";
            this.b30.Size = new System.Drawing.Size(33, 23);
            this.b30.TabIndex = 86;
            this.b30.Text = "30";
            this.b30.UseVisualStyleBackColor = false;
            this.b30.Click += new System.EventHandler(this.b30_Click);
            // 
            // b29
            // 
            this.b29.BackColor = System.Drawing.Color.Lime;
            this.b29.Location = new System.Drawing.Point(333, 107);
            this.b29.Name = "b29";
            this.b29.Size = new System.Drawing.Size(33, 23);
            this.b29.TabIndex = 85;
            this.b29.Text = "29";
            this.b29.UseVisualStyleBackColor = false;
            this.b29.Click += new System.EventHandler(this.b29_Click);
            // 
            // b28
            // 
            this.b28.BackColor = System.Drawing.Color.Lime;
            this.b28.Location = new System.Drawing.Point(294, 107);
            this.b28.Name = "b28";
            this.b28.Size = new System.Drawing.Size(33, 23);
            this.b28.TabIndex = 84;
            this.b28.Text = "28";
            this.b28.UseVisualStyleBackColor = false;
            this.b28.Click += new System.EventHandler(this.b28_Click);
            // 
            // b26
            // 
            this.b26.BackColor = System.Drawing.Color.Lime;
            this.b26.Location = new System.Drawing.Point(216, 107);
            this.b26.Name = "b26";
            this.b26.Size = new System.Drawing.Size(33, 23);
            this.b26.TabIndex = 83;
            this.b26.Text = "26";
            this.b26.UseVisualStyleBackColor = false;
            this.b26.Click += new System.EventHandler(this.b26_Click);
            // 
            // b27
            // 
            this.b27.BackColor = System.Drawing.Color.Lime;
            this.b27.Location = new System.Drawing.Point(255, 107);
            this.b27.Name = "b27";
            this.b27.Size = new System.Drawing.Size(33, 23);
            this.b27.TabIndex = 82;
            this.b27.Text = "27";
            this.b27.UseVisualStyleBackColor = false;
            this.b27.Click += new System.EventHandler(this.b27_Click);
            // 
            // b25
            // 
            this.b25.BackColor = System.Drawing.Color.Lime;
            this.b25.Location = new System.Drawing.Point(176, 107);
            this.b25.Name = "b25";
            this.b25.Size = new System.Drawing.Size(33, 23);
            this.b25.TabIndex = 81;
            this.b25.Text = "25";
            this.b25.UseVisualStyleBackColor = false;
            this.b25.Click += new System.EventHandler(this.b25_Click);
            // 
            // b24
            // 
            this.b24.BackColor = System.Drawing.Color.Lime;
            this.b24.Location = new System.Drawing.Point(136, 107);
            this.b24.Name = "b24";
            this.b24.Size = new System.Drawing.Size(33, 23);
            this.b24.TabIndex = 80;
            this.b24.Text = "24";
            this.b24.UseVisualStyleBackColor = false;
            this.b24.Click += new System.EventHandler(this.b24_Click);
            // 
            // b23
            // 
            this.b23.BackColor = System.Drawing.Color.Lime;
            this.b23.Location = new System.Drawing.Point(96, 107);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(33, 23);
            this.b23.TabIndex = 79;
            this.b23.Text = "23";
            this.b23.UseVisualStyleBackColor = false;
            this.b23.Click += new System.EventHandler(this.b23_Click);
            // 
            // b22
            // 
            this.b22.BackColor = System.Drawing.Color.Lime;
            this.b22.Location = new System.Drawing.Point(57, 107);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(33, 23);
            this.b22.TabIndex = 78;
            this.b22.Text = "22";
            this.b22.UseVisualStyleBackColor = false;
            this.b22.Click += new System.EventHandler(this.b22_Click);
            // 
            // b21
            // 
            this.b21.BackColor = System.Drawing.Color.Lime;
            this.b21.Location = new System.Drawing.Point(17, 107);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(33, 23);
            this.b21.TabIndex = 77;
            this.b21.Text = "21";
            this.b21.UseVisualStyleBackColor = false;
            this.b21.Click += new System.EventHandler(this.b21_Click);
            // 
            // b20
            // 
            this.b20.BackColor = System.Drawing.Color.Lime;
            this.b20.Location = new System.Drawing.Point(372, 78);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(33, 23);
            this.b20.TabIndex = 76;
            this.b20.Text = "20";
            this.b20.UseVisualStyleBackColor = false;
            this.b20.Click += new System.EventHandler(this.b20_Click);
            // 
            // b19
            // 
            this.b19.BackColor = System.Drawing.Color.Lime;
            this.b19.Location = new System.Drawing.Point(333, 78);
            this.b19.Name = "b19";
            this.b19.Size = new System.Drawing.Size(33, 23);
            this.b19.TabIndex = 75;
            this.b19.Text = "19";
            this.b19.UseVisualStyleBackColor = false;
            this.b19.Click += new System.EventHandler(this.b19_Click);
            // 
            // b18
            // 
            this.b18.BackColor = System.Drawing.Color.Lime;
            this.b18.Location = new System.Drawing.Point(294, 78);
            this.b18.Name = "b18";
            this.b18.Size = new System.Drawing.Size(33, 23);
            this.b18.TabIndex = 74;
            this.b18.Text = "18";
            this.b18.UseVisualStyleBackColor = false;
            this.b18.Click += new System.EventHandler(this.b18_Click);
            // 
            // b16
            // 
            this.b16.BackColor = System.Drawing.Color.Lime;
            this.b16.Location = new System.Drawing.Point(216, 78);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(33, 23);
            this.b16.TabIndex = 72;
            this.b16.Text = "16";
            this.b16.UseVisualStyleBackColor = false;
            this.b16.Click += new System.EventHandler(this.b16_Click);
            // 
            // b17
            // 
            this.b17.BackColor = System.Drawing.Color.Lime;
            this.b17.Location = new System.Drawing.Point(255, 78);
            this.b17.Name = "b17";
            this.b17.Size = new System.Drawing.Size(33, 23);
            this.b17.TabIndex = 73;
            this.b17.Text = "17";
            this.b17.UseVisualStyleBackColor = false;
            this.b17.Click += new System.EventHandler(this.b17_Click);
            // 
            // b15
            // 
            this.b15.BackColor = System.Drawing.Color.Lime;
            this.b15.Location = new System.Drawing.Point(176, 78);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(33, 23);
            this.b15.TabIndex = 71;
            this.b15.Text = "15";
            this.b15.UseVisualStyleBackColor = false;
            this.b15.Click += new System.EventHandler(this.b15_Click);
            // 
            // b14
            // 
            this.b14.BackColor = System.Drawing.Color.Lime;
            this.b14.Location = new System.Drawing.Point(136, 78);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(33, 23);
            this.b14.TabIndex = 70;
            this.b14.Text = "14";
            this.b14.UseVisualStyleBackColor = false;
            this.b14.Click += new System.EventHandler(this.b14_Click);
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.Lime;
            this.b13.Location = new System.Drawing.Point(96, 78);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(33, 23);
            this.b13.TabIndex = 69;
            this.b13.Text = "13";
            this.b13.UseVisualStyleBackColor = false;
            this.b13.Click += new System.EventHandler(this.b13_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.Lime;
            this.b12.Location = new System.Drawing.Point(57, 78);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(33, 23);
            this.b12.TabIndex = 64;
            this.b12.Text = "12";
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.Lime;
            this.b11.Location = new System.Drawing.Point(17, 78);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(33, 23);
            this.b11.TabIndex = 68;
            this.b11.Text = "11";
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.Lime;
            this.b10.Location = new System.Drawing.Point(372, 49);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(33, 23);
            this.b10.TabIndex = 67;
            this.b10.Text = "10";
            this.b10.UseVisualStyleBackColor = false;
            this.b10.Click += new System.EventHandler(this.b10_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Lime;
            this.b9.Location = new System.Drawing.Point(333, 49);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(33, 23);
            this.b9.TabIndex = 66;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Lime;
            this.b8.Location = new System.Drawing.Point(294, 49);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(33, 23);
            this.b8.TabIndex = 65;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Lime;
            this.b6.Location = new System.Drawing.Point(216, 49);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(33, 23);
            this.b6.TabIndex = 63;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Lime;
            this.b7.Location = new System.Drawing.Point(255, 49);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(33, 23);
            this.b7.TabIndex = 62;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Lime;
            this.b5.Location = new System.Drawing.Point(176, 49);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(33, 23);
            this.b5.TabIndex = 61;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Lime;
            this.b4.Location = new System.Drawing.Point(136, 49);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(33, 23);
            this.b4.TabIndex = 60;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Lime;
            this.b3.Location = new System.Drawing.Point(96, 49);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(33, 23);
            this.b3.TabIndex = 59;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Lime;
            this.b2.Location = new System.Drawing.Point(57, 49);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(33, 23);
            this.b2.TabIndex = 58;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Lime;
            this.b1.Location = new System.Drawing.Point(17, 49);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(33, 23);
            this.b1.TabIndex = 57;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Seleccionar butaca";
            // 
            // id_funcion
            // 
            this.id_funcion.HeaderText = "id_funcion";
            this.id_funcion.Name = "id_funcion";
            this.id_funcion.ReadOnly = true;
            this.id_funcion.Visible = false;
            // 
            // id_pelicula
            // 
            this.id_pelicula.HeaderText = "id_pelicula";
            this.id_pelicula.Name = "id_pelicula";
            this.id_pelicula.ReadOnly = true;
            this.id_pelicula.Visible = false;
            // 
            // id_sala
            // 
            this.id_sala.HeaderText = "id_sala";
            this.id_sala.Name = "id_sala";
            this.id_sala.ReadOnly = true;
            this.id_sala.Visible = false;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha Funcion";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // hora_inicio
            // 
            this.hora_inicio.HeaderText = "Hora";
            this.hora_inicio.Name = "hora_inicio";
            this.hora_inicio.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Sala";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // agotado
            // 
            this.agotado.HeaderText = "Agotado";
            this.agotado.Name = "agotado";
            this.agotado.ReadOnly = true;
            // 
            // FormAltaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.pnlContButacas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombFunc);
            this.Controls.Add(this.dgvFuncReser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltaReserva";
            this.Text = "FormAltaReserva";
            this.Load += new System.EventHandler(this.FormAltaReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncReser)).EndInit();
            this.pnlContButacas.ResumeLayout(false);
            this.pnlContButacas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvFuncReser;
        private TextBox txtNombFunc;
        private Label label1;
        private Button btnBuscar;
        private Button btnReservar;
        private ComboBox cboClientes;
        private Label label3;
        private Panel pnlContButacas;
        private Button b50;
        private Button b49;
        private Button b48;
        private Button b46;
        private Button b47;
        private Button b45;
        private Button b44;
        private Button b43;
        private Button b42;
        private Button b41;
        private Button b40;
        private Button b39;
        private Button b38;
        private Button b36;
        private Button b37;
        private Button b35;
        private Button b34;
        private Button b33;
        private Button b32;
        private Button b31;
        private Button b30;
        private Button b29;
        private Button b28;
        private Button b26;
        private Button b27;
        private Button b25;
        private Button b24;
        private Button b23;
        private Button b22;
        private Button b21;
        private Button b20;
        private Button b19;
        private Button b18;
        private Button b16;
        private Button b17;
        private Button b15;
        private Button b14;
        private Button b13;
        private Button b12;
        private Button b11;
        private Button b10;
        private Button b9;
        private Button b8;
        private Button b6;
        private Button b7;
        private Button b5;
        private Button b4;
        private Button b3;
        private Button b2;
        private Button b1;
        private Label label2;
        private DataGridViewTextBoxColumn id_funcion;
        private DataGridViewTextBoxColumn id_pelicula;
        private DataGridViewTextBoxColumn id_sala;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn hora_inicio;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn agotado;
    }
}