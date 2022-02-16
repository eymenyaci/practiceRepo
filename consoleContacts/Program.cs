using System;
using System.Collections.Generic;

namespace question
{
    class Interface
    {
        public void WelcomeMethod()
        {   Console.WriteLine("********************************************************************************");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("********************************************************************************");
        }
    }
    class Contact
    {
        public string name;
        public string surname;
        public string phoneNumber;

        public Contact(string name,string surname,string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
    }

    class Contacts
    {
        public List<Contact> contactList = new List<Contact>();
       
        public void defaultContacts()
        {
            contactList.Add(new Contact("Eymen Batın","Yacı","05423681095"));
            contactList.Add(new Contact("Gizem","Dündar","05456419476"));
            contactList.Add(new Contact("Ertuğrul","Dağıtan","05363549523"));
            contactList.Add(new Contact("Ayşe","Vatansever","05347840736"));
            contactList.Add(new Contact("İsmail","Yıldırım","05362470705"));
        }
    }

    class ContactCommands : Contacts
    {
        public void AddContact()
        {
            
            Console.WriteLine("********************************************************************************");
            Console.Write("Lütfen isim giriniz              : ");
            string _name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz           : ");
            string _surname = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz  : ");
            string _phoneNumber = Console.ReadLine();
            contactList.Add(new Contact(_name,_surname,_phoneNumber));
            Console.WriteLine("********************************************************************************");
            
        }

        public void deleteContact()
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz :");
            string text = Console.ReadLine();
            for (int i = 0; i < contactList.Count; i++)
            {
                if (text == )
            }
        }
        public void listedContact()
        {
            defaultContacts();
            Console.WriteLine("********************************************************************************");
            for (int i = 0; i < contactList.Count; i++)
            {
                Console.WriteLine("Ad : {0} "+" -> Soyad : {1}"+" -> Telefon Numarası : {2}",
                    contactList[i].name,contactList[i].surname,contactList[i].phoneNumber);
            }
            Console.WriteLine("********************************************************************************");
            
            
        }
        
    }
    
    
    class Solution
    {
        public static void Main(string[] args)
        {
            Interface welcome = new Interface();
            welcome.WelcomeMethod();
            ContactCommands cmd = new ContactCommands();
            while (true)
            {   
                string enter = Console.ReadLine();
                if (enter == "m")
                {
                    string temp = enter;
                    welcome.WelcomeMethod();
                }
                else if (enter == "1")
                {
                    cmd.AddContact();
                }
                else if (enter == "2")
                {
                    cmd.deleteContact();
                }
                else if (enter == "4")
                {
                    cmd.listedContact();
                }
                else if (enter == "exit")
                {
                    break;
                }
                Console.WriteLine("************** Menüye dönmek için (m) | Çıkış yapmak için (exit) ***************");
                // else if (temp == "m")
                // {
                //     
                // }
            }
           




        }
    }
    
}