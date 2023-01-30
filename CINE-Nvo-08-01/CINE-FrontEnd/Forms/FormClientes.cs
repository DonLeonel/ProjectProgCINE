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
    public partial class FormClientes : Form
    {
        private IService Service;
        List<Cliente> lClientes { get; set; }
        
        public FormClientes(IService _Service)
        {
            InitializeComponent();
            this.Service = _Service;
        }

        public void AbrirFormInPanel(object formHijo) //Para poder abrir otros formularios dentro de el Panel Contenedor
        {
            if (this.PnlContClientes.Controls.Count > 0)
            {
                this.PnlContClientes.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlContClientes.Controls.Add(fh);
            this.PnlContClientes.Tag = fh;
            fh.Show();
        }

        private void OcultarComponentes()
        {
            btnNvoCliente.Visible = false;
            dgvClientes.Dispose();
            btnEditar.Visible = false;
            btnBorrar.Visible = false;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {
            lClientes = Service.GetClientes();
            dgvClientes.DataSource = lClientes;
            dgvClientes.Columns[0].Visible = false;
        }

        private void btnNvoCliente_Click(object sender, EventArgs e)
        {
            OcultarComponentes();
            AbrirFormInPanel(new FormAltaCliente(this.Service, lClientes));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idCliente = (int)dgvClientes.CurrentRow.Cells[0].Value;

            if (!idCliente.Equals(-1) || !idCliente.Equals(null))
            {
                OcultarComponentes();
                AbrirFormInPanel(new FormAltaCliente(this.Service, lClientes, idCliente));
            }
            else
            {
                MessageBox.Show("ERROR, indice fuera de rango!, debe seleccionar el cliente a Editar.", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
