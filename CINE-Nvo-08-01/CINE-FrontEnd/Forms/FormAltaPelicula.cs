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
        private bool Actualizar { get; set; }
        private int IdPeli { get; set; }
        private int Index;
        
        public FormAltaPelicula(IService _Service, List<Pelicula> lPelicula,int IdPel)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lPeliculas = lPelicula;
            this.IdPeli = IdPel;
            this.Index = this.IdPeli - 1;
            Actualizar = true;
        }

        public FormAltaPelicula(IService _Service, List<Pelicula> lPelicula)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lPeliculas = lPelicula;
            Actualizar = false;
        }

        private void CargarCampos(int Index)
        {
            txtTitulo.Text = lPeliculas[Index].Titulo.ToString();
            txtSinopsis.Text = lPeliculas[Index].Sinopsis.ToString();
            txtElenco.Text = lPeliculas[Index].Elenco.ToString();
            txtIdioma.Text = lPeliculas[Index].Idioma.ToString();
            txtDuracion.Text = lPeliculas[Index].Duracion.ToString();
            cboCalificacion.Text = lPeliculas[Index].Calificacion.ToString();
            cboGenero.Text = lPeliculas[Index].Genero.ToString();
            cboOrigen.Text = lPeliculas[Index].Origen.ToString();

            if (lPeliculas[Index].AptoTodoPublico.Equals(1))
            {
                chkbAptaTodoP.Checked = true;
            }
            if (lPeliculas[Index].Subtitulo.Equals(1))
            {
                chkbAptaTodoP.Checked = true;
            }
            
            int IdPeli = lPeliculas[Index].Id_pelicula;
        }

        private void LimpiarCampos()
        {
            txtTitulo.Text = txtSinopsis.Text  = txtElenco.Text = txtIdioma.Text = txtDuracion.Text = string.Empty;
            cboCalificacion.SelectedIndex = -1;
            cboOrigen.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            dtpFecEstreno.Value = DateTime.Today;
            chkbAptaTodoP.Checked = false;
            chkbSubtitulos.Checked = false;
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
            bool ok = true;

            if (string.IsNullOrEmpty(txtTitulo.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'TITULO'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtSinopsis.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'SINOPSIS'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtIdioma.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'IDIOMA'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtElenco.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'ELENCO'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtDuracion.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'DURACION'.", "CONTROL", MessageBoxButtons.OK); }
            else
            {
                try
                {
                    float.Parse(txtDuracion.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El campo 'DURACION' solo acepta numeros", "CONTROL", MessageBoxButtons.OK);
                    ok = false;
                }
            }
            if (cboCalificacion.SelectedIndex.Equals(-1)) { ok = false; MessageBox.Show("Debe seleccionar una Calificacion", "CONTROL", MessageBoxButtons.OK); }
            if (cboGenero.SelectedIndex.Equals(-1)) { ok = false; MessageBox.Show("Debe seleccionar una Genero", "CONTROL", MessageBoxButtons.OK); }
            if (cboOrigen.SelectedIndex.Equals(-1)) { ok = false; MessageBox.Show("Debe seleccionar una Origen", "CONTROL", MessageBoxButtons.OK); }

            return ok;
        }

        private void FormAltaPelicula_Load(object sender, EventArgs e)
        {
            CargarCombo(cboCalificacion,"SP_GET_CALIFICACIONES");
            CargarCombo(cboGenero,"SP_GET_GENEROS");
            CargarCombo(cboOrigen,"SP_GET_ORIGENES");
            if (Actualizar)
            { CargarCampos(this.Index); }
        }

        private void CargarCombo(ComboBox cbo, string sp)
        {
            DataTable dt = Service.Get(sp);
            cbo.DataSource = dt;
            cbo.ValueMember = dt.Columns[0].ColumnName;
            cbo.DisplayMember = dt.Columns[1].ColumnName;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (Valido())
            {
                DataRowView item = (DataRowView)cboCalificacion.SelectedItem;
                int IdCal = (int)item.Row.ItemArray[0];
                string DesCal = item.Row.ItemArray[1].ToString();
                Calificacion cal = new Calificacion(IdCal, DesCal);

                DataRowView item1 = (DataRowView)cboOrigen.SelectedItem;
                int IdOri = (int)item1.Row.ItemArray[0];
                string desOri = item1.Row.ItemArray[1].ToString();
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

                if (chkbAptaTodoP.Checked)
                { p.AptoTodoPublico = 1; }
                else { p.AptoTodoPublico = 0; }

                p.Idioma = txtIdioma.Text;
                if (chkbSubtitulos.Checked)
                { p.Subtitulo = 1; }
                else { p.Subtitulo = 0; }

                p.Origen = ori;
                p.Genero = gen;
         
                if (Actualizar)
                {
                    p.Id_pelicula = this.IdPeli;

                    if (Service.UpdatePelicula(p))
                    {
                        MessageBox.Show($"Se actualizo con exito la pelicula '{p.Titulo}'.", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("ERROR, No se pudo actualizar la Pelicula ", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!Existe(p))
                    {
                        if (Service.InsertPeliculas(p))
                        {
                            MessageBox.Show("Se inserto con exito una nueva pelicula!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("ERROR, No se pudo guardar la Pelicula indicada", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   
                }
            }
        }
    }
}
