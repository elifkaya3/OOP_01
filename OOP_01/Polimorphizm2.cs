using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_01.MyClasses;

namespace OOP_01
{
    public partial class Polimorphizm2 : Form
    {
        Sepet sepet = new Sepet();

        public Polimorphizm2()
        {
            InitializeComponent();
        }

        private void btnTekstil_Click(object sender, EventArgs e)
        {
            Tekstil tekstil = new Tekstil("Gömlek",300,"İpek",3);
            sepet.UrunEkle(tekstil);
            dgvSepet.Rows.Add(tekstil.UrunAdi, tekstil.Fiyat, tekstil.KDVUygula());
        
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            CepTelefonu cepTelefonu = new CepTelefonu("7 PLUS",5000,"Apple");
            sepet.UrunEkle(cepTelefonu);
            dgvSepet.Rows.Add(cepTelefonu.UrunAdi,cepTelefonu.Fiyat,cepTelefonu.KDVUygula());
        }

        private void btnEkmek_Click(object sender, EventArgs e)
        {
            Ekmek ekmek = new Ekmek("Uno",10,"Çavdarlı",200);
            sepet.UrunEkle(ekmek);
            dgvSepet.Rows.Add(ekmek.UrunAdi,ekmek.Fiyat,ekmek.KDVUygula());

        }
    }
}
