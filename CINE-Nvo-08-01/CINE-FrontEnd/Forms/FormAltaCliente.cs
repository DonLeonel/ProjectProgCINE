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
    public partial class FormAltaCliente : Form
    {
        private IService Service;
        private List<Cliente> lCliente { get; set; }
        private bool Actualizar { get; set; }
        private int IdClient;
        private int Index;
        
        public FormAltaCliente(IService _Service, List<Cliente> lst)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lCliente = lst;
            Actualizar = false;
        }
        public FormAltaCliente(IService _Service, List<Cliente> lst, int idClient)
        {
            InitializeComponent();
            this.Service = _Service;
            this.lCliente = lst;
            this.IdClient = idClient;
            this.Index = this.IdClient - 1;
            Actualizar = true;
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            if (Actualizar)
            {
                CargarCampos(this.Index);
            }
        }

        private void CargarCampos(int index)
        {
            txtNombre.Text = lCliente[index].Nombre.ToString();
            txtApellido.Text = lCliente[index].Apellido.ToString();
            dtpFecNac.Value = lCliente[index].FechaNac;
            txtCalle.Text = lCliente[index].Calle.ToString();
            txtAltura.Text = lCliente[index].Altura.ToString();
            txtTelefono.Text = lCliente[index].Telefono.ToString();
            txtMail.Text = lCliente[index].Mail.ToString();            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                Cliente c = new Cliente();
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.FechaNac = dtpFecNac.Value;
                c.Calle = txtCalle.Text;
                c.Altura = Convert.ToInt32(txtAltura.Text);
                c.Telefono = txtTelefono.Text;
                c.Mail = txtMail.Text;

                if (Actualizar)
                {
                    c.IdCliente = this.IdClient;

                    if (Service.UpdateCliente(c))
                    {
                        MessageBox.Show($"Se actualizo con exito el Cliente: '{c.Nombre}, {c.Apellido}'.", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("ERROR, No se pudo actualizar el Cliente ", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!Existe(c))
                    {
                        if (Service.InsertCliente(c))
                        {
                            MessageBox.Show("Se inserto con exito una nueva Cliente!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("ERROR, No se pudo insertar el nuevo Cliente!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = txtApellido.Text = txtCalle.Text = txtAltura.Text = txtTelefono.Text = txtMail.Text = string.Empty;
            dtpFecNac.Value = DateTime.Today;
        }

        private bool Existe(Cliente c)
        {
            foreach (Cliente client in lCliente)
            {
                if ((c.Nombre.ToLower().Equals(client.Nombre.ToLower())) && c.Apellido.ToLower().Equals(client.Apellido.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }     

        private bool Valido()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNombre.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'NOMBRE'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtApellido.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'APELLIDO'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtCalle.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'CALLE'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtAltura.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'ALTURA'.", "CONTROL", MessageBoxButtons.OK); }
            else
            {
                try
                {
                    int.Parse(txtAltura.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El campo 'ALTURA' solo acepta numeros Enteros", "CONTROL", MessageBoxButtons.OK);
                    ok = false;
                }
            }
            if (string.IsNullOrEmpty(txtTelefono.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'TELEFONO'.", "CONTROL", MessageBoxButtons.OK); }
            if (string.IsNullOrEmpty(txtMail.Text)) { ok = false; MessageBox.Show("Debe completar el campo 'MAIL'.", "CONTROL", MessageBoxButtons.OK); }
           
            if(DateTime.Today.Year - dtpFecNac.Value.Year < 10)
            {
                ok = false;
                MessageBox.Show("El clientes debe ser mayor o igual a 10 años", "CONTROL", MessageBoxButtons.OK);
            }

            return ok;
        }
    }
}
