using System;
using System.Collections.Generic;

namespace koleksiyon2
{
    class Solution
    {
        public static void Main(String[] args)
        {
            List<int> sayilar = new List<int>();
            List<int> enKucuk = new List<int>();
            List<int> enBuyuk = new List<int>();
            int enBuyukToplam = 0;
            int enKucukToplam = 0;
            int kontrol = 1;
            while (kontrol<21)
            {
                Console.WriteLine(kontrol+".Sayınızı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
                kontrol++;
            }

            sayilar.Sort();
            for (int i = 0; i < 3; i++)
            {
                enKucuk.Add(sayilar[i]);
                enKucukToplam += sayilar[i];

            }

            for (int i = 17; i < 20; i++)
            {
                enBuyuk.Add(sayilar[i]);
                enBuyukToplam += sayilar[i];
            }

            Console.WriteLine("En Küçük 3 Sayının Ortalaması : "+enKucukToplam/3);
            Console.WriteLine("En Büyük 3 Sayının Ortalaması : "+enBuyukToplam/3);
            Console.WriteLine("En Büyük ve En Küçük Sayıların Toplam Ortalamaları : "+((enKucukToplam/3)+(enBuyukToplam/3)));
            
            













        }
    }
}