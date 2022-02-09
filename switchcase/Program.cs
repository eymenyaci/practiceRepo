using System;

namespace switchcase
{
    class Program
    {
        public static void Main(String[] args)
        {   
            
            Console.WriteLine("Bir Sayı Giriniz...");
            int degisken = Convert.ToInt32(Console.ReadLine());
            
            
            
             switch (degisken)
            {
                case 1 :
                    Console.WriteLine("Sayı 1 dir.");
                    break;
                case 2 :
                    Console.WriteLine("Sayı 2 dir."); 
                    break; 
                default:
                    Console.WriteLine("Sayı 1 ya da 2 değil");
                    break;      
                
            }
        }
    }
}