using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security;

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
        public List<Contact> contactSearch = new List<Contact>();
       
        public void defaultContacts()
        {
            contactList.Add(new Contact("Eymen Batın","Yacı","05449510912"));
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
                if (text == contactList[i].name || text == contactList[i].surname)
                {
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinecek. Onaylıyor musun ? (y/n)"
                        ,contactList[i].name,contactList[i].surname);
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {   
                        contactList.RemoveAt(i);
                        

                    }

                }
                
            }
            
        }

        public void updateContact()
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz :");
            string text = Console.ReadLine();
            for (int i = 0; i < contactList.Count; i++)
            {
                if (text == contactList[i].name || text == contactList[i].surname)
                {
                    Console.WriteLine("{0} {1} kişisinin telefon numarası : ({2}) ",contactList[i].name
                        ,contactList[i].surname,contactList[i].phoneNumber);
                    Console.Write("Lütfen isim giriniz              : ");
                    string _name = Console.ReadLine();
                    Console.Write("Lütfen soyisim giriniz           : ");
                    string _surname = Console.ReadLine();
                    Console.Write("Lütfen telefon numarası giriniz  : ");
                    string _phoneNumber = Console.ReadLine();
                    contactList[i].name = _name;
                    contactList[i].surname = _surname;
                    contactList[i].phoneNumber = _phoneNumber;


                }
            }
        }
        public void listedContact()
        {
            Contacts cnt = new Contacts();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("A-Z için (1)");
            Console.WriteLine("Z-A için (2)");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                contactList.Sort((u1,u2) =>u1.name.CompareTo(u2.name));
                for (int i = 0; i < contactList.Count; i++)
                {
                    
                    Console.WriteLine("İsim             : {0}",contactList[i].name);
                    Console.WriteLine("Soyisim          : {0}",contactList[i].surname);
                    Console.WriteLine("Telefon Numarası : {0}",contactList[i].phoneNumber);
                    Console.WriteLine("-");
                    
                    
                }
            }
            else if (answer == "2")
            {
                contactList.Sort((u1,u2) => u2.name.CompareTo(u1.name));
                for (int i = 0; i < contactList.Count; i++)
                {
                    Console.WriteLine("İsim             : {0}",contactList[i].name);
                    Console.WriteLine("Soyisim          : {0}",contactList[i].surname);
                    Console.WriteLine("Telefon Numarası : {0}",contactList[i].phoneNumber);
                    Console.WriteLine("-");
                    
                }
                
            }
            Console.WriteLine("********************************************************************************");
        }
        public void quickSearch()
        {
            
            
            Console.WriteLine("Sıralama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("İsim veya Soyisme göre arama yapmak için : (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
            string answer = Console.ReadLine();
            if (answer == "1")
            {   Console.Write("Aramak için bir ad girin : ");
                string text = Console.ReadLine();
                for (int i = 0; i < contactList.Count; i++)
                {
                    if (text == contactList[i].name || text == contactList[i].surname)
                    {
                        Console.WriteLine("İsim             : {0}",contactList[i].name);
                        Console.WriteLine("Soyisim          : {0}",contactList[i].surname);
                        Console.WriteLine("Telefon Numarası : {0}",contactList[i].phoneNumber);
                        Console.WriteLine("-");
                        

                    }
                
                }

            }
            else if (answer == "2")
            {
                Console.Write("Aramak için bir telefon numarası girin : ");
                string text = Console.ReadLine();
                for (int i = 0; i < contactList.Count; i++)
                {
                    if (text == contactList[i].phoneNumber)
                    {
                        Console.WriteLine("İsim             : {0}",contactList[i].name);
                        Console.WriteLine("Soyisim          : {0}",contactList[i].surname);
                        Console.WriteLine("Telefon Numarası : {0}",contactList[i].phoneNumber);
                        Console.WriteLine("-");
                        

                    }
                
                }
            }
            
        }
    }
    
    
    class Solution
    {
        public static void Main(string[] args)
        {   
            Interface welcome = new Interface();
            welcome.WelcomeMethod();
            ContactCommands cmd = new ContactCommands();
            cmd.defaultContacts();
            
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
                else if (enter == "3")
                {
                    cmd.updateContact();
                }
                else if (enter == "4")
                {
                    cmd.listedContact();
                }
                else if (enter == "5")
                {
                    cmd.quickSearch();
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