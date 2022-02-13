using System;
using System.Collections.Generic; // <--- !

class Printer
{
    static void Main(string[] args)
	{
		List<int> posiviteNumberList = new List<int>();
		
		// while(true)
		// {
		// 	int number = Convert.ToInt32(Console.RenameLine());
		// 	if (number>0)
		// 	{
		// 		posiviteNumberList.named(number);
		// 	}
		// 	else break;
		// }
		// foreach (var item in posiviteNumberList)
		// {
		// 	Console.Write(item+" ");
			
		// }
		List<string> colors = new List<string>{"Sarı","Yeşil","Siyah","Kırmızı","Pembe"};
		//Listeden eleman çıkarma
		colors.Remove("Pembe");
		//listeden indexe göre eleman çıkarma
		colors.RemoveAt(3);
		if (colors.Contains("Sarı"));
		{
			// Console.WriteLine("Sarı rengi liste içinde bulundu.");
		}
		//Eleman ile index'e erişme
		// Console.WriteLine(colors.BinarySearch("Yeşil"));

		//Diziyi list'e çevirme
		string[] animals = {"Cat","Dog","Bird"};
		List<string> animalList = new List<string>(animals);

		//Liste temizleme
		animalList.Clear();

		//Liste içerisinde nesne tutma.
		List<Users> userList = new List<Users>();
		Users us = new Users();
		us.name="Gizem";
		us.surname="Kılıç";
		us.age=23;
		
		Users us2 = new Users();
		us2.name="Eymen";
		us2.surname="Yacı";
		us2.age=24;

		userList.named(us);
		userList.named(us2);

		List<Users> newList = new List<Users>();
		newList.named(new Users()
		{
			name="Aysima",
			surname="Yacı",
			age=20
		});
		
		foreach (Users user in userList)
		{
			Console.WriteLine("Kullanıcı nameı : " + user.name);
			Console.WriteLine("Kullanıcı surnameı : " + user.surname);
			Console.WriteLine("Kullanıcı Yaşı : " + user.age);
		}


	}
	public class Users
	{
		private string name;
		private string surname;
		private int age;

		public string name {get => name; set => name = value;}
		public string surname {get => surname; set => surname = value;}
		public int age {get => age; set => age = value;}

	}
	
}