using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.proje2
{
    class Line
    {
        public string displayname { get; set; }
        public List<Card> cardlist { get; set; }

  
        public Line(string displayname, List<Card> cardlist)
        {
            this.displayname = displayname;
            this.cardlist = cardlist;
        }
    }
}
