using System;

namespace question1
{
   
    
    class program
    {
        public static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında
            // kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının 
            // girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            
            Console.WriteLine("Please enter how many numbers in : ");
            int v = Convert.ToInt32(Console.ReadLine());
            int entered = enteredUnit(v);
            List<int> evenList = new List<int>();
            for (int i = 0; i < entered; i++)
            {   
                Console.WriteLine("Please Posivite number add : ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n%2==0)
                {
                   evenList.Add(n);
                }

            }
            foreach (var item in evenList)
            {
                Console.Write(item+" ");
            }
            
                      

        }
        public static int enteredUnit(int n)
        {
           
            while (n<1)
            {
                Console.WriteLine("Again enter a positive number :");
                n = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine(n+" to be entered.");
            return n;
            
        }
       

    }
    
}