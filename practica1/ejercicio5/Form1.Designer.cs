namespace ejercicio5
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
            radio1 = new RadioButton();
            radio2 = new RadioButton();
            btnseleccionar = new Button();
            radio3 = new RadioButton();
            lblresultado = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(69, 167);
            radio1.Name = "radio1";
            radio1.Size = new Size(115, 29);
            radio1.TabIndex = 0;
            radio1.TabStop = true;
            radio1.Text = "opccion 1";
            radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Location = new Point(249, 167);
            radio2.Name = "radio2";
            radio2.Size = new Size(107, 29);
            radio2.TabIndex = 1;
            radio2.TabStop = true;
            radio2.Text = "opcion 2";
            radio2.UseVisualStyleBackColor = true;
            // 
            // btnseleccionar
            // 
            btnseleccionar.Location = new Point(265, 232);
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.Size = new Size(112, 34);
            btnseleccionar.TabIndex = 2;
            btnseleccionar.Text = "seleccionar";
            btnseleccionar.UseVisualStyleBackColor = true;
            btnseleccionar.Click += btnseleccionar_Click;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Location = new Point(423, 167);
            radio3.Name = "radio3";
            radio3.Size = new Size(115, 29);
            radio3.TabIndex = 3;
            radio3.TabStop = true;
            radio3.Text = "opccion 3";
            radio3.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(352, 297);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 25);
            lblresultado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 297);
            label2.Name = "label2";
            label2.Size = new Size(276, 25);
            label2.TabIndex = 5;
            label2.Text = "Usted ha seleccionado la opcion: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 70);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 6;
            label1.Text = "seleccione una de estas opciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblresultado);
            Controls.Add(radio3);
            Controls.Add(btnseleccionar);
            Controls.Add(radio2);
            Controls.Add(radio1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radio1;
        private RadioButton radio2;
        private Button btnseleccionar;
        private RadioButton radio3;
        private Label lblresultado;
        private Label label2;
        private Label label1;
    }
}
