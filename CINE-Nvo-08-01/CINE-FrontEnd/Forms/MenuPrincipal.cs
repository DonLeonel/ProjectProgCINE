using CINE_BackEnd.Services;
using CINE_BackEnd.Services.Interfaz;
using CINE_FrontEnd.Forms;
using System.Runtime.InteropServices;

namespace CINE_FrontEnd
{
    public partial class MenuPrincipal : Form
    {
        private IService Service;
        private FactoryServiceABS Factory;
        
        public MenuPrincipal()
        {
            InitializeComponent();
            Factory = new FactoryServiceIMP();
            Service = Factory.GetService();
        }      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenuDespl_Click(object sender, EventArgs e)
        {
            if (PanelVertival.Width.Equals(200))
            {
                PanelVertival.Width = 70;
            }
            else
            {
                PanelVertival.Width = 200;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SALIENDO, Esta seguro que quiere abandonar la App?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]  //Para poder arrastrar el formulario desde el panel Horizontal
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PanelHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AbrirFormInPanel(object formHijo) //Para poder abrir otros formularios dentro de el Panel Contenedor
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormPeliculas(this.Service));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormClientes(this.Service));
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormFunciones(this.Service));
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormReservas(this.Service));
        }
    }
}