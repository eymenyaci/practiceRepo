using System;

namespace question2
{
    class Solution
    {


        public static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            List<int> numbers = new List<int>();
            int counter=0;
            while (true)
            {
                Console.WriteLine("please add positive numbers : ");
                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && m > 0)
                {
                    Console.WriteLine("Calculating...");
                    while(true)
                    {
                        
                        int entered = Convert.ToInt32(Console.ReadLine());
                        counter++;
                        
                        if (entered == m || m%entered==0)
                        {
                            numbers.Add(entered);
                            
                            
                        }
                        if (counter==n)
                        {
                            break;
                        }
                        
                        

                    }
                    break;
                }
            }
            foreach (var item in numbers)
            {
                Console.Write(item+" ");
                
            }

            // for (int i = 0; i < n; i++)
            // {
            //     
            //     if (entered == m || m % entered == 0)
            //     {
            //         numbers.Add(entered);
            //     }

            // }








        }



    }

}