using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    public static class ListBoxExtension
    {
        public static void VeriBagla(this ListBox lb, 
            List<Personel> liste, string valueMember, string displayMember)
        {
            lb.DataSource = null;
            //Datasource liste kutusuna veri bağlamak için kullanılır
            lb.DataSource = liste;
            lb.DisplayMember = displayMember;//Liste ekranında hangi veri görünecek
            lb.ValueMember = valueMember;
        }
    }
}
