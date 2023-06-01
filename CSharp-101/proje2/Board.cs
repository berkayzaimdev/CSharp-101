using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.proje2
{
    class Board
    {
        public List<Line> lines = new List<Line>();

        public void Print() 
        {
            foreach(Line line in lines)
            {
                Console.WriteLine(line.displayname+" Line");
                Console.WriteLine("********************");
                if (line.cardlist.Count == 0) Console.WriteLine(" - BOŞ - ");
                else 
                {
                    foreach (Card card in line.cardlist)
                    {
                        Console.WriteLine("Başlık: {0}",card.header);
                        Console.WriteLine("İçerik: {0}", card.inside);
                        Console.WriteLine("Atanan kişi: {0}", card.person.name);
                        Console.WriteLine("Büyüklük: {0}", card.boyut);
                    }
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
