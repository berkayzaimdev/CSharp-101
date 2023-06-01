using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.proje1
{
    class Kisi
    {
        private string name, surname, number;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname 
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Number 
        {
            get { return number; }
            set { number = value; }
        }

        public Kisi(string name,string surname,string number)
        {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }
    }
}
