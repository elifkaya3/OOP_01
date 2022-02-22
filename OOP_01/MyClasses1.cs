using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    public class MyClasses1
    {

        public class Uyelik
        {
            public UyelikTipleri uyelik { get; set; }

            
        }

        public class Uyeler : Uyelik
        {
            public string AdSoyad { get; set; }
            public string KullanıcıAdı { get; set; }
            public BransTipleri Brans { get; set; }
            public short Yas { get; set; }
            public short DeneyimSuresi { get; set; }
            public Uyeler( string adSoyad,string kullaniciAdi,BransTipleri brans,short yas,short deneyimSuresi, int tel1)
            {
                AdSoyad = adSoyad;
                KullanıcıAdı = kullaniciAdi;
                Brans = brans;
                Yas = yas;
                DeneyimSuresi = deneyimSuresi;
                tel = tel1;
            }
            private int tel;

            public int Tel
            {
              //  get { return tel; }
                set { tel = value; }
            }
        }
        public class ProUye : Uyeler
        {
            public string proUye { get; set; }
            public Uyelik( string uyelikPro)
            {
                proUye = uyelikPro;
               
            }

           
                
        }
        public class UyelikBilgileri
        {
            List<Uyelik> Uyeler = new List<Uyelik>();
            
            public void uyeEkle(Uyeler yeniUyelik)
            {
                Uyeler.Add(yeniUyelik);
            }
        }  

        
        
    }
}
