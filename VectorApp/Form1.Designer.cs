namespace VectorApp
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
            btnPointer = new Button();
            button3 = new Button();
            btnLine = new Button();
            btnRect = new Button();
            canvas1 = new Canvas();
            label1 = new Label();
            btnRenk1 = new Button();
            label2 = new Label();
            btnRenk2 = new Button();
            label3 = new Label();
            numCizgiKalinlik = new NumericUpDown();
            btnKaydet = new Button();
            btnAc = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCizgiKalinlik).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(btnPointer);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnLine);
            panel1.Controls.Add(btnRect);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(91, 364);
            panel1.TabIndex = 0;
            // 
            // btnPointer
            // 
            btnPointer.Location = new Point(14, 17);
            btnPointer.Name = "btnPointer";
            btnPointer.Size = new Size(62, 63);
            btnPointer.TabIndex = 0;
            btnPointer.Text = "Pointer";
            btnPointer.UseVisualStyleBackColor = true;
            btnPointer.Click += btnPointer_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 224);
            button3.Name = "button3";
            button3.Size = new Size(62, 63);
            button3.TabIndex = 0;
            button3.Text = "Ellips";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Location = new Point(14, 155);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(62, 63);
            btnLine.TabIndex = 0;
            btnLine.Text = "Line";
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnRect
            // 
            btnRect.Location = new Point(14, 86);
            btnRect.Name = "btnRect";
            btnRect.Size = new Size(62, 63);
            btnRect.TabIndex = 0;
            btnRect.Text = "Rect";
            btnRect.UseVisualStyleBackColor = true;
            btnRect.Click += btnRect_Click;
            // 
            // canvas1
            // 
            canvas1.CizgiKalinligi = 0;
            canvas1.CizgiRengi = Color.Empty;
            canvas1.DolguRengi = Color.Empty;
            canvas1.Location = new Point(109, 46);
            canvas1.Name = "canvas1";
            canvas1.SekilTuru = Canvas.SekilTurleri.Pointer;
            canvas1.Size = new Size(668, 364);
            canvas1.TabIndex = 1;
            canvas1.Text = "canvas1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 425);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Çizgi Rengi";
            // 
            // btnRenk1
            // 
            btnRenk1.BackColor = Color.Black;
            btnRenk1.Location = new Point(229, 416);
            btnRenk1.Name = "btnRenk1";
            btnRenk1.Size = new Size(54, 38);
            btnRenk1.TabIndex = 3;
            btnRenk1.UseVisualStyleBackColor = false;
            btnRenk1.Click += btnRenk1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 476);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Dolgu Rengi";
            // 
            // btnRenk2
            // 
            btnRenk2.BackColor = Color.White;
            btnRenk2.Location = new Point(229, 467);
            btnRenk2.Name = "btnRenk2";
            btnRenk2.Size = new Size(54, 38);
            btnRenk2.TabIndex = 3;
            btnRenk2.UseVisualStyleBackColor = false;
            btnRenk2.Click += btnRenk2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 425);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Çizgi Kalınlığı";
            // 
            // numCizgiKalinlik
            // 
            numCizgiKalinlik.Location = new Point(421, 425);
            numCizgiKalinlik.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numCizgiKalinlik.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCizgiKalinlik.Name = "numCizgiKalinlik";
            numCizgiKalinlik.Size = new Size(85, 27);
            numCizgiKalinlik.TabIndex = 5;
            numCizgiKalinlik.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numCizgiKalinlik.ValueChanged += numCizgiKalinlik_ValueChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(12, 11);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnAc
            // 
            btnAc.Location = new Point(112, 11);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(94, 29);
            btnAc.TabIndex = 7;
            btnAc.Text = "Aç";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(btnAc);
            Controls.Add(btnKaydet);
            Controls.Add(numCizgiKalinlik);
            Controls.Add(label3);
            Controls.Add(btnRenk2);
            Controls.Add(label2);
            Controls.Add(btnRenk1);
            Controls.Add(label1);
            Controls.Add(canvas1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numCizgiKalinlik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnPointer;
        private Button button3;
        private Button btnLine;
        private Button btnRect;
        private Canvas canvas1;
        private Label label1;
        private Button btnRenk1;
        private Label label2;
        private Button btnRenk2;
        private Label label3;
        private NumericUpDown numCizgiKalinlik;
        private Button btnKaydet;
        private Button btnAc;
    }
}
