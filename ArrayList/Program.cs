using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D2.ArrayListtödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gelendeger = string.Empty;
            ArrayList a1 = new ArrayList();
            a1.Add("osman");
            a1.Add("kemal");
            a1.Add("oguz");
            while (gelendeger != "6")
            {
                Console.Clear();
                
                Console.WriteLine("1-değer ekle");
                Console.WriteLine("2-değer listele");
                Console.WriteLine("3-değer ara");
                Console.WriteLine("4-değer düzenle");
                Console.WriteLine("5-değer sil");
                Console.WriteLine("6-çıkış");
                Console.Write("değer giriniz:");
               
                gelendeger = Console.ReadLine();
                switch (gelendeger)
                {
                    case "1":
                        Console.WriteLine("eklemek istediğiniz değeri giriniz");
                        string a = Console.ReadLine();
                        a1.Add(a);
                        Console.WriteLine("{0} değeri listeye eklendi", a);
                        System.Threading.Thread.Sleep(3000);

                        break;

                    case "2":
                        int sayac1 = 0;
                        Console.WriteLine("değer listesi:");

                        foreach (string item in a1)
                        {
                            Console.Write("[{0}]:", sayac1);
                            Console.WriteLine(item);
                            sayac1++;

                        }
                        Console.WriteLine("devam etmek için bir tuşa basınız");
                        Console.ReadLine();

                        break;

                    case "3":
                        Console.WriteLine("index numarasını öğrenmek istediğiniz değeri giriniz:");
                        string b = Console.ReadLine();
                        if (a1.Contains(b))
                        {
                            int indexdegeri = a1.IndexOf(b);

                            string bulunandeger = a1[indexdegeri].ToString();
                            Console.WriteLine("{0}'ın index değeri {1}'dir", bulunandeger, indexdegeri);//bulunandeger yerine b değerindende sayıyı çekebilirdim
                        }
                        else
                        {
                            Console.WriteLine("girdiğiniz değer arraylist içinde bulunmamaktadır,değeri kaydetmek istermisiniz? e/h");
                            string evethayir = Console.ReadLine();
                            if (evethayir.ToLower() == "e")
                            {
                                a1.Add(b);
                                Console.WriteLine("{0} değeri başarıyla eklendi", b);

                            }
                            else if (evethayir == "h") Console.WriteLine("ana menüye yönlendiriliyorsunuz...");
                        }
                        System.Threading.Thread.Sleep(3000);
                        break;

                    case "4":
                        int sayac2 = 0;

                        foreach (string item in a1)
                        {
                            Console.Write("[{0}]:", sayac2);
                            Console.WriteLine(item);
                            if (sayac2 != 999999)
                                sayac2++;
                        }
                        Console.WriteLine("listelenen arraylistte değiştirmek istediğiniz değerin index numarasını giriniz");
                        int c = int.Parse(Console.ReadLine());

                        Console.WriteLine("yeni değeri girin");
                        string d = Console.ReadLine();
                        a1[c] = d;
                        Console.WriteLine("değer başarıyla {0} olarak değiştirildi", d);
                        System.Threading.Thread.Sleep(3000);
                        break;

                    case "5":
                        int sayac3 = 0;

                        foreach (string item in a1)
                        {
                            Console.Write("[{0}]:", sayac3);
                            Console.WriteLine(item);
                            if (sayac3 != 999999)
                                sayac3++;
                        }
                        Console.WriteLine("listelenen arraylistte silmek istediğiniz değerin index numarasını giriniz");
                        int e = int.Parse(Console.ReadLine());
                        a1.RemoveAt(e);
                        Console.WriteLine("değer başarıyla silindi");
                        System.Threading.Thread.Sleep(3000);
                        break;

                    default:
                        Console.WriteLine("1 ile 5 aralığında bir değer giriniz");
                        System.Threading.Thread.Sleep(3000);
                        break;
                }
            } 
            Console.ReadLine();

        }
    }
}
