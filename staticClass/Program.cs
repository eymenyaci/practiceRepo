using System;
using System.Reflection.Metadata;

namespace statics
{
    class solution
    {
        static void Main(string[] args)
        {   
            //Çalışan sayısı 0.
            Console.WriteLine("Şirketin çalışan sayısı : {0} ",employee._employeeCount);
            employee emp1 = new employee("Eymen Batın","Yacı","Software");
            //Çalışan sayısı 1.
            Console.WriteLine("Şirketin çalışan sayısı : {0} ",employee._employeeCount);
            Console.WriteLine(islemler.topla(1,2));



        }
    }

    class employee
    {
        private static int  employeeCount;
        
        
        //Private static int olan özelliğimizi get set ediyoruz.
        public static int _employeeCount
        {
            get => employeeCount;
            

        }
        private string name;
        private string surname;
        private string department;

        static employee()
        {   //Program ilk çalıştığında çalışan sayısı bu metot sayesinde 0 olarak başlar.
            employeeCount = 0;

        }

        public employee(string name,string surname,string department)
        {
            //Kurucu metodun özelliklerini set ediyoruz.
            this.name = name;
            this.surname = surname;
            this.department = department;
            //Yeni çalışan eklerken çalışan sayısı +=1
            employeeCount++;
        }
        
        
    }
    
    //Static Class içinde bulunan bütün metotlar Static olmak zorundadır.
    static class islemler
    {
        public static int topla(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}