using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace tpConeProgII
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("USER32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd , int wmsg, int wparam, int lparam);

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
            }
            else
                menuVertical.Width = 250; 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTamaño_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            releaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }
    }
}
