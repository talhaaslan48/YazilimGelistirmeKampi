using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "java";
            string kurs2 = "c";
            string kurs3 = "pyhton";
            string[] kurslar = new string[]{ "java", "c", "pyhton", "c++" };
            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);    
            }
            Console.WriteLine("Sayfa Sonu");
            Console.ReadLine();
        }
    }
}
