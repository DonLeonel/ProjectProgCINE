using CINE_BackEnd.Models;
using CINE_BackEnd.Services.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINE_FrontEnd.Forms
{
    public partial class FormAltaReserva : Form
    {
        private IService Service;
        private List<Reserva> lReservas;
        private List<Funcion> lFunciones { get; set; }
        private bool Actualizar;
        private int idReserva { get; set; }
        private int Index { get; set; }
        public Reserva Reserva;

        public FormAltaReserva(IService _Service, List<Reserva> lst)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lReservas = lst;
            Actualizar = false;
            Reserva = new Reserva();
        }

        public FormAltaReserva(IService _Service, List<Reserva> lst, int idReser)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lReservas = lst;
            this.idReserva = idReser;
            this.Index = idReserva - 1;
            Actualizar = true;
            Reserva = new Reserva();
        }

        private void FormAltaReserva_Load(object sender, EventArgs e)
        {
            CargarDgv();
            CargarCombo();
        }

        private void CargarCombo()
        {
            cboClientes.DataSource = Service.GetClientes();
            cboClientes.ValueMember = "IdCliente";
            cboClientes.DisplayMember = "Nombre"; 
        }

        private void CargarDgv()
        {
            lFunciones = Service.GetFuncionReserva();
            foreach (Funcion fun in lFunciones)
            {
                dgvFuncReser.Rows.Add(new object[]
                {
                    fun.IdFuncion, fun.Pelicula.Id_pelicula, fun.Sala.IdSala, fun.Fecha,
                    fun.HoraInicio,fun.Precio, fun.Pelicula.Titulo, fun.Sala.Tipo, fun.Agotado
                });
            }
            
        }        

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                              
                Sala Sal = new Sala();
                Sal.IdSala = (int)dgvFuncReser.CurrentRow.Cells[2].Value;
                //Sal.Butacas = But;

                Pelicula Peli = new Pelicula();
                Peli.Id_pelicula = (int)dgvFuncReser.CurrentRow.Cells[1].Value;
                Peli.Titulo = dgvFuncReser.CurrentRow.Cells[6].Value.ToString();

                Funcion Fun = new Funcion();
                Fun.IdFuncion = (int)dgvFuncReser.CurrentRow.Cells[0].Value;
                Fun.Sala = Sal;
                Fun.Pelicula = Peli;

                DetalleReserva dtll = new DetalleReserva();
                dtll.Funcion = Fun;
                dtll.Cantidad = 1;

                
                Cliente Client = (Cliente)cboClientes.SelectedItem;
                
                this.Reserva.FechaReserva = DateTime.Now;
                this.Reserva.Cliente = Client;
                this.Reserva.AddDtlleReserva(dtll);

                if (Service.InsertReserva(Reserva))
                {
                    MessageBox.Show("Se Genero con exito una Nueva Reserva!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("ERROR, No se pudo Generar la Reserva, Por favor verifique!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                
                
            }
        }

        private void Limpiar()
        {
            cboClientes.SelectedIndex = -1;           
        }

        private bool Valido()
        {
            return true;
        }

        public void Seleccionador(Button btn)
        {
            if (btn.BackColor.Equals(Color.Lime))
            { btn.BackColor = Color.Red; }
            else { btn.BackColor = Color.Lime; }
        }


