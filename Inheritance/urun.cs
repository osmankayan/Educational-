using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zNetFramework.S12.D2.KalıtımOdev
{
    public class urun : baseclass
    {
        public string marka { get; set; }//belirtmiş oluduğumuz markalardan olmalı
        public string model { get; set; }
        private decimal _alisfiyat;
        public decimal alisfiyat
        {
            get
            {
                return _alisfiyat;
            }
            set
            {
                if (value > 0)
                {
                    this._alisfiyat = value;
                }
                else
                {
                    Console.WriteLine("0'dan küçük bir değer girilemez");

                }
            }
        }//0'dan küçük olamaz
        private decimal _satisfiyat;
        public decimal satisfiyat
        {
            get
            {
                return _satisfiyat;
            }
            set
            {
                if (value> _alisfiyat)
                {
                    this._satisfiyat = value;
                }
            }
        }//alış fiyatından küçük olamaz
        private decimal _kampanyafiyat;
        public decimal kampanyafiyat
        {
            get
            {
                return _kampanyafiyat;
            }
            set
            {
                if (value > 0)
                {
                    this._kampanyafiyat = value;
                }
                else
                {
                    Console.WriteLine("0'dan küçük bir değer girilemez");

                }
            }
        }//0'dan küçük olamaz


    }
}
