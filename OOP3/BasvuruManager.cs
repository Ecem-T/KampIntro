using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuru bilgilerini değerlendirme
            //


            krediManager.Hesapla();           

            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //Liste yollanır.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
            
        }
    }
}
