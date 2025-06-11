namespace ejercicio7
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
            listBox1 = new ListBox();
            btnagregar = new Button();
            txtcontenido = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(474, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 0;
            // 
            // btnagregar
            // 
            btnagregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnagregar.Location = new Point(274, 118);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(112, 34);
            btnagregar.TabIndex = 1;
            btnagregar.Text = "agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // txtcontenido
            // 
            txtcontenido.Location = new Point(40, 118);
            txtcontenido.Name = "txtcontenido";
            txtcontenido.Size = new Size(150, 31);
            txtcontenido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 55);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 3;
            label1.Text = "ingrese el texto deseado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(693, 281);
            Controls.Add(label1);
            Controls.Add(txtcontenido);
            Controls.Add(btnagregar);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnagregar;
        private TextBox txtcontenido;
        private Label label1;
    }
}
