namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            string texto = txttexto.Text;
            lblmodificado.Text = texto;
        }
    }
}
