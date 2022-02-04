using System;
namespace Usem.Calisma01
{
    class OzelProgram
    {
        static string ortadaDeger;

        static void Main()
        {

            // Giriş
            Giris();

            // İşlemler
            Proses();

            // Çıkış işlemler
            Cikis();

        }

        static void Giris()
        {
            // string girisM;
            // Giriş işlemleri
            Console.WriteLine("Giriş Yapınız...(en az 3 karakter)");
            ortadaDeger = Console.ReadLine();
            //ortaDeger = Gecerli() ? ortaDeger : "TEST";

            if (Gecerli())
            {
                ortadaDeger = ortadaDeger;
            }
            else
            {
                ortadaDeger = "TEST";
            }
        }

        static bool Gecerli()
        {
            bool gecerli = true;

            // uzunluk hesaplama
            int uzunluk = ortadaDeger.Length;

            // uzunluk değerlendirme
            if (uzunluk > 3)
            {
                // koşul TRUE doğru ise çalıştırılır
                gecerli = true;
            }
            else
            {
                // koşul FALSE yanlış ise çalıştırılır
                gecerli = false;
            }
            return gecerli;
        }

        static void Proses()
        {
            // String işlemler
            ortadaDeger = "Giriş :  " + ortadaDeger;
        }

        static void Cikis()
        {
            // Çıkış İşlemler
            Console.WriteLine(ortadaDeger);
        }
    }
}
// bool devam = true;

// while (devam) // bool değeri ile kontrol ediliyor. 
// {
//     // Console.Clear();
//     // Console.WriteLine("1");
//     // Console.WriteLine("MENU : Devam?");
//     // Console.WriteLine("===============");

//     string giris = Console.ReadLine();
//     if (giris == "h")
//     {
//         devam = false;
//     }
// }


// Doğru döngüyü seçmek​
// While		: yineleme sayısını tam olarak bilmiyorsan​
// Do While	    : yineleme sayısını tam olarak bilmiyorsan ama en az bir kez işlem yapılsın istiyorsan​
// For			: yineleme sayısını tam olarak biliyorsun​
// For Each	    : bir koleksiyonda yer alan her bir eleman için işlem yapmak istiyorsan​

