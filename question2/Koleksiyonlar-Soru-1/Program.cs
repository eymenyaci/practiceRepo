using System;
using System.Collections.Generic;

namespace question1
{
    class Solution
    {
        public static void Main(String[] args)
        {
            List<int> asal = new List<int>();
            List<int> asalOlmayan = new List<int>();
            int kontrol = 0;
            int bolunebilirlik = 0;
            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            while (kontrol<5)
            {   
                Console.WriteLine("Pozitif bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            bolunebilirlik++;

                        }
                                               
                        
                    }

                    if (bolunebilirlik == 0)
                    {
                        asal.Add(sayi);
                    }
                    else
                    {
                        asalOlmayan.Add(sayi);
                    }

                    bolunebilirlik = 0;
                    kontrol++;
                }
            }
            Console.Write(" Asal Sayılar -> ");
            foreach (int sayi in asal)
            {   
                Console.Write(sayi+" ");
                asalToplam += sayi;

            }
            Console.WriteLine();
            Console.Write("Asal Olmayan Sayılar ->");
            foreach (int sayi in asalOlmayan)
            {
                Console.Write(sayi+" ");
                asalOlmayanToplam += sayi;
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olanların Eleman Sayısı -> " + asal.Count()+" Ortalaması -> "+
                              asalToplam/asal.Count());
            Console.WriteLine("Asal Olmayanların Eleman Sayısı -> " + asalOlmayan.Count()+" Ortalaması -> "+
                              asalOlmayanToplam/asalOlmayan.Count());







        }
    }
}