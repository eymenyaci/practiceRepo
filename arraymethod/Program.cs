using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{   
      public static int migratoryBirds(List<int> arr)
    {   
        List<int> tempList = new List<int>();
        int gecicitekrar = 1;
        int kalicitekrar = 0;
        int sayi = 0;
        //second list created.
        for (int z = 0; z < arr.Count(); z++)
        {
            tempList.Add(arr[z]);
            
        }
        
        for (int i = 0; i < arr.Count()-1; i++)
        {   var temp = tempList[0];
            tempList.Remove(tempList[0]);
            for (int j = 0; j < arr.Count()-1; j++)
            {
                if (arr[i]==tempList[j])
                {
                    gecicitekrar++;
                }
            }
            if (gecicitekrar>kalicitekrar)
            {
                kalicitekrar=gecicitekrar;
                sayi=arr[i];
            }
            else if (gecicitekrar==kalicitekrar && arr[i]<sayi)
            {
                sayi=arr[i];


            }
            gecicitekrar = 1;
            tempList.Add(temp);

            
        }
        return sayi;     
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
