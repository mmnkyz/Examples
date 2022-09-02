using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    internal class SepetManager
    {
        public void Ekle (Product urunler)
        {
            MessageBox.Show("Sepete Eklendi: "+ urunler.Adi);
        }
    }
}
