using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Talha";
            musteri1.Soyadi = "Aslan";
            musteri1.TcNo = "22221221222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 22;
            musteri2.MusteriNo = "2143452532";
            musteri2.SirketAdi = "Aslan Bankacılık";
            musteri2.VergiNo = "1111111111111";
            


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Ekle(musteri1);
            customerManager1.Ekle(musteri2);



            Console.ReadLine();
        }
    }
}
