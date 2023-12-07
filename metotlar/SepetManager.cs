using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class SepetManager
    {    //Naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi,string Aciklama,double fiyat,int stok)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urunAdi);
        }
    }
}
