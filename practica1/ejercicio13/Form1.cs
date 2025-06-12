namespace ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 100;
            timer1.Tick += timer1_Tick_1;


            btniniciar.Click += btniniciar_Click;
            btndetener.Click += btndetener_Click_1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btndetener_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("carga completada");
            }
        }
    }
}
