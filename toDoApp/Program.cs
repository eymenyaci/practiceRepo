using System;
using System.Collections.Generic;
using System.Globalization;

namespace toDoApp
{
    class Interface
    {
        public void welcome()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(exit) Çıkış");
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            
            
        }
        
    }
    class CardInfo
    {
        public int id;
        public string title;
        public string content;
        public string user;
        public string size;

        public  CardInfo(int id, string title, string content,string user, string size)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.user = user;
            this.size = size;
        }
        

    }
    class Cards
    {
        public List<CardInfo> todoLine = new List<CardInfo>();
        public List<CardInfo> progressline = new List<CardInfo>();
        public List<CardInfo> doneLine = new List<CardInfo>();
        public void defaultBoard()
        {
            todoLine.Add(new CardInfo(1,"Elasticsearch","Elasticsearch araştırılacak.","Eymen","2 gün"));
            doneLine.Add(new CardInfo(2,"IP ","Yurtdışı IP yönlendirmeleri düzenlenecek.","Ali","7 gün"));
            progressline.Add(new CardInfo(3,"Netsis","Netsis entegrasyonu yazılacak.","Emirhan","30 gün"));
            
        }
    }

    class CommandCards : Cards
    {
        public void boardList()
        {
            
            Console.WriteLine("TODO Line");
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            if (todoLine.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                for (int i = 0; i < todoLine.Count; i++)
                {     
                    Console.WriteLine("Başlık           : {0}",todoLine[i].title);
                    Console.WriteLine("İçerik           : {0}",todoLine[i].content);
                    Console.WriteLine("Atanan Kişi      : {0}",todoLine[i].user);
                    Console.WriteLine("Zaman            : {0}",todoLine[i].size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            if (progressline.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                for (int i = 0; i < progressline.Count; i++)
                {  
                    Console.WriteLine("Başlık           : {0}",progressline[i].title);
                    Console.WriteLine("İçerik           : {0}",progressline[i].content);
                    Console.WriteLine("Atanan Kişi      : {0}",progressline[i].user);
                    Console.WriteLine("Zaman            : {0}",progressline[i].size);
                    Console.WriteLine("-");
                }
            }
            
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            Console.WriteLine("DONE Line");
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            if (doneLine.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                for (int i = 0; i < doneLine.Count; i++)
                {  
                    Console.WriteLine("Başlık           : {0}",doneLine[i].title);
                    Console.WriteLine("İçerik           : {0}",doneLine[i].content);
                    Console.WriteLine("Atanan Kişi      : {0}",doneLine[i].user);
                    Console.WriteLine("Zaman            : Tamamlandı.");
                    Console.WriteLine("-");

                }
            }
            
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            
        }

       

        public void addBoard()
        {
            Interface ıf = new Interface();
            
            Console.Write("Başlık Giriniz                                                 : ");
            string _title = Console.ReadLine();
            Console.Write("İçerik Giriniz                                                 : ");
            string _content = Console.ReadLine();
            Console.Write("Gün Sayısı Giriniz                                             : ");
            string _size = Console.ReadLine();
            Console.Write("Kişi Seçiniz -> Eymen (1), Ali (2), Emirhan (3) seçiniz.       : ");
            int _id = Convert.ToInt32(Console.ReadLine());
            string name = "Eymen";
            if (_id == 1)
            {
                 name = "Eymen";
            }
            else if (_id == 2)
            {
                 name = "Ali";
            }
            else if (_id == 3)
            {
                 name = "Emirhan";
            }
            else
            {
                 name = "Eymen";
            }
            todoLine.Add(new CardInfo(_id,_title,_content,name,_size));
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            Console.WriteLine("{0} başlıklı kart {1} kişisine atandı.",_title,name);
            Console.WriteLine("**************************************************************************" +
                              "*****************************************************");
            ıf.welcome();
            
            
        }

        public void deleteBoard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kart tipini seçmeniz gerekiyor.");
            Console.Write("TODO Line (1), IN PROGRESS Line (2), DONE Line (3) : ");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.Write("Lütfen kart başlığını yazınız : ");
                string _title = Console.ReadLine();
                for (int i = 0; i < todoLine.Count; i++)
                {
                    if (todoLine[i].title == _title)
                    {
                        todoLine.RemoveAt(i);
                    }
                }
                Console.WriteLine("**************************************************************************" +
                                  "*****************************************************");
                Console.WriteLine("{0} başlıklı kart silindi.",_title);
                Console.WriteLine("**************************************************************************" +
                                  "*****************************************************");
            }
            if (answer == "2")
            {
                Console.Write("Lütfen kart başlığını yazınız : ");
                string _title = Console.ReadLine();
                for (int i = 0; i < progressline.Count; i++)
                {
                    if (progressline[i].title == _title)
                    {
                        progressline.RemoveAt(i);
                    }
                }
                Console.WriteLine("**************************************************************************" +
                                  "*****************************************************");
                Console.WriteLine("{0} başlıklı kart silindi.",_title);
                Console.WriteLine("**************************************************************************" +
                                  "*****************************************************");
            }
            if (answer == "3")
            {
                Console.Write("Lütfen kart başlığını yazınız : ");
                string _title = Console.ReadLine();
                for (int i = 0; i < doneLine.Count; i++)
                {
                    if (doneLine[i].title == _title)
                    {
                        doneLine.RemoveAt(i);
                    }
                }
                Console.WriteLine("**************************************************************************" +
                                  "*****************************************************");
                Console.WriteLine("{0} başlıklı kart silindi.",_title);
                Console.WriteLine("**************************************************************************" +
                                  "*****************************************************");
            }
            
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            Interface ıf = new Interface();
            ıf.welcome();
            CommandCards crd = new CommandCards();
            crd.defaultBoard();
            
            while (true)
            {
                string select = Console.ReadLine();
                if (select == "m")
                {
                    ıf.welcome();
                }
                else if (select == "1")
                {
                    crd.boardList();
                }
                else if (select == "2")
                {
                     crd.addBoard();   
                }
                else if (select == "3")
                {
                    crd.deleteBoard();
                }
                else if (select == "4")
                {
                    
                }
                else if (select == "exit")
                {
                    break;
                    
                }
                
            }


        }
    }

}