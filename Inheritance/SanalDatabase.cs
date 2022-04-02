using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zNetFramework.S12.D2.KalıtımOdev
{
    public static class SanalDatabase
    {
        private static ArrayList db = new ArrayList();
        public static void YeniÜrünEkle(baseclass data)
        {
            if(data!=null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }
        public static bool DbBarkodKontrol(string barkod)
        {
            if (barkod != null && db.Count > 0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseclass bc = (baseclass)db[i];
                    if (bc.barkod == barkod) return false;
                }
            }
            return true;
        }

    }
}
