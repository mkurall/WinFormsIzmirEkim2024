namespace IlkUygulama
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
            btnTikla = new Button();
            txtAdSoyad = new TextBox();
            SuspendLayout();
            // 
            // btnTikla
            // 
            btnTikla.Location = new Point(85, 92);
            btnTikla.Name = "btnTikla";
            btnTikla.Size = new Size(208, 58);
            btnTikla.TabIndex = 0;
            btnTikla.Text = "Beni Tıkla!";
            btnTikla.UseVisualStyleBackColor = true;
            btnTikla.Click += btnTikla_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = Color.DeepPink;
            txtAdSoyad.Location = new Point(85, 42);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(208, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(383, 229);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnTikla);
            Name = "Form1";
            Text = "BtkAkademi - İlk Form Projesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTikla;
        private TextBox txtAdSoyad;
    }
}
