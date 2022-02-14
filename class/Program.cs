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
            
            //Kurucu metot ile ekleme.
            employee employee1 = new employee("Gizem","Kılıç",12345678,"Media");
           
            
            employee employee2 = new employee();
            employee2.name = "Eymen Batın";
            employee2.surname = "Yacı";
            employee2.no = 12345672;
            employee2.department = "Software";
            
            employee employee3 = new employee("Ramazan","Akyol");
            
            employee1.employeeInfo();
            Console.WriteLine();
            employee2.employeeInfo();
            Console.WriteLine();
            employee3.employeeInfo();
            
            

        }

        class employee
        {
            public string name;
            public string surname;
            public int no;
            public string department;
            
            //Yapıcı metot ile tüm bilgileri get ve set ettik.
            public employee(string name, string surname, int no,string department)
            {
                this.name = name;
                this.surname = surname;
                this.no = no;
                this.department = department;
            }
            //Aşırı Yükleme yaptık ve çalışanın sadece adı ve soyadının set edilmesine izin verdik.
            public employee(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
               
            }
            
            public employee(){}

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