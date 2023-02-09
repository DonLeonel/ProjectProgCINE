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
    public partial class FormAltaFuncion : Form
    {
        private IService Service;
        private List<Funcion> lFunciones;
        private int Index;
        private int IdFunc;
        private bool Actualizar;

        public FormAltaFuncion(IService _Service, List<Funcion> lst)
        {
            InitializeComponent();
            this.Service = _Service;
            this.Actualizar = false;
            this.lFunciones = lst;
        }

        public FormAltaFuncion(IService _Service, List<Funcion> lst, int idFunc)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lFunciones = lst;
            this.IdFunc = idFunc;
            this.Index = idFunc - 1;
            this.Actualizar = true;
        }

        private void FormAltaFuncion_Load(object sender, EventArgs e)
        {
            if (Actualizar)
            {
                //CargarCampos(Index);
            }
            CargarCombo(cboPeliculas, "SP_GET_PELICULAS");
            CargarCombo(cboSala, "SP_GET_SALAS");
            dtpFechayHora.Value = DateTime.Now;
        }

        private void CargarCombo(ComboBox combo, string SP)
        {
            var dt = Service.Get(SP);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
        }

        private void CargarCampos(int index)
        {
            dtpFechayHora.Value = lFunciones[index].Fecha;
            txtPrecio.Text = lFunciones[index].Precio.ToString();
            cboPeliculas.Text = lFunciones[index].Pelicula.Titulo;
            cboSala.Text = lFunciones[index].Sala.Tipo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                Pelicula p = new Pelicula();
                DataRowView Item = (DataRowView)cboPeliculas.SelectedItem;
                p.Id_pelicula = (int)Item.Row.ItemArray[0];

                Sala s = new Sala();
                DataRowView Item1 = (DataRowView)cboSala.SelectedItem;
                s.IdSala = (int)Item1.Row.ItemArray[0];

                Funcion Func = new Funcion();
                Func.HoraInicio = dtpFechayHora.Value;
                Func.Fecha = dtpFechayHora.Value;
                Func.Precio = Convert.ToDouble(txtPrecio.Text);
                Func.Pelicula = p;
                Func.Sala = s;

                if (Actualizar)
                {
                    Func.IdFuncion = this.IdFunc;

                    if (Service.UpdateFuncion(Func))
                    {
                        MessageBox.Show($"Se actualizo con exito la Funcion seleccionada.", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("ERROR, No se pudo actualizar la Funcion seleccionada ", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    if (!Existe(Func))
                    {
                        if (Service.InsertFuncion(Func))
                        {
                            MessageBox.Show($"Se inserto con exito una nueva Funcion.", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("ERROR, No se pudo insertar la funcion", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            dtpFechayHora.Value = DateTime.Today;
            txtPrecio.Text = string.Empty;
            cboPeliculas.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
        }

        private bool Existe(Funcion func)
        {
            foreach (Funcion fun in lFunciones)
            {
                if (fun.HoraInicio.TimeOfDay.Equals(func.HoraInicio.TimeOfDay) && (fun.Sala.Equals(func.Sala)))
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
    }
}
