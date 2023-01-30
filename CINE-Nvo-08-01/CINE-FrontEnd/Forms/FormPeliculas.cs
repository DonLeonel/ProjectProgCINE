using CINE_BackEnd.Models;
using CINE_BackEnd.Services.Interfaz;
using CINE_FrontEnd.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINE_FrontEnd
{
    public partial class FormPeliculas : Form
    {
        private IService Service;
        private List<Pelicula> lPeliculas { get; set; }
        
        public FormPeliculas(IService _Service)
        {
            InitializeComponent();
            this.Service = _Service;
        }

        public void AbrirFormInPanel(object formHijo) //Para poder abrir otros formularios dentro de el Panel Contenedor
        {
            if (this.PanelContPeliculas.Controls.Count > 0)
            {
                this.PanelContPeliculas.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContPeliculas.Controls.Add(fh);
            this.PanelContPeliculas.Tag = fh;
            fh.Show();
        }

        private void btnNvaPelicula_Click_1(object sender, EventArgs e)
        {
            OcultarComponentes();
            AbrirFormInPanel(new FormAltaPelicula(this.Service, lPeliculas));            
        }

        private void OcultarComponentes()
        {
            btnNvaPelicula.Visible = false;
            dgvPeliculas.Dispose();
            btnEditar.Visible = false;
            btnBorrar.Visible = false;
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {
            lPeliculas = Service.GetPeliculas();
            dgvPeliculas.DataSource = lPeliculas;
            dgvPeliculas.Columns[0].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdPeli = (int)dgvPeliculas.CurrentRow.Cells[0].Value;
            
            if (!IdPeli.Equals(-1) || !IdPeli.Equals(null))
            {
                OcultarComponentes();
                AbrirFormInPanel(new FormAltaPelicula(this.Service, lPeliculas, IdPeli));
            }
            else
            {
                MessageBox.Show("ERROR, indice fuera de rango!, debe seleccionar la pelicula a Editar.", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int IdPeli = (int)dgvPeliculas.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Esta seguro que quiere dar de baja esta pelicula? (borrado logico).", "CONTROL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).Equals(DialogResult.Yes))
            {
                if (Service.DeletePelicula(IdPeli))
                {
                    MessageBox.Show($"Se borro con exito la pelicula", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDgv();
                }
                else
                {
                    MessageBox.Show("ERROR, No se pudo borrar la Pelicula ", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }
    }
}
