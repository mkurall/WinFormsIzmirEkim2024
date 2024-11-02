namespace BlackJack
{
    public partial class Form1 : Form
    {
        List<int> deste = new List<int>();//kart numarasýný tutacak (0 - 51)
        enum KartTuru { Kupa = 0, Karo = 1, Sinek = 2, Maca = 3 };
        //her bir türde 13 kart var
        int siradakiOyuncu = 0; // 2 oyuncu var (0-1)


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            deste.Clear();
            for (int i = 0; i < 52; i++)//tüm kartlarý desteye ekle
            {
                deste.Add(i);
            }
            lblDesteKartSayisi.Text = deste.Count.ToString();

            SiradakiOyuncuyuDegistir(0);
        }

        void SiradakiOyuncuyuDegistir(int sira)
        {
            siradakiOyuncu = sira;


            if (siradakiOyuncu == 0)
            {
                lblOyuncu1.BackColor = Color.Red;
                lblOyuncu1.ForeColor = Color.White;
                pnlOyuncu1Butonlar.Enabled = true;
                lblOyuncu2.BackColor = Color.FromArgb(192, 255, 192);
                lblOyuncu2.ForeColor = Color.Black;
                pnlOyuncu2Butonlar.Enabled = false;
            }
            else
            {
                lblOyuncu2.BackColor = Color.Red;
                lblOyuncu2.ForeColor = Color.White;
                pnlOyuncu2Butonlar.Enabled = true;
                lblOyuncu1.BackColor = Color.FromArgb(192, 255, 192);
                lblOyuncu1.ForeColor = Color.Black;
                pnlOyuncu1Butonlar.Enabled = false;
            }
        }

        private void btnKartCek1_Click(object sender, EventArgs e)
        {
            SiradakiOyuncuyuDegistir(1);
        }

        private void btnKartCek2_Click(object sender, EventArgs e)
        {
            SiradakiOyuncuyuDegistir(0);
        }
    }
}
