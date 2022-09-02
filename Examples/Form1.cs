using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product urun1 = new Product();
            urun1.Adi = "Laptop";
            urun1.Fiyati = 16000;
            urun1.Aciklama = "Lenovo ThikPad";

            Product urun2 = new Product();
            urun2.Adi = "Laptop";
            urun2.Fiyati = 19000;
            urun2.Aciklama = "HP Prodesk";

            Product urun3 = new Product();
            urun3.Adi = "Laptop";
            urun3.Fiyati = 22000;
            urun3.Aciklama = "Monster";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                listBox1.Items.Add(urun.Adi + " " + urun.Fiyati + " " + urun.Aciklama);
            }

            SepetManager sepetekle = new SepetManager();
            sepetekle.Ekle(urun1);
            sepetekle.Ekle(urun2);
            sepetekle.Ekle(urun3);
        }
    }
}
