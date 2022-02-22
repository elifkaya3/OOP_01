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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        class Ayakkabi
        {
           
            public Ayakkabi(Markalar gelenMarka)
            {
                Marka = gelenMarka;
            } 
            public Ayakkabi(Markalar gelenMarka, AyakkabiTipleri gelenAyakkabiTipi)
            {
                Marka = gelenMarka;
                AyakkabiTipi = gelenAyakkabiTipi;
            }
            public Ayakkabi(Markalar gelenMarka, AyakkabiTipleri gelenAyakkabiTipi,MalzemeTipleri gelenMalzemeTipi)
            {
                Marka = gelenMarka;
                AyakkabiTipi = gelenAyakkabiTipi;
                MalzemeTipi = gelenMalzemeTipi;
            }

            // public string Marka { get; set; }
            public Markalar Marka { get; set; }
            public AyakkabiTipleri AyakkabiTipi { get; set; }
            public MalzemeTipleri MalzemeTipi { get; set; }

        }
        private void Form3_Load(object sender, EventArgs e)
        {/*
            Ayakkabi a = new Ayakkabi();
            a.Marka = Markalar.Adidas;
            a.AyakkabiTipi = AyakkabiTipleri.Spor_Ayakkabı;
            a.MalzemeTipi = MalzemeTipleri.Deri;
            MessageBox.Show($@"Markası:{a.Marka} AyakkabıTipi:{a.AyakkabiTipi} MalzemeTipi:{a.MalzemeTipi}");
       */
            Ayakkabi MarkasıBelliAyakkabi = new Ayakkabi(Markalar.Hummel);
            label1.Text = MarkasıBelliAyakkabi.Marka.ToString();

            Ayakkabi markasiVeTipiBelliAyakkabi = new Ayakkabi(Markalar.Puma, AyakkabiTipleri.Spor_Ayakkabı);
            label1.Text =markasiVeTipiBelliAyakkabi.Marka.ToString() + markasiVeTipiBelliAyakkabi.AyakkabiTipi.ToString() + markasiVeTipiBelliAyakkabi.MalzemeTipi.ToString() ;

            Ayakkabi markasıTipiMalzeme = new Ayakkabi(Markalar.Nike, AyakkabiTipleri.Terlik, MalzemeTipleri.Deri);
           // label1.Text = markasıTipiMalzeme.Marka.ToString();

        }

    }
}
