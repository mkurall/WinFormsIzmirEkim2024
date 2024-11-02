namespace VkiUygulamasi
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
            txtBoy = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtKilo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnHesapla = new Button();
            lblSonuc = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(103, 27);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(102, 27);
            txtBoy.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Boyunuz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 30);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 2;
            label2.Text = "cm";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(103, 71);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(102, 27);
            txtKilo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 74);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Kilonuz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 74);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 2;
            label4.Text = "kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(22, 113);
            label5.Name = "label5";
            label5.Size = new Size(337, 56);
            label5.TabIndex = 1;
            label5.Text = "Console.WriteLine(\"\") --> Label gibi\r\nConsole.ReadLine(\"\") --> TextBox gibi";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.Orange;
            btnHesapla.Location = new Point(79, 193);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(137, 52);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F);
            lblSonuc.Location = new Point(22, 275);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(111, 28);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "VKİ DEĞERİ";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 12F);
            lblDurum.Location = new Point(22, 313);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(132, 28);
            lblDurum.TabIndex = 4;
            lblDurum.Text = "VKI DURUMU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(656, 371);
            Controls.Add(lblDurum);
            Controls.Add(lblSonuc);
            Controls.Add(btnHesapla);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Name = "Form1";
            Text = "Vücut Kitle Endeksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoy;
        private Label label1;
        private Label label2;
        private TextBox txtKilo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnHesapla;
        private Label lblSonuc;
        private Label lblDurum;
    }
}
