namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            lbltexto.Text = "este texto ha sido modificado";
        }
    }
}
