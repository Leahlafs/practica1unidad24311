namespace ejercicio14
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(22, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(538, 397);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightYellow;
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = SystemColors.GradientActiveCaption;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(530, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Primera pg";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.MistyRose;
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Century Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabPage2.ForeColor = Color.SteelBlue;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(530, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Segunda pg";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(105, 160);
            label1.Name = "label1";
            label1.Size = new Size(286, 23);
            label1.TabIndex = 0;
            label1.Text = "este es la pestaña numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 154);
            label2.Name = "label2";
            label2.Size = new Size(254, 23);
            label2.TabIndex = 0;
            label2.Text = "esta es la ultima pestaña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 427);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
    }
}
