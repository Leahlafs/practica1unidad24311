using System;
using System.IO;
using System.Windows.Forms;


namespace ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|todos los archvos (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaarchovo = openFileDialog1.FileName;
                string contenido = File.ReadAllText(rutaarchovo);
                txtcontenido.Text = contenido;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|todos los archivos (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string rutaArchivo = saveFileDialog1.FileName;
                File.WriteAllText(rutaArchivo, txtcontenido.Text);
                MessageBox.Show("archivo guardado correctamente");
            }
        }
    }
}
