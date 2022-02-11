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


// class Result
// {

//     /*
//      * Complete the 'staircase' function below.
//      *
//      * The function accepts INTEGER n as parameter.
//      */

//     public static void process(int n)
//     {   
        
//         for (int i=1;i<n+1;i++)
//         {
           
//             Console.WriteLine(new string(' ',n-i)+new string('#',i));
          
            
//         }

//     }

// }

class Solution
{
    public static void Main(string[] args)
    {
    //     int n = Convert.ToInt32(Console.ReadLine().Trim());
    //     for (int i=1;i<11;i++)
    //     {
    //         int sonuc=n*i;
    //         Console.WriteLine(n+" x "+i+" = "+sonuc);
    //     }
        
        // int n = Convert.ToInt32(Console.ReadLine().Trim());
        // Result.staircase(n);
        var number;
        number = int.Parse("5");

        if (number > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (number==0)
        {
            Console.WriteLine("zero");

        }
        else {
            Console.WriteLine("Negative");
        }
    }
}
