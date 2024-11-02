namespace PersonelTakip
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lboxPersoneller = new ListBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            tsbKaydet = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbSil = new ToolStripButton();
            rdOzel = new RadioButton();
            rdSgk = new RadioButton();
            chkPaz = new CheckBox();
            chkCmt = new CheckBox();
            chkPer = new CheckBox();
            chkCum = new CheckBox();
            chkCar = new CheckBox();
            chkSal = new CheckBox();
            chkPzt = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cboxPersonelTuru = new ComboBox();
            cboxCinsiyet = new ComboBox();
            txtCalistigiBirim = new TextBox();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(73, 9);
            label1.Name = "label1";
            label1.Size = new Size(377, 60);
            label1.TabIndex = 1;
            label1.Text = "Personel Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.man__2_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lboxPersoneller
            // 
            lboxPersoneller.Dock = DockStyle.Fill;
            lboxPersoneller.FormattingEnabled = true;
            lboxPersoneller.Location = new Point(0, 28);
            lboxPersoneller.Name = "lboxPersoneller";
            lboxPersoneller.Size = new Size(235, 390);
            lboxPersoneller.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 2;
            label2.Text = "Personel Listesi";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 74);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lboxPersoneller);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Salmon;
            splitContainer1.Panel2.Controls.Add(toolStrip1);
            splitContainer1.Panel2.Controls.Add(rdOzel);
            splitContainer1.Panel2.Controls.Add(rdSgk);
            splitContainer1.Panel2.Controls.Add(chkPaz);
            splitContainer1.Panel2.Controls.Add(chkCmt);
            splitContainer1.Panel2.Controls.Add(chkPer);
            splitContainer1.Panel2.Controls.Add(chkCum);
            splitContainer1.Panel2.Controls.Add(chkCar);
            splitContainer1.Panel2.Controls.Add(chkSal);
            splitContainer1.Panel2.Controls.Add(chkPzt);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(cboxPersonelTuru);
            splitContainer1.Panel2.Controls.Add(cboxCinsiyet);
            splitContainer1.Panel2.Controls.Add(txtCalistigiBirim);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(txtAdSoyad);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(706, 418);
            splitContainer1.SplitterDistance = 235;
            splitContainer1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbKaydet, toolStripSeparator1, tsbSil });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(467, 39);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbKaydet
            // 
            tsbKaydet.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbKaydet.Image = Properties.Resources.data_storage;
            tsbKaydet.ImageTransparentColor = Color.Magenta;
            tsbKaydet.Name = "tsbKaydet";
            tsbKaydet.Size = new Size(36, 36);
            tsbKaydet.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // tsbSil
            // 
            tsbSil.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSil.Image = Properties.Resources.delete;
            tsbSil.ImageTransparentColor = Color.Magenta;
            tsbSil.Name = "tsbSil";
            tsbSil.Size = new Size(36, 36);
            tsbSil.Text = "toolStripButton2";
            // 
            // rdOzel
            // 
            rdOzel.AutoSize = true;
            rdOzel.Location = new Point(81, 385);
            rdOzel.Name = "rdOzel";
            rdOzel.Size = new Size(60, 24);
            rdOzel.TabIndex = 5;
            rdOzel.TabStop = true;
            rdOzel.Text = "Özel";
            rdOzel.UseVisualStyleBackColor = true;
            // 
            // rdSgk
            // 
            rdSgk.AutoSize = true;
            rdSgk.Location = new Point(18, 385);
            rdSgk.Name = "rdSgk";
            rdSgk.Size = new Size(57, 24);
            rdSgk.TabIndex = 5;
            rdSgk.TabStop = true;
            rdSgk.Text = "SGK";
            rdSgk.UseVisualStyleBackColor = true;
            // 
            // chkPaz
            // 
            chkPaz.AutoSize = true;
            chkPaz.Location = new Point(363, 322);
            chkPaz.Name = "chkPaz";
            chkPaz.Size = new Size(57, 24);
            chkPaz.TabIndex = 4;
            chkPaz.Text = "PAZ";
            chkPaz.UseVisualStyleBackColor = true;
            // 
            // chkCmt
            // 
            chkCmt.AutoSize = true;
            chkCmt.Location = new Point(307, 322);
            chkCmt.Name = "chkCmt";
            chkCmt.Size = new Size(61, 24);
            chkCmt.TabIndex = 4;
            chkCmt.Text = "CMT";
            chkCmt.UseVisualStyleBackColor = true;
            // 
            // chkPer
            // 
            chkPer.AutoSize = true;
            chkPer.Location = new Point(186, 322);
            chkPer.Name = "chkPer";
            chkPer.Size = new Size(56, 24);
            chkPer.TabIndex = 4;
            chkPer.Text = "PER";
            chkPer.UseVisualStyleBackColor = true;
            // 
            // chkCum
            // 
            chkCum.AutoSize = true;
            chkCum.Location = new Point(244, 322);
            chkCum.Name = "chkCum";
            chkCum.Size = new Size(63, 24);
            chkCum.TabIndex = 4;
            chkCum.Text = "CUM";
            chkCum.UseVisualStyleBackColor = true;
            // 
            // chkCar
            // 
            chkCar.AutoSize = true;
            chkCar.Location = new Point(130, 322);
            chkCar.Name = "chkCar";
            chkCar.Size = new Size(59, 24);
            chkCar.TabIndex = 4;
            chkCar.Text = "ÇAR";
            chkCar.UseVisualStyleBackColor = true;
            // 
            // chkSal
            // 
            chkSal.AutoSize = true;
            chkSal.Location = new Point(74, 322);
            chkSal.Name = "chkSal";
            chkSal.Size = new Size(56, 24);
            chkSal.TabIndex = 4;
            chkSal.Text = "SAL";
            chkSal.UseVisualStyleBackColor = true;
            // 
            // chkPzt
            // 
            chkPzt.AutoSize = true;
            chkPzt.Location = new Point(18, 322);
            chkPzt.Name = "chkPzt";
            chkPzt.Size = new Size(56, 24);
            chkPzt.TabIndex = 4;
            chkPzt.Text = "PZT";
            chkPzt.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 362);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 3;
            label8.Text = "Sağlık Sigortası";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 290);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 3;
            label7.Text = "Çalışma Günleri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 226);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 3;
            label6.Text = "Personel Türü";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 167);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 3;
            label5.Text = "Cinsiyeti";
            // 
            // cboxPersonelTuru
            // 
            cboxPersonelTuru.FormattingEnabled = true;
            cboxPersonelTuru.Location = new Point(18, 249);
            cboxPersonelTuru.Name = "cboxPersonelTuru";
            cboxPersonelTuru.Size = new Size(265, 28);
            cboxPersonelTuru.TabIndex = 2;
            // 
            // cboxCinsiyet
            // 
            cboxCinsiyet.FormattingEnabled = true;
            cboxCinsiyet.Location = new Point(18, 190);
            cboxCinsiyet.Name = "cboxCinsiyet";
            cboxCinsiyet.Size = new Size(151, 28);
            cboxCinsiyet.TabIndex = 2;
            // 
            // txtCalistigiBirim
            // 
            txtCalistigiBirim.Location = new Point(18, 131);
            txtCalistigiBirim.Name = "txtCalistigiBirim";
            txtCalistigiBirim.Size = new Size(378, 27);
            txtCalistigiBirim.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 108);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 0;
            label4.Text = "Çalıştığı Birim";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(18, 74);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(378, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 51);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 492);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Personel Bilgi Formu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox lboxPersoneller;
        private Label label2;
        private SplitContainer splitContainer1;
        private TextBox txtCalistigiBirim;
        private Label label4;
        private TextBox txtAdSoyad;
        private Label label3;
        private CheckBox chkPaz;
        private CheckBox chkCmt;
        private CheckBox chkPer;
        private CheckBox chkCum;
        private CheckBox chkCar;
        private CheckBox chkSal;
        private CheckBox chkPzt;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cboxPersonelTuru;
        private ComboBox cboxCinsiyet;
        private RadioButton rdOzel;
        private RadioButton rdSgk;
        private Label label8;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbKaydet;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSil;


    }
}
