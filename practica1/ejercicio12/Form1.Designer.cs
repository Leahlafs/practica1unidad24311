namespace ejercicio12
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
            label1 = new Label();
            label2 = new Label();
            txtcelsius = new TextBox();
            lblresultado = new Label();
            btnconvertir = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 60);
            label1.Name = "label1";
            label1.Size = new Size(473, 23);
            label1.TabIndex = 0;
            label1.Text = "Convertir temperaturas de Celsius a Fahrenheit.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 136);
            label2.Name = "label2";
            label2.Size = new Size(213, 23);
            label2.TabIndex = 1;
            label2.Text = "Temperatura Celsius ";
            // 
            // txtcelsius
            // 
            txtcelsius.Location = new Point(305, 136);
            txtcelsius.Name = "txtcelsius";
            txtcelsius.Size = new Size(150, 31);
            txtcelsius.TabIndex = 2;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(1034, 147);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 23);
            lblresultado.TabIndex = 3;
            // 
            // btnconvertir
            // 
            btnconvertir.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnconvertir.Location = new Point(477, 136);
            btnconvertir.Name = "btnconvertir";
            btnconvertir.Size = new Size(242, 34);
            btnconvertir.TabIndex = 4;
            btnconvertir.Text = "Convertir a Fahrenheit";
            btnconvertir.UseVisualStyleBackColor = true;
            btnconvertir.Click += btnconvertir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(757, 147);
            label3.Name = "label3";
            label3.Size = new Size(252, 23);
            label3.TabIndex = 5;
            label3.Text = " Temperatura Fahrenheit:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1225, 314);
            Controls.Add(label3);
            Controls.Add(btnconvertir);
            Controls.Add(lblresultado);
            Controls.Add(txtcelsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Convertir temperaturas de Celsius a Fahrenheit";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcelsius;
        private Label lblresultado;
        private Button btnconvertir;
        private Label label3;
    }
}
