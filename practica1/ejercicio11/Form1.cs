namespace ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblselecionfecha.Text = dateTimePicker1.Value.ToString("dd /MM /yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
