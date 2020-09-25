using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar
{
    class HesMak
    {
        public HesMak()
        {
            MessageBox.Show("Yapıcı Metod çalıştı.");
        }

        public void mesaj()
        {
            MessageBox.Show("void metod");
        }

        public static void duragan()
        {
            MessageBox.Show("bu bir duragan bir metottur.");
        }

        int[] sayilar = { 1, 4, 6, 8, 9 };

        public int toplam()
        {
            Random r = new Random();
            int toplam = sayilar[r.Next(0, 6)] * 5;
            return toplam;
        }
        
        ~HesMak ()
        {
            MessageBox.Show("Yıkıcı metot çalıştı.");

        }
    }
}
