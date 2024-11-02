namespace PersonelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DosyaYardimcisi.VerileriYukle();

            //Datasource liste kutusuna veri baðlamak için kullanýlýr
            lboxPersoneller.DataSource = DosyaYardimcisi.PersonelleriGetir();
            lboxPersoneller.DisplayMember = "AdSoyad";//Liste ekranýnda hangi veri görünecek
            lboxPersoneller.ValueMember = "Id";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            Personel yeni = new Personel();
            yeni.Id = 0;
            yeni.AdSoyad = txtAdSoyad.Text;
            yeni.CalistigiBirim = txtCalistigiBirim.Text;
            yeni.Cinsiyet = cboxCinsiyet.SelectedIndex;//seçili olan elamnýn sýrasý
            yeni.Turu = cboxPersonelTuru.SelectedIndex;

            //****************************************************************************
            CheckBox[] chk = { null, chkPzt, chkSal, chkCar, chkPer, chkCum, chkCmt, chkPaz };
            int gunler = 0;
            Array degerler = Enum.GetValues(typeof(Gunler));

            for (int i = 1; i < chk.Length; i++)
            {
                CheckBox c = chk[i];

                if (c.Checked) gunler |= (int)degerler.GetValue(i);
            }
            //*****************************************************************************

            yeni.CalismaGunleri = gunler;

            if (rdSgk.Checked)
                yeni.SaglikSigortasi = (int)SigortaTuru.Sgk;
            else
                yeni.SaglikSigortasi = (int)SigortaTuru.Ozel;

            DosyaYardimcisi.PersonelEkle(yeni);

            //Datasource liste kutusuna veri baðlamak için kullanýlýr
            lboxPersoneller.DataSource = null;
            lboxPersoneller.DataSource = DosyaYardimcisi.PersonelleriGetir();
            lboxPersoneller.DisplayMember = "AdSoyad";//Liste ekranýnda hangi veri görünecek
            lboxPersoneller.ValueMember = "Id";
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            DosyaYardimcisi.VerileriKaydet();
            MessageBox.Show("Veriler kayýt edildi.");
        }

        private void lboxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçili eleman yoksa pers = (Personle) null ve bu hata oluþturur
            Personel pers = lboxPersoneller.SelectedItem as Personel;
            //as operatörü deðer null deðilse convert eder, null ise null döner 

            if(pers!=null)//var ise
            {
                txtAdSoyad.Text = pers.AdSoyad;
                txtCalistigiBirim.Text = pers.CalistigiBirim;
                cboxCinsiyet.SelectedIndex = pers.Cinsiyet;
                cboxPersonelTuru.SelectedIndex = pers.Turu;

                //to do:çalýþma günlerini göster

                if (pers.SaglikSigortasi == (int)SigortaTuru.Sgk)
                    rdSgk.Checked = true;
                else if(pers.SaglikSigortasi == (int)SigortaTuru.Ozel)
                    rdOzel.Checked = true;

            }
            else//yok ise
            {
                txtAdSoyad.Text = "";
                txtCalistigiBirim.Text = "";
                cboxCinsiyet.SelectedIndex = -1;
                cboxPersonelTuru.SelectedIndex = -1;
                rdSgk.Checked = rdOzel.Checked = false;
            }
        }
    }
}
