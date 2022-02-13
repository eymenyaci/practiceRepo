using System;
using System.Collections.Generic; // <--- !

class Printer
{
    static void Main(string[] args)
	{
		List<int> posiviteNumberList = new List<int>();
		
		while(true)
		{
			int number = Convert.ToInt32(Console.ReadLine());
			if (number>0)
			{
				posiviteNumberList.Add(number);
			}
			else break;
		}
		// foreach (var item in posiviteNumberList)
		// {
		// 	Console.Write(item+" ");
			
		// }
		
		
	}
	
}