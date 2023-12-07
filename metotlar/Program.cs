using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urun_adi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elmasi";
            Urun urun1 = new Urun();
            urun1.Adi = "ELMA";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";
            Urun[] urunler = new Urun[] {urun1,urun2};
            //type-safe -- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("----------Metotlar----------");
            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yesil Armut", 12,23);
            sepetManager.Ekle2("Elma", "Yesil Elma", 12,72);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,64);
            Console.ReadLine();
        }
    }
}
//do not repeat yourself - DRY- Clean Code -Best Practice