using System;

namespace question4
{
    class Solution
    {
        public static void Main(String[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("Please text..");
            string text = Console.ReadLine();
            int length = text.Length;
            Console.ReadKey();
            int hUnit = 0;
            int word = 1;
            
            for (int i = 0; i < length; i++)
            {
                if (text[i]!=' ')
                {
                    hUnit++;

                }
                else if (text[i]==' ')
                {
                    word++;
                }
                
            }
            Console.WriteLine("Bu cümlede "+hUnit+" harf "+word+" kelime vardır.");
                
            
            
        }
    }
}
