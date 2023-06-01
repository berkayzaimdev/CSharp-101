using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.proje2
{
    class Test
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.lines.Add(new Line("TODO", new List<Card>()));
            board.lines.Add(new Line("IN PROGRESS", new List<Card>()));
            board.lines.Add(new Line("DONE", new List<Card>()));
            Person.allpersons.Add(new Person("michael jordan"));
            Person.allpersons.Add(new Person("stephen curry"));
            Person.allpersons.Add(new Person("lebron james"));
            Person.allpersons.Add(new Person("kobe bryant"));
            string header, inside, personname;
            bool done = false; ;
            int size,personid,choice1,choice2;
            do
            {
                Console.WriteLine("1- Board Listele\n2- Board'a Kart Ekle\n3- Board'dan Kart Silme\n4- Kart Taşıma\n5- Takım Üyelerini Görüntüle");
                Console.WriteLine("********************");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                choice1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch(choice1)
                {
                    case 1:
                        board.Print();
                        break;
                    case 2:
                        Console.Write("Başlık giriniz: ");
                        header = Console.ReadLine();
                        Console.Write("İçerik giriniz: ");
                        inside = Console.ReadLine();
                        Console.Write("Büyüklük seçiniz [XS(1),S(2),M(3),L(4),XL(5)]: ");
                        size = int.Parse(Console.ReadLine());
                        Console.Write("Kişi seçiniz (ID ile): ");
                        personid = int.Parse(Console.ReadLine());
                        board.lines[0].cardlist.Add(new Card(header, inside, Person.FetchByID(personid),size));
                        break;
                    case 3:
                        Console.Write("Lütfen kart başlığını yazınız:");
                        header = Console.ReadLine();
                        foreach(Line list in board.lines)
                        {
                            foreach(Card card in list.cardlist)
                            {
                                if (header == card.header)
                                {
                                    list.cardlist.Remove(card);
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:
                        done = false;
                        Console.Write("Lütfen kart başlığını yazınız:");
                        header = Console.ReadLine();
                        foreach(Line list in board.lines)
                        {
                            foreach(Card card in list.cardlist)
                            {
                                if (header == card.header)
                                {
                                    Console.WriteLine("Bulunan Kart Bilgileri:");
                                    Console.WriteLine("****************************************");
                                    Console.WriteLine("* Başlık: {0,-29}*", card.header);
                                    Console.WriteLine("* İçerik: {0,-29}*", card.inside);
                                    Console.WriteLine("* Atanan Kişi: {0,-24}*", card.person.name);
                                    Console.WriteLine("* Büyüklük: {0,-27}*", card.boyut);
                                    Console.WriteLine("* Line: {0,-31}*", list.displayname);
                                    Console.WriteLine("****************************************\n\n");
                                    list.cardlist.Remove(card);
                                    done = true;
                                    break;
                                } 
                            }
                            if (done) break;
                        }
                        break;
                    case 5:
                        foreach(Person person in Person.allpersons)
                        {
                            Console.WriteLine("************************");
                            Console.WriteLine("* ID: {0,-17}*",person.id);
                            Console.WriteLine("* İsim: {0,-15}*", person.name);
                            Console.WriteLine("************************\n\n");
                        }
                        break;
                    case 6:
                        break;
                }
            }
            while (choice1 != 6);
        }
    }
}
