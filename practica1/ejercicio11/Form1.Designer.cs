namespace ejercicio11
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
            dateTimePicker1 = new DateTimePicker();
            lblselecionfecha = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 10F);
            dateTimePicker1.Location = new Point(56, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(429, 32);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblselecionfecha
            // 
            lblselecionfecha.AutoSize = true;
            lblselecionfecha.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            lblselecionfecha.Location = new Point(369, 189);
            lblselecionfecha.Name = "lblselecionfecha";
            lblselecionfecha.Size = new Size(0, 23);
            lblselecionfecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.Location = new Point(56, 189);
            label1.Name = "label1";
            label1.Size = new Size(307, 23);
            label1.TabIndex = 2;
            label1.Text = "esta es la feca seleccionada: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 71);
            label2.Name = "label2";
            label2.Size = new Size(264, 23);
            label2.TabIndex = 3;
            label2.Text = "Indique la fecha deseada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(689, 285);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblselecionfecha);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "seleccion de fecha";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblselecionfecha;
        private Label label1;
        private Label label2;
    }
}
