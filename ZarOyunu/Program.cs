﻿using System;

namespace ZarOyunu
{
    class Program
    {   
        static void Main(string[] args)
        {
            int oyunSonuc = Oyna();
            Final(oyunSonuc);
        }

        private static int Oyna()
        {
            Random zar = new Random();
            // Zarlar atılıyor
            int atis1 = zar.Next(1, 7);
            int atis2 = zar.Next(1, 7);
            int atis3 = zar.Next(1, 7);
            int toplam = atis1 + atis2 + atis3;
            int ekstra = EkstraDegerlendir(atis1,atis2,atis3);
            int puan = toplam + ekstra;
            Console.WriteLine("Puan : " + puan);
            return puan;
        }
        
        private static int EkstraDegerlendir(int z1, int z2 ,int z3)
        {   int degisken;

            if(z1 == z2 && z2 == z3 )
            {
                //3 zar aynı
                degisken = 6;

            }
            else if (z1 == z2 || z2 == z3|| z1 == z3 )
            {
                //2 zar aynı
                degisken = 2;
            }
            else {
                degisken = 0;
            }
            // algoritma gelecek
            //iki zar aynı 2
            //üç zar aynı 6
            return degisken ;

        }
        private static void Final(int p)
        {
            if (p > 15)
            {
                // Kazanma koşulu
                Console.WriteLine("Kazandın");
            }
            else
            {
                // Kaybettin...
                Console.WriteLine("Kaybettin...");
            }

        }
    }
}
