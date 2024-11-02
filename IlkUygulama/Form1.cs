namespace IlkUygulama
{
    public partial class Form1 : Form
    {
        public Form1()//yapýcý metot
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            //text box'a kullanýcýnýn girdiði deðeri oku
            string adSoyad = txtAdSoyad.Text;
            //ekrana mesaj diyalog penceresi getirir
            MessageBox.Show($"Merhaba, {adSoyad}");
        }


    }
}
