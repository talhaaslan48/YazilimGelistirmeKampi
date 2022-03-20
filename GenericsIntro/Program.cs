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

            List <string> liste = new List<string>();
            Console.WriteLine(liste.Count);
            Console.ReadLine();
        }
    }
}
