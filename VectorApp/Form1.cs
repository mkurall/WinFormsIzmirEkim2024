namespace VectorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPointer_Click(object sender, EventArgs e)
        {
            canvas1.SekilTuru = Canvas.SekilTurleri.Pointer;

        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            canvas1.SekilTuru = Canvas.SekilTurleri.Dortgen;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            canvas1.SekilTuru = Canvas.SekilTurleri.Cizgi;
        }
    }
}
