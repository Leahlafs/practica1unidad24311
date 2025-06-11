namespace ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;
        private void btncontar_Click(object sender, EventArgs e)
        {
            contador++;

            lblresultado.Text = $"usted ha precionado este boton: {contador} veces";
        }
    }
}
