namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnum1.Text, out double num1) &&
                double.TryParse(txtnum2.Text, out double num2))


            {
                double suma = num1 + num2;
                lblresultado.Text = " " + suma.ToString();

            }
            else 
            {
                MessageBox.Show("por favor, ingrese numeros validos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
    }
}
