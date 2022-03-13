using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımGeliştirmeKampı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = " Kategoriler";
            int ögrencisayisi = 32000;
            double faizoranı = 1.45;
            bool sistemegirisyapmısmi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemegirisyapmısmi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else 
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(KategoriEtiketi);
           

            Console.ReadLine();
            } 
            
        }
      
    }
   

