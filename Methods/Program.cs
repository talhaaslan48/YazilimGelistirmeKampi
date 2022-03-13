using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Aciklama = "Amasya Elması";
            product1.fiyati = 15;
            product1.stokAdedi = 34;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.stokAdedi = 11;
            Product[] products = new Product[] {product1,product2};

            //type-safety
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.stokAdedi);
                Console.WriteLine("---------------");
            }
            

            Console.WriteLine("----------------Metotlar-----------");


            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product1);

        
            Console.ReadLine();
        }
    }
}

// Dont repeat yourself - DRY -Clean Code - Best Practice
