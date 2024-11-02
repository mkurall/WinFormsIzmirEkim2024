namespace VkiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(txtBoy.Text);
            double kilo = Convert.ToDouble(txtKilo.Text);

            double boyMetre = boy / 100;

            double vki = kilo / (boyMetre * boyMetre);

            lblSonuc.Text = $"VKÝ DEÐERÝ = {vki:f2}";

            if (vki < 18.5)
                lblDurum.Text = "DURUM = ZAYIF";
            else if (vki < 25)
                lblDurum.Text = "DURUM = NORMAL";
            else if (vki < 30)
                lblDurum.Text = "DURUM = KÝLOLU";
            else
                lblDurum.Text = "DURUM = OBEZ";

        }
    }
}
