using System;

namespace classes
{
    class Education
    {
        public static void Main(String[] args)
        {
            /*Söz Dizimi
             * class sinifAdi
             *{
             * [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
             * [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi ([Parametre Listesi])
             *  {
             *   Metot Komutları
             *  }
             * }
             *
             * ERİŞİM BELİRLEYİCİLER
             * * Public
             * * Private
             * * Internal
             * * Protected
             *
                */
            employee employee1 = new employee();
            employee1.name = "Gizem";
            employee1.surname = "Kılıç";
            employee1.no = 12345678;
            employee1.department = "Media";
            
            employee employee2 = new employee();
            employee2.name = "Eymen Batın";
            employee2.surname = "Yacı";
            employee2.no = 12345672;
            employee2.department = "Software";
            
            employee1.employeeInfo();
            Console.WriteLine();
            employee2.employeeInfo();
            
            

        }

        class employee
        {
            public string name;
            public string surname;
            public int no;
            public string department;

            public void employeeInfo()
            {
                Console.WriteLine("Employee Name : {0}",name);
                Console.WriteLine("Employee Surname : {0}",surname);
                Console.WriteLine("Employee No : {0}",no);
                Console.WriteLine("Employee Department : {0}",department);
            }
            
        }
    }
}