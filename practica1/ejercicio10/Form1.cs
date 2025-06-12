namespace ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                string saludo = $"hola  {nombre} bienvenido a este formulario ";
                MessageBox.Show(saludo, "saludo");
            }
            else 
            {
                MessageBox.Show("por favor, escriba su nombre y matricula", "aviso");
            }
        }
    }
}
