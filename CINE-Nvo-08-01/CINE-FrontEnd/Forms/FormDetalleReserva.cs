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
    public partial class FormDetalleReserva : Form
    {
        private IService Service;
        public int IdReser { get; set; }    
    

        public FormDetalleReserva(IService _service, int idReser)
        {
            InitializeComponent();
            this.Service = _service;
            this.IdReser = idReser;
        }

        private void FormDetalleReserva_Load(object sender, EventArgs e)
        {
            CargarDgv(IdReser);
        }

        private void CargarDgv(int id)
        {
            List<DetalleReserva> ldetRes = Service.GetDetalleReservas(id);
            
            foreach (DetalleReserva dtll in ldetRes)
            {
                dgvDetalleReserva.Rows.Add(new object[]
                {
                    dtll.Funcion.Pelicula.Titulo, dtll.Funcion.Fecha, dtll.Funcion.HoraInicio,
                    dtll.Funcion.Precio, dtll.Funcion.Sala.IdSala, dtll.Funcion.Sala.Tipo
                });
            }
        }
    }
}
