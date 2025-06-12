namespace ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtcelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;

                lblresultado.Text = fahrenheit.ToString("f2") + "°";
            }
            else
            {
                lblresultado.Text = "ingrese un numero valido.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
