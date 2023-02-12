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
    public partial class FormReservas : Form
    {
        private IService Service;
        public List<Reserva> lReservas { get; set; }
                
        public FormReservas(IService _Service)
        {
            InitializeComponent();
            Service = _Service;            
        }

        public void AbrirFormInPanel(object formHijo) //Para poder abrir otros formularios dentro de el Panel Contenedor
        {
            if (this.PnlContReservas.Controls.Count > 0)
            {
                this.PnlContReservas.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlContReservas.Controls.Add(fh);
            this.PnlContReservas.Tag = fh;
            fh.Show();
        }

        private void OcultarComponentes()
        {
            btnNvaReserva.Visible = false;
            dgvReservas.Dispose();
            btnEditar.Visible = false;
            btnBorrar.Visible = false;
            panel1.Visible = false;
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {
            lReservas = Service.GetReservas();
            foreach (Reserva res in lReservas)
            {
                dgvReservas.Rows.Add(new object[]
                {
                    res.Id_reserva, res.Cliente.NombCompleto, res.FechaReserva
                });
            }
        }

        private void btnNvaReserva_Click(object sender, EventArgs e)
        {
            OcultarComponentes();
            AbrirFormInPanel(new FormAltaReserva(this.Service, lReservas));
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (dgvReservas.CurrentCell.ColumnIndex == 3)
            { 
               new FormDetalleReserva(this.Service, (int)dgvReservas.CurrentRow.Cells[0].Value).ShowDialog(); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                lReservas = Service.GetReservaXCliente(txtNombre.Text);
                dgvReservas.Rows.Clear();
                foreach (Reserva res in lReservas)
                {
                    dgvReservas.Rows.Add(new object[]
                    {
                        res.Id_reserva, res.Cliente.NombCompleto, res.FechaReserva
                    });                    
                }
            }

            if (chbBuscarFecha.Checked)
            {

                lReservas = Service.GetReservaXFecha(dtpDesde.Value, dtpHasta.Value);
                dgvReservas.Rows.Clear();
                foreach (Reserva res in lReservas)
                {
                    dgvReservas.Rows.Add(new object[]
                    {
                        res.Id_reserva, res.Cliente.NombCompleto, res.FechaReserva
                    });
                }
            }
        }
    }
}
