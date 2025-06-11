namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (radio1.Checked)
                lblresultado.Text = "1";
            else if (radio2.Checked)
                lblresultado.Text = "2";
            else if (radio3.Checked)
                lblresultado.Text = "3";

            else
                lblresultado.Text = "no selecciono ninguna de las opciones.";
        }
    }
}
