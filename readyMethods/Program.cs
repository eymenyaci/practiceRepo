using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. 
        Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> list = new List<string>();        
        int counter=0;
        for (int i = 0; i < n; i++)
        {
            string temp = Console.ReadLine();
            list.Add(temp);


        }
        
        for (int j = 0; j < n; j++)
        {
            string temp2 = list[j];

            for (int k = 0; k < temp2.Length; k++)
            {
                if (k % 2 == 0)
                {
                    Console.Write(temp2[k]);
                }
                

            }
            Console.Write(" ");


            for (int z = 0; z < temp2.Length; z++)
            {
                if (z % 2 != 0)
                {
                    Console.Write(temp2[z]);
                }
                
            }
            counter++;
            Console.WriteLine();



        }





    }
}