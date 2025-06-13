namespace ejercicio16
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        double numero2 = 0;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(string numero)
        {
            txtresultado.Text += numero;
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            agregarNumero(boton.Text);

        }

        private void btnOperacion(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (txtresultado.Text != "")
            {
                numero1 = Convert.ToDouble(txtresultado.Text);
                operacion = boton.Text;
                txtresultado.Clear();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                numero2 = Convert.ToDouble(txtresultado.Text);
                double resultado = 0;

                switch (operacion)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        break;

                    case "/":
                        if (numero2 != 0)
                            resultado = numero1 / numero2;

                        else
                        {
                            MessageBox.Show("No se puede dividir por cero");
                            txtresultado.Clear();
                            return;
                        }

                    break;

                        
                }
                txtresultado.Text = resultado.ToString();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }
    }
}
