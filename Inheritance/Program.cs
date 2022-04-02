using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zNetFramework.S12.D2.KalıtımOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar b1 = new bilgisayar();
           // b1.ID = 1;//girmek istemiyorum, uygulamanın set edilebilir şekilde bırakmasını istemiyorum
            b1.marka = "casper";
            b1.model = "excalibur";
            b1.islemci = "r5";
            b1.alisfiyat = 1500M;
            b1.satisfiyat = 1600m;
            b1.kampanyafiyat = 1000m;
            b1.barkod = "1234567890";
            SanalDatabase.YeniÜrünEkle(b1);


            bilgisayar b2 = new bilgisayar();
            // b1.ID = 1;//girmek istemiyorum, uygulamanın set edilebilir şekilde bırakmasını istemiyorum
            b2.marka = "casper";
            b2.model = "excalibur";
            b2.islemci = "r5";
            b2.alisfiyat = 1500M;
            b2.satisfiyat = 1600m;
            b2.kampanyafiyat = 1000m;
            b2.barkod = "1234567890";
             
            Console.ReadLine();

        }
    }
}
 