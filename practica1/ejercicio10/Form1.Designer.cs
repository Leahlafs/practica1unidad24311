namespace ejercicio10
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
            txtnombre = new TextBox();
            btnsaludar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 90);
            label1.Name = "label1";
            label1.Size = new Size(445, 26);
            label1.TabIndex = 0;
            label1.Text = "por favar, ingrese su nombre y matricula";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = SystemColors.ControlLightLight;
            txtnombre.Font = new Font("Century Gothic", 11F);
            txtnombre.Location = new Point(159, 141);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(315, 34);
            txtnombre.TabIndex = 1;
            // 
            // btnsaludar
            // 
            btnsaludar.BackColor = Color.MistyRose;
            btnsaludar.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsaludar.Location = new Point(196, 197);
            btnsaludar.Name = "btnsaludar";
            btnsaludar.Size = new Size(218, 34);
            btnsaludar.TabIndex = 2;
            btnsaludar.Text = "generar saludo";
            btnsaludar.UseVisualStyleBackColor = false;
            btnsaludar.Click += btnsaludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(659, 326);
            Controls.Add(btnsaludar);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnombre;
        private Button btnsaludar;
    }
}
