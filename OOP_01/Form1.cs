using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Kisi
        {
            string ad;//bu bir field//erişim belirleyici private
            string soyad;
            string yas;

            public string Ad
            {
                get
                {
                    return ad;
                }
                set
                {
                    ad=value.ToUpper();
                }
            }
            public string Soyad
            {
                get
                {
                    return soyad;
                }
                set
                {
                    soyad = value.ToUpper();
                }
            }
        }

        class Personel
        {
            string adSoyad;
            int yas;
            public string AdSoyad { get; set; }
            public int Yas { get; set; }
        }
        class Araba
        {
            public string Marka { get; set; }
            public short ModelYili { get; set; }

        }
        class Ogrenci
        {
            public string AdSoyad { get; set; }
            public short Yas { get; set; }
            public string Bolum { get; set; }
            public string Sehir { get; set; }
            public double Ortalama { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi ogrenci1 = new Kisi();
            ogrenci1.Ad = "Osman";
            ogrenci1.Soyad = "Can";
            MessageBox.Show(ogrenci1.Ad+" "+ogrenci1.Soyad);

            Personel personel1 = new Personel();
            personel1.AdSoyad = "Kemal Netin";
            personel1.Yas = 66;
            MessageBox.Show(personel1.AdSoyad+","+personel1.Yas+" yaşındasınız.");

            Araba otomobil = new Araba();
            otomobil.Marka="Opel";
            otomobil.ModelYili = 1997;
            MessageBox.Show($"Marka:{otomobil.Marka}\n ModelYili:{otomobil.ModelYili}");

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.AdSoyad = "Muhterem Sevindik";
            ogrenci2.Yas =23;
            ogrenci2.Bolum = "Değerli Taşlar";
            ogrenci2.Sehir="Madagaskar";
            ogrenci2.Ortalama =76;
            EkranaYaz(ogrenci2);
        }
        void EkranaYaz(Ogrenci ogrenci)
        {
            MessageBox.Show(ogrenci.AdSoyad);
        }
        void BuyukHarfeCevir(Ogrenci o)
        {
            o.AdSoyad = o.AdSoyad.ToUpper();
        }
    }
}
