using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FrmSkorlar : Form
    {
        List<Skor> skorlar;
        public FrmSkorlar(List<Skor> liste)
        {
            InitializeComponent();

            skorlar = liste;
            int el = 1;
            foreach (Skor skor in skorlar)
            {
                string satir = $"{el}.El ----> {skor.Oyuncu1Puan}            {skor.Oyuncu2Puan}";
                listBox1.Items.Add(satir);
                el++;
            }
        }
    }
}
