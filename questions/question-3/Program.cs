using System;

namespace question3
{
    class Solution
    {
        public static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan 
            // n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            List<string> words = new List<string>();   
            string word;    
            Console.WriteLine("Please add positive number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<1)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                  word = Console.ReadLine();
                  Console.WriteLine("Entry word : " + word);
                  Console.ReadKey();
                  words.Add(word);

                    
                }
                words.Reverse();
                for (int i = 0; i < words.Count(); i++)
                {
                    Console.Write(words[i]+" ");
                }

            }
        }
    }
}