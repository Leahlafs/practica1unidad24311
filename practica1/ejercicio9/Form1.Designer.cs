namespace ejercicio9
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
            btnvalidar = new Button();
            lblentrada = new TextBox();
            SuspendLayout();
            // 
            // btnvalidar
            // 
            btnvalidar.Location = new Point(172, 156);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(112, 34);
            btnvalidar.TabIndex = 0;
            btnvalidar.Text = "validar";
            btnvalidar.UseVisualStyleBackColor = true;
            btnvalidar.Click += btnvalidar_Click;
            // 
            // lblentrada
            // 
            lblentrada.Location = new Point(153, 89);
            lblentrada.Name = "lblentrada";
            lblentrada.Size = new Size(150, 31);
            lblentrada.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 337);
            Controls.Add(lblentrada);
            Controls.Add(btnvalidar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvalidar;
        private TextBox lblentrada;
    }
}
