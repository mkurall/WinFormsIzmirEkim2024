namespace KontrolOlusturma
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
            btkButton1 = new BtkButton();
            btkButton2 = new BtkButton();
            btkSwitchButton2 = new BtkSwitchButton();
            btkSwitchButton1 = new BtkSwitchButton();
            btkSwitchButton3 = new BtkSwitchButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btkButton1
            // 
            btkButton1.BackColor = Color.BlueViolet;
            btkButton1.ForeColor = Color.White;
            btkButton1.Location = new Point(56, 46);
            btkButton1.Name = "btkButton1";
            btkButton1.Size = new Size(157, 49);
            btkButton1.TabIndex = 0;
            btkButton1.Text = "btkButton1";
            btkButton1.UseVisualStyleBackColor = false;
            // 
            // btkButton2
            // 
            btkButton2.BackColor = Color.BlueViolet;
            btkButton2.ForeColor = Color.White;
            btkButton2.Location = new Point(242, 46);
            btkButton2.Name = "btkButton2";
            btkButton2.Size = new Size(148, 49);
            btkButton2.TabIndex = 1;
            btkButton2.Text = "btkButton2";
            btkButton2.UseVisualStyleBackColor = false;
            // 
            // btkSwitchButton2
            // 
            btkSwitchButton2.Location = new Point(341, 174);
            btkSwitchButton2.Name = "btkSwitchButton2";
            btkSwitchButton2.Size = new Size(81, 38);
            btkSwitchButton2.TabIndex = 3;
            btkSwitchButton2.Text = "btkSwitchButton2";
            // 
            // btkSwitchButton1
            // 
            btkSwitchButton1.Location = new Point(341, 218);
            btkSwitchButton1.Name = "btkSwitchButton1";
            btkSwitchButton1.Size = new Size(81, 38);
            btkSwitchButton1.TabIndex = 3;
            btkSwitchButton1.Text = "btkSwitchButton2";
            btkSwitchButton1.Click += btkSwitchButton1_Click;
            // 
            // btkSwitchButton3
            // 
            btkSwitchButton3.Location = new Point(341, 262);
            btkSwitchButton3.Name = "btkSwitchButton3";
            btkSwitchButton3.Size = new Size(81, 38);
            btkSwitchButton3.TabIndex = 3;
            btkSwitchButton3.Text = "btkSwitchButton2";
            btkSwitchButton3.Click += btkSwitchButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(165, 182);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 4;
            label1.Text = "Depolama Alanını Yönet";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btkSwitchButton3);
            Controls.Add(btkSwitchButton1);
            Controls.Add(btkSwitchButton2);
            Controls.Add(btkButton2);
            Controls.Add(btkButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BtkButton btkButton1;
        private BtkButton btkButton2;
        private BtkSwitchButton btkSwitchButton2;
        private BtkSwitchButton btkSwitchButton1;
        private BtkSwitchButton btkSwitchButton3;
        private Label label1;
    }
}
