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
    public partial class FormFunciones :  Form
    {
        private IService Service;
        private List<Funcion> lFunciones { get; set; }
     
        public FormFunciones(IService _Service)
        {
            InitializeComponent();           
            this.Service = _Service;           
        }
      
        private void FormFunciones_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {
            lFunciones = Service.GetFunciones();
            dgvFunciones.DataSource = lFunciones;
            //dgvFunciones.Columns[0].Visible = false;
        }         

        public void AbrirFormInPanel(object formHijo) //Para poder abrir otros formularios dentro de el Panel Contenedor
        {
            if (this.PnlContFunciones.Controls.Count > 0)
            {
                this.PnlContFunciones.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlContFunciones.Controls.Add(fh);
            this.PnlContFunciones.Tag = fh;
            fh.Show();
        }

        private void OcultarComponentes()
        {
            btnNvaFuncion.Visible = false;
            dgvFunciones.Dispose();
            btnEditar.Visible = false;
            btnBorrar.Visible = false;
        }

        private void btnNvaFuncion_Click(object sender, EventArgs e)
        {
            OcultarComponentes();
            AbrirFormInPanel(new FormAltaFuncion(this.Service, lFunciones));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
