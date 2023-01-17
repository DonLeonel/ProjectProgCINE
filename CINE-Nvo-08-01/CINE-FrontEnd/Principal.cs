namespace CINE_FrontEnd
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelVertical.Width == 200)
            {
                PanelVertical.Width = 70;
            }
            else
            {
                PanelVertical.Width = 200;
            }
        }
    }
}