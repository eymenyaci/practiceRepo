using System;

namespace tryCatchFinally
{
    class Program
    {

    
         public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayınız : " + sayi);
            }
            catch(Exception hata)
            {
                Console.WriteLine("Bir hata oluştu ! " + hata.Message );
            }
             
        }
    }
}
