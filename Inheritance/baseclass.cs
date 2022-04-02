using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zNetFramework.S12.D2.KalıtımOdev
{
    public class baseclass
    {
        public static int sayac = 1;
        public baseclass()
        {
            _ID = sayac;
            sayac = sayac + 1;
        }
        private int _ID;
        public int ID { 
            get 
            {
                return _ID;
            }

            private set 
            {
               

            } 
        }
        private string _barkod;
        public string barkod { 
            get 
            {
                return _barkod;
            }
            set 
            {
                bool kontrolislemi = SanalDatabase.DbBarkodKontrol(value);
                if (kontrolislemi) _barkod = value;
                else Console.WriteLine("girmek istediğiniz değer databasede zaten mevcut");
            }
        }
        public DateTime olusturmatarihi { get; set; }
        public int olusturankullanici{ get; set; }
        public DateTime guncellemetarihi { get; set; }
        public int guncelleyenkullanici { get; set; }
        public bool silindi { get; set; }
        
       
    }

}
