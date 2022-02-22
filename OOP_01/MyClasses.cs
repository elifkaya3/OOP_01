using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    public class MyClasses
    {
        public class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
            public virtual double KDVUygula()
            {
                return Fiyat * 1.10;//default olarak %8 KDV Oranı uygulanıyor
            }
            public Urun()
            {

            }
            public Urun(string uAd, double uFiyat)
            {
                UrunAdi = uAd;
                Fiyat = uFiyat;
            }
        }
       public class Tekstil : Urun
        {
            public string KumasTuru { get; set; }
            public short Beden { get; set; }
            public string UreticiFirma { get; set; }
            public Tekstil(string tAd, double tFiyat, string tKumasTuru, short tBeden)
            {
                UrunAdi = tAd;
                Fiyat = tFiyat;
                KumasTuru = tKumasTuru;
                Beden = tBeden;
            }
        }
        public  class CepTelefonu : Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }

            public CepTelefonu(string cAd, double cFiyat, string cMarka)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                Marka = cMarka;

            }
        }
        public class Ekmek : Urun
        {
            public string EkmekTuru { get; set; }
            public double Gramaj { get; set; }
            public Ekmek(string eAd, double eFiyat, string eEkmekTuru, double eGramaj)
            {
                UrunAdi = eAd;
                Fiyat = eFiyat;
                EkmekTuru = eEkmekTuru;
                Gramaj = eGramaj;
            }
            public override double KDVUygula()//miras aldığımız bilgiyi değişmek için override kllanmalıyız ve miras değişebilsin diye miras sınıfında değişmek istediğimiz yere virtual yazmalıyız.
            {
                return Fiyat = 1.01;

            }
        }
        public class Sepet
        {
            List<Urun> urunler = new List<Urun>();
            public double ToplamTutar()
            {
                double toplamFiyat = 0;
                foreach (Urun item in urunler)
                {
                    toplamFiyat += item.KDVUygula();
                }
                return toplamFiyat;
            }
            public void UrunEkle(Urun yeniUrun)
            {
                urunler.Add(yeniUrun);
            }
        }
    }

}
