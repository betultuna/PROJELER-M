//Özellik : Kullanıcı tüm kelimeyi tahmin edebilsin.
//Özellik : Tahmin edilmiş harflerin gösterilmesi.
//Özellik : İpucu vermek.
using System;

namespace Hangman
{
    class Program
    {   static string oynananKelime ;
        static char tahmin;
        
        static void Main(string[] args)
        {   //
            ProgramBaslat();
            //
            OyunOyna();
            //
            ProgramBitir();
        }


        private static void ProgramBaslat()
        {
            Console.WriteLine("Program başladı");
            oynananKelime = "araba" ;

        }

        private static void OyunOyna()
        {
            Console.WriteLine("Oyun başladı !");
            //Kelime göster(parametrik, hangi harflerin gösterileceği liste olarak verilebilir)
            KelimeGoster(oynananKelime);
            //Kullanıcıdan tahmin al
            TahminAl();
            //Tahmin değerlendir
            TahminDegerlendir();
            //Tahmin sonrası kelime gösterme
            KelimeGoster(oynananKelime) ;

        }
        private static void TahminDegerlendir()
        {
            Console.WriteLine("Tahmin degerlendirildi..");
        }

        private static void TahminAl()
        {   tahmin = 'a';
            Console.WriteLine("Tahmin edilen harf " + tahmin);
            
        }

        private static void KelimeGoster(string kelime)
        {
            Console.WriteLine(kelime);
        }

        private static void ProgramBitir()
        {
            Console.WriteLine("Program Bitti :(");
        }
    }

}