namespace ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtcontenido.Text));
            {
                listBox1.Items.Add(txtcontenido.Text);
                txtcontenido.Clear();
            
            }
        }
    }
}
