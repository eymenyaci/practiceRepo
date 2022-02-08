using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 3;
           int y = 2;
           //y değerine x ekleniyor.
           y+=x;
           Console.WriteLine(y);
           
           bool aktiflik = true;
           bool stokDurumu = false;

           // ve mantıksal operatörü
           if (aktiflik && stokDurumu)
           {
               Console.WriteLine("Mükemmel!");
           }
           else{
               Console.WriteLine("Her iki koşul sağlanmıyor.");
           }
            // veya mantıksal operatörü
           if (aktiflik || stokDurumu)
           {
               Console.WriteLine("Mükemmel!");
           }
           else{
               Console.WriteLine("Her iki koşul sağlanmıyor.");
           }
            // ve mantıksal operatörü
           if (aktiflik != stokDurumu)
           {
               Console.WriteLine("Durumlar aynı değil!");
           }
           else{
               Console.WriteLine("Durumlar Aynı!");
           }



           

        }
    }
}