namespace ejercicio2
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
            lbltexto = new Label();
            btncambiar = new Button();
            SuspendLayout();
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.Font = new Font("Century Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltexto.Location = new Point(42, 69);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(406, 23);
            lbltexto.TabIndex = 0;
            lbltexto.Text = "toca el boton para modificar este texto";
            // 
            // btncambiar
            // 
            btncambiar.Font = new Font("Century Gothic", 10F);
            btncambiar.Location = new Point(147, 120);
            btncambiar.Name = "btncambiar";
            btncambiar.Size = new Size(149, 50);
            btncambiar.TabIndex = 1;
            btncambiar.Text = "cambiar";
            btncambiar.UseVisualStyleBackColor = true;
            btncambiar.Click += btncambiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(484, 230);
            Controls.Add(btncambiar);
            Controls.Add(lbltexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltexto;
        private Button btncambiar;
    }
}
