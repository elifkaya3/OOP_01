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

    class Ogrenci
    {

        /// <summary>
        /// Bu constructor metodunu kullanırsan yaşın varsayılan değeri 15 olacaktır.
        /// </summary>
        public Ogrenci()
        {
            yas = 15;
        }
        /// <summary>
        /// Bu overload ı kullanırsan varsayılan yaşı sen belirlemelisin
        /// </summary>
        /// <param name="gelenYas"></param>/varsayılaan yası yaz
        public Ogrenci(short gelenYas)
        {
            yas = gelenYas;
         //this.yas =yas;
        }
        string ad;
        short yas;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public short Yas
        {
            get { return yas; }
            set { yas = value; }
        }

    }
     class Ayakkabi
    {

        public Ayakkabi()
        {
            marka = "Adidas";
        }
        private string marka;

        public string Marka 
        {
            get { return marka; }
            //set { marka = value; }
        }
        private int numara;

        public int Numara
        {
            get { return numara; }
            set { numara = value; }
        }
       

        private string cinsiyet;
        
        public string Cinsiyet
        {
            //get { return cinsiyet; }
            set { cinsiyet = value; }
        }


    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*  Ogrenci ogrenci1 = new Ogrenci();
              ogrenci1.Ad = "Engin";
              Ogrenci ogrenci2 = new Ogrenci();
              ogrenci2.Ad = "Umay";
              MessageBox.Show($"Adı:{ogrenci1.Ad}\n Yaşı:{ogrenci1.Yas}");
              MessageBox.Show($"Adı:{ogrenci2.Ad}\n Yaşı:{ogrenci2.Yas}");


              Ogrenci ogrenci3 = new Ogrenci(17);
              MessageBox.Show($"{ogrenci3.Yas}");*/

            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi1.Numara = 42;
            ayakkabi1.Cinsiyet = "Kadın";
            MessageBox.Show(ayakkabi1.Marka + " " + ayakkabi1.Numara);
        }
    }
}
