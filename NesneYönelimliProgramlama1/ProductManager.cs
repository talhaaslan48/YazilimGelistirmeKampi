using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYönelimliProgramlama1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
           Console.WriteLine( product.ProductName + " eklendi." ) ;
        }

        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }
        
    }
}
