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

            lboxPersoneller.VeriBagla(DosyaYardimcisi.PersonelleriGetir(),
                "Id", "Adsoyad");

        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            Personel yeni = lboxPersoneller.SelectedItem as Personel;

            if (yeni == null)
                yeni = new Personel();

            yeni.Id = 0;
            yeni.AdSoyad = txtAdSoyad.Text;
            yeni.CalistigiBirim = txtCalistigiBirim.Text;
            yeni.Cinsiyet = cboxCinsiyet.SelectedIndex;//se�ili olan elamn�n s�ras�
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


            if (lboxPersoneller.SelectedItem == null)//eski persomnel se�ili de�ilse ekle
                DosyaYardimcisi.PersonelEkle(yeni);


            lboxPersoneller.VeriBagla(DosyaYardimcisi.PersonelleriGetir(),
                "Id", "Adsoyad");
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            DosyaYardimcisi.VerileriKaydet();
            MessageBox.Show("Veriler kay�t edildi.");
        }

        private void lboxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se�ili eleman yoksa pers = (Personle) null ve bu hata olu�turur
            Personel pers = lboxPersoneller.SelectedItem as Personel;
            //as operat�r� de�er null de�ilse convert eder, null ise null d�ner 

            if (pers != null)//var ise
            {
                txtAdSoyad.Text = pers.AdSoyad;
                txtCalistigiBirim.Text = pers.CalistigiBirim;
                cboxCinsiyet.SelectedIndex = pers.Cinsiyet;
                cboxPersonelTuru.SelectedIndex = pers.Turu;

                //to do:�al��ma g�nlerini g�ster
                CheckBox[] chk = { null, chkPzt, chkSal, chkCar, chkPer, chkCum, chkCmt, chkPaz };
                Array degerler = Enum.GetValues(typeof(Gunler));

                for (int i = 1;i<chk.Length;i++)
                {
                    CheckBox c = chk[i];

                    Gunler gunler = (Gunler)pers.CalismaGunleri;

                    if (gunler.HasFlag((Gunler)degerler.GetValue(i)))
                    {
                        c.Checked = true;
                    }
                    else
                    {
                        c.Checked = false;
                    }
                }



                if (pers.SaglikSigortasi == (int)SigortaTuru.Sgk)
                    rdSgk.Checked = true;
                else if (pers.SaglikSigortasi == (int)SigortaTuru.Ozel)
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

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lboxPersoneller.SelectedIndex = -1;
        }

        private void tsbSil_Click(object sender, EventArgs e)
        {
            Personel pers = lboxPersoneller.SelectedItem as Personel;

            if (pers!=null)
            {
                var cevap = MessageBox.Show($"{pers.AdSoyad} adl� personeli silmek istedi�inize" +
                    $" emin misiniz?","Uyar�", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    DosyaYardimcisi.PersonelSil(pers);

                    lboxPersoneller.VeriBagla(DosyaYardimcisi.PersonelleriGetir(),
                        "Id", "Adsoyad");
                }
            }
        }
    }
}
