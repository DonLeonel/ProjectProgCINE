using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CINE_BackEnd.Models;
using CINE_BackEnd.Services.Interfaz;

namespace CINE_FrontEnd.Forms
{
    public partial class FormAltaPelicula : Form
    {
        private IService Service;
        private List<Pelicula> lPeliculas { get; set; }
        
        public FormAltaPelicula(IService _Service, List<Pelicula> lPelicula)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lPeliculas = lPelicula;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                              
                DataRowView item = (DataRowView)cboCalificacion.SelectedItem;
                 int IdCal= (int)item.Row.ItemArray[0];
                 string DesCal = item.Row.ItemArray[1].ToString();
                Calificacion cal = new Calificacion(IdCal, DesCal);

                DataRowView item1 = (DataRowView)cboOrigen.SelectedItem;
                int IdOri= (int)item1.Row.ItemArray[0];
                string desOri= item1.Row.ItemArray[1].ToString();
                Origen ori = new Origen(IdOri, desOri);

                DataRowView item2 = (DataRowView)cboGenero.SelectedItem;
                int IdGen = (int)item2.Row.ItemArray[0];
                string DesGen = item2.Row.ItemArray[1].ToString();
                Genero gen = new Genero(IdGen, DesGen);

                Pelicula p = new Pelicula();

                p.Titulo = txtTitulo.Text;
                p.Sinopsis = txtSinopsis.Text;
                p.FechaEstreno = dtpFecEstreno.Value;
                p.Elenco = txtElenco.Text;
                p.Duracion = float.Parse(txtDuracion.Text);
                p.Calificacion = cal;
                
                if (rbtAptaTodoP.Checked)
                    p.AptoTodoPublico = 1;
                p.AptoTodoPublico = 0;
                p.Idioma = txtIdioma.Text;
                if (rbtSubtitulos.Checked)
                    p.Subtitulo = 1;
                p.Subtitulo = 0;

                p.Origen = ori;
                p.Genero = gen;
               

                if (!Existe(p))
                {
                    if (Service.InsertPeliculas(p))
                    {
                        MessageBox.Show("Se inserto con exito una nueva pelicula!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR, No se pudo guardar la Pelicula indicada", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"La Pelicula '{p.ToString()}' ya se encuentra en la lista de Peliculas", "CONTROL", MessageBoxButtons.OK);
                }
            }
        }

        private bool Existe(Pelicula p)
        {

            foreach (Pelicula peli in lPeliculas)
            {
                if (p.Titulo.ToLower().Equals(peli.Titulo.ToLower()))
                {
                    return true;
                }
            }
            return false;

        }

        private bool Valido()
        {
            return true;
        }

        private void FormAltaPelicula_Load(object sender, EventArgs e)
        {
            CargarCombo(cboCalificacion,"SP_GET_CALIFICACIONES");
            CargarCombo(cboGenero,"SP_GET_GENEROS");
            CargarCombo(cboOrigen,"SP_GET_ORIGENES");
        }

        private void CargarCombo(ComboBox cbo, string sp)
        {
            DataTable dt = Service.Get(sp);
            cbo.DataSource = dt;
            cbo.ValueMember = dt.Columns[0].ColumnName;
            cbo.DisplayMember = dt.Columns[1].ColumnName;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
