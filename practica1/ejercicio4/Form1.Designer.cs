namespace ejercicio4
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
            lblresultado = new Label();
            label4 = new Label();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            btnsumar = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(114, 123);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "NUM1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(114, 178);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "NUM2";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblresultado.Location = new Point(210, 305);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 25);
            lblresultado.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(161, 63);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 3;
            label4.Text = "SUMA DE NUMEROS";
            // 
            // txtnum1
            // 
            txtnum1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtnum1.Location = new Point(190, 117);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(150, 31);
            txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            txtnum2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtnum2.Location = new Point(190, 178);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(150, 31);
            txtnum2.TabIndex = 5;
            // 
            // btnsumar
            // 
            btnsumar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnsumar.Location = new Point(143, 240);
            btnsumar.Name = "btnsumar";
            btnsumar.Size = new Size(214, 34);
            btnsumar.TabIndex = 6;
            btnsumar.Text = "SUMAR CANTIDADES";
            btnsumar.UseVisualStyleBackColor = true;
            btnsumar.Click += btnsumar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(114, 305);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 7;
            label5.Text = "TOTAL :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 395);
            Controls.Add(label5);
            Controls.Add(btnsumar);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(label4);
            Controls.Add(lblresultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblresultado;
        private Label label4;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private Button btnsumar;
        private Label label5;
    }
}
