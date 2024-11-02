using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PersonelTakip
{
    public static class DosyaYardimcisi
    {
        static List<Personel> liste;
        static string dosya = "veriler.txt";

        public static void VerileriYukle()
        {
            if (File.Exists(dosya))
            {
                string veriler = File.ReadAllText(dosya);
                List<Personel> l = JsonSerializer.Deserialize<List<Personel>>(veriler);

                liste = l;
            }
            else 
                liste = new List<Personel>();
        }

        public static List<Personel> PersonelleriGetir()
        {
            return liste;
        }
        public static void PersonelEkle(Personel personel)
        {
            if (liste.Count > 0)
            {
                Personel sonPers = liste[liste.Count - 1];

                if (sonPers == null)
                    personel.Id = 1;
                else
                    personel.Id = sonPers.Id + 1;
            }
            else 
                personel.Id = 1;

            liste.Add(personel);
        }
        public static void PersonelSil(Personel personel)
        {
            liste.Remove(personel);
        }

        public static void VerileriKaydet()
        {
            string veri = JsonSerializer.Serialize(liste);

            File.WriteAllText(dosya, veri);

        }
    }
}
