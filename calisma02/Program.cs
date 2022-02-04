using System;
namespace Usem.Calisma01
{
    class OzelProgram
    {
        static void Main()
        {
            string deger;
            string sonDeger;

            // Giriş
            deger = Giris();

            // İşlemler
            sonDeger = Proses(deger);

            // Çıkış işlemler
            Cikis(sonDeger);
        }

        static string Giris()
        {
            string girisM;
            // Giriş işlemleri
            Console.WriteLine("Giriş Yapınız...");
            girisM = Console.ReadLine();
            int uzunluk = girisM.Length;
            if (uzunluk > 3)
            {

            } 
            else
            {

            }

            return girisM;
        }

        static string Proses(string g)
        {
            // String işlemler
            string cikisM;
            cikisM = "Giriş :  " + g;
            return cikisM;

        }

        static void Cikis(string c)
        {
            // Çıkış İşlemler
            Console.WriteLine(c);
        } 
    }
}


