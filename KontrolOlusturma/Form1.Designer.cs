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
            SuspendLayout();
            // 
            // btkButton1
            // 
            btkButton1.BackColor = Color.BlueViolet;
            btkButton1.ForeColor = Color.White;
            btkButton1.Location = new Point(125, 104);
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
            btkButton2.Location = new Point(311, 104);
            btkButton2.Name = "btkButton2";
            btkButton2.Size = new Size(148, 49);
            btkButton2.TabIndex = 1;
            btkButton2.Text = "btkButton2";
            btkButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btkButton2);
            Controls.Add(btkButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private BtkButton btkButton1;
        private BtkButton btkButton2;
    }
}
