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

            //Datasource liste kutusuna veri ba�lamak i�in kullan�l�r
            lboxPersoneller.DataSource = DosyaYardimcisi.PersonelleriGetir();
            lboxPersoneller.DisplayMember = "AdSoyad";//Liste ekran�nda hangi veri g�r�necek
            lboxPersoneller.ValueMember = "Id";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            Personel yeni = new Personel();
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

            DosyaYardimcisi.PersonelEkle(yeni);

            //Datasource liste kutusuna veri ba�lamak i�in kullan�l�r
            lboxPersoneller.DataSource = null;
            lboxPersoneller.DataSource = DosyaYardimcisi.PersonelleriGetir();
            lboxPersoneller.DisplayMember = "AdSoyad";//Liste ekran�nda hangi veri g�r�necek
            lboxPersoneller.ValueMember = "Id";
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

            if(pers!=null)//var ise
            {
                txtAdSoyad.Text = pers.AdSoyad;
                txtCalistigiBirim.Text = pers.CalistigiBirim;
                cboxCinsiyet.SelectedIndex = pers.Cinsiyet;
                cboxPersonelTuru.SelectedIndex = pers.Turu;

                //to do:�al��ma g�nlerini g�ster

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
