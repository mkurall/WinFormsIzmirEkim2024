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
            panel1.SuspendLayout();
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
            canvas1.Location = new Point(109, 46);
            canvas1.Name = "canvas1";
            canvas1.SekilTuru = Canvas.SekilTurleri.Pointer;
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
        private Button btnPointer;
        private Button button3;
        private Button btnLine;
        private Button btnRect;
        private Canvas canvas1;
    }
}
