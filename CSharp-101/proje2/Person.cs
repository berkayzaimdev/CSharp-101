using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.proje2
{
    public class Person
    {
        public string name;
        public int id=1;
        public static int c=1;
        public static List<Person> allpersons = new List<Person>();

        public Person(string name)
        {
            this.name = name;
            this.id = c;
            c++;
        }

        public static Person FetchByID(int id)
        { 
            foreach(Person person in allpersons)
            {
                if(person.id==id)
                    return person;
            }
            return null;
        }
    }
}
