namespace ejercicio15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnabrir = new Button();
            btnguardar = new Button();
            label1 = new Label();
            txtcontenido = new TextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnabrir
            // 
            btnabrir.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnabrir.Location = new Point(117, 351);
            btnabrir.Name = "btnabrir";
            btnabrir.Size = new Size(146, 44);
            btnabrir.TabIndex = 0;
            btnabrir.Text = "Abrir";
            btnabrir.UseVisualStyleBackColor = true;
            btnabrir.Click += btnabrir_Click;
            // 
            // btnguardar
            // 
            btnguardar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnguardar.Location = new Point(467, 351);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(146, 44);
            btnguardar.TabIndex = 1;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 147);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // txtcontenido
            // 
            txtcontenido.Location = new Point(117, 70);
            txtcontenido.Multiline = true;
            txtcontenido.Name = "txtcontenido";
            txtcontenido.Size = new Size(496, 236);
            txtcontenido.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtcontenido);
            Controls.Add(label1);
            Controls.Add(btnguardar);
            Controls.Add(btnabrir);
            Name = "Form1";
            Text = "Abrir y guardar archivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnabrir;
        private Button btnguardar;
        private Label label1;
        private TextBox txtcontenido;
    }
}
