using System.Diagnostics.Eventing.Reader;

namespace ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            string entrada = lblentrada.Text;
            double numero;

            if (double.TryParse(entrada, out numero)) 
            {
                MessageBox.Show("este es un valor numerico");
            }

            else
            {
                MessageBox.Show("error: por favor, ingrese un valor numerico", "entrada invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
