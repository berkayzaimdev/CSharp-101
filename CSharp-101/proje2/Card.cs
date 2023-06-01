using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.proje2
{
    class Card
    {
        public enum boyutlar
        {
            XS = 1,
            S,
            M,
            L,
            XL
        };
        public string header, inside;
        public Person person;
        public boyutlar boyut;


        public Card(string header,string inside,Person person,int boyut)
        {
            this.header = header;
            this.inside = inside;
            this.person = person;
            this.boyut = (boyutlar) boyut;
        }
    }
}
