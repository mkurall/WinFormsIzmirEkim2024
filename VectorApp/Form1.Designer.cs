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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            canvas1 = new Canvas();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(91, 364);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(14, 17);
            button4.Name = "button4";
            button4.Size = new Size(62, 63);
            button4.TabIndex = 0;
            button4.Text = "Pointer";
            button4.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(14, 155);
            button2.Name = "button2";
            button2.Size = new Size(62, 63);
            button2.TabIndex = 0;
            button2.Text = "Line";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(14, 86);
            button1.Name = "button1";
            button1.Size = new Size(62, 63);
            button1.TabIndex = 0;
            button1.Text = "Rect";
            button1.UseVisualStyleBackColor = true;
            // 
            // canvas1
            // 
            canvas1.Location = new Point(109, 46);
            canvas1.Name = "canvas1";
            canvas1.Size = new Size(668, 364);
            canvas1.TabIndex = 1;
            canvas1.Text = "canvas1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(canvas1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Canvas canvas1;
    }
}
