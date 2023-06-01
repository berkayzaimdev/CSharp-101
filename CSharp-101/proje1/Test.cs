using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.proje1
{
    class Test
    {
        private static int secim1;
        static void Main(string[] args)
        {
            List<Kisi> rehber = new List<Kisi> 
            {
                new Kisi("LeBron", "James", "2222"),
                new Kisi("Kobe", "Bryant", "3333"),
                new Kisi("Michael", "Jordan", "1111"),
                new Kisi("Stephen", "Curry", "4444"),
                new Kisi("Kevin", "Durant", "5555"),
            };
            int secim1,secim2;
            String name, surname, number;
            string searchable;
            do
            {
                Console.WriteLine("BZ TELEKOMÜNİKASYON");
                Console.WriteLine("====================");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("1. Numara Kaydet");
                Console.WriteLine("2. Numara Sil");
                Console.WriteLine("3. Numara Güncelle");
                Console.WriteLine("4. Rehberi Listele");
                Console.WriteLine("5. Rehberde Arama Yap");
                Console.WriteLine("6. Çıkış Yap");

                Console.WriteLine("Seçiminiz: ");
                secim1 = int.Parse(Console.ReadLine());
                switch (secim1)
                {
                    case 1:
                        Console.Write(" İsim: ");
                        name=Console.ReadLine();
                        Console.Write(" Soyisim: ");
                        surname = Console.ReadLine();
                        Console.Write(" Numara: ");
                        number = Console.ReadLine();
                        rehber.Add(new Kisi(name, surname, number));
                        break;
                    case 2:
                        headToDelete:
                        Console.Write(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        searchable = Console.ReadLine();
                        Kisi foundToDelete = callName(rehber, searchable);
                        if (foundToDelete != null)
                        {
                            Console.WriteLine(" {0} {1} rehberden silinecektir. Onaylıyor musunuz?(y/n)", foundToDelete.Name, foundToDelete.Surname);
                            string secim3 = Console.ReadLine();
                            if (secim3 == "y")
                                rehber.Remove(foundToDelete);
                            else break;
                        }
                        else 
                        {
                            Console.WriteLine(" Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("  * Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("  * Yeniden denemek için      : (2)");
                            int secim4 = Int32.Parse(Console.ReadLine());
                            if (secim4 == 1) break;
                            else goto headToDelete;
                        }
                        break;
                    case 3:
                        headToUpdate:
                        Console.Write(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                        searchable = Console.ReadLine();
                        Kisi foundToUpdate = callName(rehber, searchable);
                        if (foundToUpdate != null)
                        {
                            Console.Write(" İsim: ");
                            name = Console.ReadLine();
                            Console.Write(" Soyisim: ");
                            surname = Console.ReadLine();
                            Console.Write(" Numara: ");
                            number = Console.ReadLine();
                            foundToUpdate.Name=name;
                            foundToUpdate.Surname=surname;
                            foundToUpdate.Number=number;
                            Console.WriteLine("Güncelleme işlemi başarılı!");
                        }
                        else 
                        {
                            Console.WriteLine(" Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("  * Güncellemeyi sonlandırmak için : (1)");
                            Console.WriteLine("  * Yeniden denemek için      : (2)");
                            int secim4 = Int32.Parse(Console.ReadLine());
                            if (secim4 == 1) break;
                            else goto headToUpdate;
                        }
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine(" 1. A-Z sıralama");
                            Console.WriteLine(" 2. Z-A sıralama");
                            Console.WriteLine(" Seçiniz:");
                            secim2 = int.Parse(Console.ReadLine());
                            if(secim2==1)
                                callName(rehber.OrderBy(value => value.Name),null);
                            if (secim2 == 2)
                                callName(rehber.OrderBy(value => value.Name).Reverse(),null);
                        }while(secim2!=1 && secim2!=2);
                        break;
                    case 5:
                        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1) Telefon numarasına göre arama yapmak için: (2)");
                        int secim5 = int.Parse(Console.ReadLine());
                        if (secim5 == 1)
                        {
                            Console.Write("Aramak istediğiniz kişinin isim ya da soyismini giriniz: ");
                            string nameorsurname = Console.ReadLine();
                            foreach(Kisi kisi in callNameAndNumber(rehber,nameorsurname,true))
                            {
                                Console.WriteLine("**********************");
                                Console.WriteLine(" İsim: " + kisi.Name);
                                Console.WriteLine(" Soyisim: " + kisi.Surname);
                                Console.WriteLine(" Numara: " + kisi.Number);
                                Console.WriteLine("**********************");
                                Console.WriteLine("\n\n");
                            }
                        }
                        if(secim5==2)
                        {
                            Console.Write("Aramak istediğiniz kişinin numarasını giriniz: ");
                            string searchednumber = Console.ReadLine();
                            foreach (Kisi kisi in callNameAndNumber(rehber, searchednumber,false))
                            {
                                Console.WriteLine("**********************");
                                Console.WriteLine(" İsim: " + kisi.Name);
                                Console.WriteLine(" Soyisim: " + kisi.Surname);
                                Console.WriteLine(" Numara: " + kisi.Number);
                                Console.WriteLine("**********************");
                                Console.WriteLine("\n\n");
                            }
                        }
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                        break;
                }
                Console.WriteLine("\n\n");
            }while(secim1!=6);
        }

        static Kisi callName(IEnumerable<Kisi> sorted,string searchable)
        {
            Kisi temp = null;
            foreach (Kisi kisi in sorted)
            {
                if (searchable == null)
                {
                    Console.WriteLine("**********************");
                    Console.WriteLine(" İsim: " + kisi.Name);
                    Console.WriteLine(" Soyisim: " + kisi.Surname);
                    Console.WriteLine(" Numara: " + kisi.Number);
                    Console.WriteLine("**********************");
                    Console.WriteLine("\n\n");
                }
                if (kisi.Name == searchable || kisi.Surname == searchable && temp==null)
                { 
                    temp = kisi;
                    break;
                }
            }
            return temp;
        }

        static List<Kisi> callNameAndNumber(List<Kisi> rehber,string searchable,bool choice)
        {
            List<Kisi> results = new List<Kisi>();
            foreach(Kisi kisi in rehber)
            {
                if (choice && kisi.Name == searchable || kisi.Surname == searchable) results.Add(kisi);      
                if (!choice && kisi.Number == searchable) results.Add(kisi);
            }
            return results;
        }
    }
}
