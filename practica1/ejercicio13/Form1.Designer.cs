namespace ejercicio13
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            btniniciar = new Button();
            btndetener = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(97, 108);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(325, 34);
            progressBar1.TabIndex = 0;
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(97, 166);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(112, 34);
            btniniciar.TabIndex = 1;
            btniniciar.Text = "Iniciar";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // btndetener
            // 
            btndetener.Location = new Point(310, 166);
            btndetener.Name = "btndetener";
            btndetener.Size = new Size(112, 34);
            btndetener.TabIndex = 2;
            btndetener.Text = "Detener";
            btndetener.UseVisualStyleBackColor = true;
            btndetener.Click += btndetener_Click_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(543, 304);
            Controls.Add(btndetener);
            Controls.Add(btniniciar);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Barra de progreso";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btniniciar;
        private Button btndetener;
        private System.Windows.Forms.Timer timer1;
    }
}
