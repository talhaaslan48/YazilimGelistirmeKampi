using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Talha");

            Console.WriteLine(isimler.length);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            Console.ReadLine();
        }
    }
}
