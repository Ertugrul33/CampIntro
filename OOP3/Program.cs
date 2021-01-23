using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //Interface'ler de o class'ın referansını tutabilir.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService(), new SMSLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers); //krediManager gönderilemez. Çünkü new'lenemez. O yüzden kullanıcı neyi seçerse o gönderilmelidir. (Mülakatta başarıyla geçilecek bilgiler)
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
