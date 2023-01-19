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
            btnNvaPelicula.Visible = false;
            dgvPeliculas.Dispose();
            btnEditar.Visible = false;
            btnBorrar.Visible = false;
            AbrirFormInPanel(new FormAltaPelicula(this.Service, lPeliculas));            
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {
            lPeliculas = Service.GetPeliculas();
            dgvPeliculas.DataSource = lPeliculas;
        }
    }
}
