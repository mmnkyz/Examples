using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik
{
    internal class ToplamaIslemi
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            MessageBox.Show(sonuc.ToString());
        }
    }
}
