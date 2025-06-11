namespace ejercicio8
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
            lblresultado = new Label();
            btncontar = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(96, 139);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 25);
            lblresultado.TabIndex = 0;
            // 
            // btncontar
            // 
            btncontar.Location = new Point(164, 84);
            btncontar.Name = "btncontar";
            btncontar.Size = new Size(112, 34);
            btncontar.TabIndex = 1;
            btncontar.Text = "contar";
            btncontar.UseVisualStyleBackColor = true;
            btncontar.Click += btncontar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 35);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 2;
            label2.Text = "acomulador de clicks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 124);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 198);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btncontar);
            Controls.Add(lblresultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblresultado;
        private Button btncontar;
        private Label label2;
        private Label label1;
    }
}
