using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D3.HashTableÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add("merhaba", "hi");
            h1.Add("evet", "yes");
            string evethayir = string.Empty;
            string türkce = string.Empty;
            string ingilizce = string.Empty;



            while (evethayir!="h")
            {
                Console.Write("yeni kayıt eklemek istiyormusunuz e/h");
                evethayir = Console.ReadLine();
                if (evethayir.ToLower() == "e")
                {
                    Console.Clear();
                   
                    Console.Write("eklemek istediğinz değerin türkçesini giriniz:");
                    türkce = Console.ReadLine();
                    Console.WriteLine("eklemek istediğinz değerin ingilizcesini giriniz:");
                    ingilizce = Console.ReadLine();
                    if (h1.Contains(türkce))
                    {
                        Console.WriteLine("eklemek istediğiniz değer:{0} zaten bulunmaktadır,lütfen başka bir değer girişi gerçekleştirin", türkce);
                        System.Threading.Thread.Sleep(3000);
                    }
                    else
                    {
                        h1.Add(türkce, ingilizce);
                        Console.WriteLine("{0} değeri başarıyla eklenmiştir",türkce);
                        System.Threading.Thread.Sleep(3000);
                    }
                    
                }
                if (evethayir.ToLower() == "h")
                {
                    foreach (var item in h1.Keys)
                    {
                        Console.WriteLine("{0}:{1}",item,h1[item]);
                    }
                    System.Threading.Thread.Sleep(3000);

                    break;

                    //foreach (DictionaryEntry item in h1)
                    //{
                    //    item.GetType().Name; //h1 hashtableyi algılayıp dictionentry türünden oldugunu iletti.           alternatif "h" senaryosu
                    //    Console.WriteLine("{0}:{1}",item.Key,item.Value);
                    }
                }
            }
        }
    }

