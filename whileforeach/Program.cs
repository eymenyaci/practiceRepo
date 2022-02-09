using System;

namespace whileforeach
{
    class Program
    {
        public static void Main(String[] args)
        {
            // int toplam =0;
            // int adimsayisi=0;
            // int ortalama=0;
            // while(true)
            // {  
            //     Console.WriteLine("Sayı giriniz : ");
            //     int n = Convert.ToInt32(Console.ReadLine());
            //         if (n>0)
            //         {
            //             adimsayisi++;
                    
            //             toplam+=n;
            //             ortalama=toplam/adimsayisi;
            //         }
            //         else{
            //             break;
            //         }
                    
                


            // }
        
            // Console.WriteLine("Girdiğiniz sayıların ortalaması : "+ortalama);

            int[] sayiDizisi = {1,4,5,8,12,18,21,3};
            int toplam=0;
            foreach (int i in sayiDizisi)
            {
                toplam+=i;
                
            }
            Console.WriteLine("Toplam : "+toplam);
           

        }
    }
}