using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager =  new KonutKrediManager();
            IKrediManager esnafkrediManager = new EsnafKrediManager();
            

            ILoggerService databaselogger = new DataBaseLoggerService();
            ILoggerService filelogger = new FileLoggerService();
            ILoggerService smslogger = new SmsLoggerService();

            List<ILoggerService> loggers  = new List<ILoggerService> { new SmsLoggerService() , new FileLoggerService()};


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap( esnafkrediManager , loggers);

            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , konutKrediManager , tasitKrediManager};


            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine(); 
        }
    }
}
