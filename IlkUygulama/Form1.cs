namespace IlkUygulama
{
    public partial class Form1 : Form
    {
        public Form1()//yap�c� metot
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            //text box'a kullan�c�n�n girdi�i de�eri oku
            string adSoyad = txtAdSoyad.Text;
            //ekrana mesaj diyalog penceresi getirir
            MessageBox.Show($"Merhaba, {adSoyad}");
        }


    }
}