#region Botones Butacas 
        private void b1_Click(object sender, EventArgs e)
        {
            Seleccionador(b1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Seleccionador(b2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Seleccionador(b3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Seleccionador(b4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Seleccionador(b5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Seleccionador(b6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Seleccionador(b7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Seleccionador(b8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Seleccionador(b9);
        }

        private void b10_Click(object sender, EventArgs e)
        {
            Seleccionador(b10);        
        }

        private void b11_Click(object sender, EventArgs e)
        {
            Seleccionador(b11);
        }

        private void b12_Click(object sender, EventArgs e)
        {
            Seleccionador(b12);
        }

        private void b13_Click(object sender, EventArgs e)
        {
            Seleccionador(b13);
        }

        private void b14_Click(object sender, EventArgs e)
        {
            Seleccionador(b14);
        }

        private void b15_Click(object sender, EventArgs e)
        {
            Seleccionador(b15);
        }

        private void b16_Click(object sender, EventArgs e)
        {
            Seleccionador(b16);
        }

        private void b17_Click(object sender, EventArgs e)
        {
            Seleccionador(b17);
        }

        private void b18_Click(object sender, EventArgs e)
        {
            Seleccionador(b18);
        }

        private void b19_Click(object sender, EventArgs e)
        {
            Seleccionador(b19);
        }

        private void b20_Click(object sender, EventArgs e)
        {
            Seleccionador(b20);
        }

        private void b21_Click(object sender, EventArgs e)
        {
            Seleccionador(b21);
        }

        private void b22_Click(object sender, EventArgs e)
        {
            Seleccionador(b22);
        }

        private void b23_Click(object sender, EventArgs e)
        {
            Seleccionador(b23);
        }

        private void b24_Click(object sender, EventArgs e)
        {
            Seleccionador(b24);
        }

        private void b25_Click(object sender, EventArgs e)
        {
            Seleccionador(b25);
        }

        private void b26_Click(object sender, EventArgs e)
        {
            Seleccionador(b26);
        }

        private void b27_Click(object sender, EventArgs e)
        {
            Seleccionador(b27);
        }

        private void b28_Click(object sender, EventArgs e)
        {
            Seleccionador(b28);
        }

        private void b29_Click(object sender, EventArgs e)
        {
            Seleccionador(b29);
        }

        private void b30_Click(object sender, EventArgs e)
        {
            Seleccionador(b30);
        }

        private void b31_Click(object sender, EventArgs e)
        {
            Seleccionador(b31);
        }

        private void b32_Click(object sender, EventArgs e)
        {
            Seleccionador(b32);
        }

        private void b33_Click(object sender, EventArgs e)
        {
            Seleccionador(b33);
        }

        private void b34_Click(object sender, EventArgs e)
        {
            Seleccionador(b34);
        }

        private void b35_Click(object sender, EventArgs e)
        {
            Seleccionador(b35);
        }

        private void b36_Click(object sender, EventArgs e)
        {
            Seleccionador(b36);
        }

        private void b37_Click(object sender, EventArgs e)
        {
            Seleccionador(b37);
        }

        private void b38_Click(object sender, EventArgs e)
        {
            Seleccionador(b38);
        }

        private void b39_Click(object sender, EventArgs e)
        {
            Seleccionador(b39);
        }

        private void b40_Click(object sender, EventArgs e)
        {
            Seleccionador(b40);
        }

        private void b41_Click(object sender, EventArgs e)
        {
            Seleccionador(b41);
        }

        private void b42_Click(object sender, EventArgs e)
        {
            Seleccionador(b42);
        }

        private void b43_Click(object sender, EventArgs e)
        {
            Seleccionador(b43);
        }

        private void b44_Click(object sender, EventArgs e)
        {
            Seleccionador(b44);
        }

        private void b45_Click(object sender, EventArgs e)
        {
            Seleccionador(b45);
        }

        private void b46_Click(object sender, EventArgs e)
        {
            Seleccionador(b46);
        }

        private void b47_Click(object sender, EventArgs e)
        {
            Seleccionador(b47);
        }

        private void b48_Click(object sender, EventArgs e)
        {
            Seleccionador(b48);
        }

        private void b49_Click(object sender, EventArgs e)
        {
            Seleccionador(b49);
        }

        private void b50_Click(object sender, EventArgs e)
        {
            Seleccionador(b50);
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombFunc.Text))                
            {
                lFunciones = Service.GetFuncionXNombre(txtNombFunc.Text);
                dgvFuncReser.Rows.Clear();
                foreach (Funcion fun in lFunciones)
                {
                    dgvFuncReser.Rows.Add(new object[]
                    {
                    fun.IdFuncion, fun.Pelicula.Id_pelicula, fun.Sala.IdSala, fun.Fecha,
                    fun.HoraInicio,fun.Precio, fun.Pelicula.Titulo, fun.Sala.Tipo, fun.Agotado
                    });
                }
            }          
        }
    }
}
