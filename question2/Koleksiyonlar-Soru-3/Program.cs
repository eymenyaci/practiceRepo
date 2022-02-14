using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace question3
{
    class Solution
    {
        public static void Main(string[] args)
        {
            char[] vowel = {'a','e','ı','i','o','ö','u','ü'};
            ArrayList textVowel = new ArrayList();
            Console.WriteLine("Please Text : ");
            string text = Console.ReadLine();
            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (text[i] == vowel[j])
                    {
                        if (textVowel.Contains(vowel[j]))
                        {
                            break;

                        }
                        else
                        {
                            textVowel.Add(vowel[j]);
                        }
                        

                    }
                }
                
            }

            textVowel.Sort();
            
            for (int i = 0; i < textVowel.Count; i++)
            {
                Console.Write(textVowel[i]+" ");
            }
            
            


        }
    }
}