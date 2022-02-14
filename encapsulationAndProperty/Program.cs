using System;

namespace encapsulation
{
    class Solution
    {
        public static void Main(string[] args)
        {
            student std1 = new student();
            std1.Name = "Gizem";
            std1.Surname = "Kılıç";
            std1.StudentNo = 1736;
            std1.StudentClass = 11;
            
            student std2 = new student();
            std2.Name = "Eymen Batın";
            std2.Surname = "Yacı";
            std2.StudentNo = 1728;
            std2.StudentClass = 1;

            
            std2.upClass();
            std1.studentInfo();
            std2.studentInfo();
            std1.upClass();
            
            

        }

        class student
        {
            private string name;
            private string surname;
            private int studentNo;
            private int studentClass;
            
            // Farklı bir anahtar kelimeyle name kelimesini Name haline çevirip get set ettik.
            // Bunun nedeni oluşturulan property değişkenlerine ulaşmak.
            //Get veriyi okumamıza yarıyor. Set ise yeni bir yazma işlemi yapmamızı sağlıyor.
            
            
            public string Name{get => name; set => name = value; }
            public string Surname{get => surname; set => surname = value; }
            public int StudentNo{get => studentNo; set => studentNo = value; }
            
            public int StudentClass{get => studentClass; set => studentClass = value; }

            public student()
            {
                Name = name;
                Surname = surname;
                StudentNo = studentNo;
                StudentClass = studentClass;
            }
            
           
            //Aldığımız bilgileri print etmemize yarayan metot.
            public void studentInfo()
            {
                Console.WriteLine("************Öğrenci Bilgileri************");
                Console.WriteLine("Öğrenci Adı      : {0} ",this.Name);
                Console.WriteLine("Öğrenci Soyadı   : {0} ",this.Surname);
                Console.WriteLine("Öğrenci Numarası : {0} ",this.StudentNo);
                Console.WriteLine("Öğrenci Sınıfı   : {0} ",this.StudentClass);
            }
            
            //studentClass int değişkenini 1 arttırmamıza yarayan metot.
            public void upClass()
            {
                this.StudentClass += 1;
            }
            //studentClass int değişkenini 1 azaltmamıza yarayan metot.
            public void downClass()
            {
                this.StudentClass -= 1;
                
            }
            
        }
    }
}