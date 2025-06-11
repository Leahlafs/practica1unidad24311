namespace ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorseleccionado = comboBox1.SelectedItem.ToString();

            switch (colorseleccionado)
            {
                case "rojo":
                    this.BackColor = Color.Red;
                    break;

                case "verde":
                    this.BackColor = Color.Green;
                    break;

                case "azul":
                    this.BackColor = Color.Blue;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("rojo");
            comboBox1.Items.Add("verde");
            comboBox1.Items.Add("azul");

        }
    }
}
