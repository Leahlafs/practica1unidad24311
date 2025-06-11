namespace ejercicio3
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
            btnescribir = new Button();
            txttexto = new TextBox();
            lblmodificado = new Label();
            SuspendLayout();
            // 
            // btnescribir
            // 
            btnescribir.Location = new Point(125, 129);
            btnescribir.Name = "btnescribir";
            btnescribir.Size = new Size(182, 34);
            btnescribir.TabIndex = 0;
            btnescribir.Text = "escribir este texto";
            btnescribir.UseVisualStyleBackColor = true;
            btnescribir.Click += btnescribir_Click;
            // 
            // txttexto
            // 
            txttexto.Location = new Point(125, 79);
            txttexto.Name = "txttexto";
            txttexto.Size = new Size(195, 31);
            txttexto.TabIndex = 1;
            // 
            // lblmodificado
            // 
            lblmodificado.AutoSize = true;
            lblmodificado.Location = new Point(183, 205);
            lblmodificado.Name = "lblmodificado";
            lblmodificado.Size = new Size(0, 25);
            lblmodificado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 321);
            Controls.Add(lblmodificado);
            Controls.Add(txttexto);
            Controls.Add(btnescribir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnescribir;
        private TextBox txttexto;
        private Label lblmodificado;
    }
}
