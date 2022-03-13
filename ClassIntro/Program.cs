using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Talha Aslan";
            kurs1.IzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "TalhaAslan";
            kurs2.IzlenmeOranı = 33;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "TALLLHA Aslan";
            kurs3.IzlenmeOranı = 88;

            Console.WriteLine(kurs2.KursAdi + " : "  + kurs1.IzlenmeOranı +  " " + kurs1.Egitmen);
            

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
               
                Console.WriteLine(kurs.KursAdi + " : " + kurs.IzlenmeOranı + " " + kurs.Egitmen);
                
            } Console.ReadLine();
        }
    }
    
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
}
    
}