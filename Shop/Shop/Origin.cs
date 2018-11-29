using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Origin
    {
        public string company { get; set; }
        public string country{ get; set; }

        public Origin() { }

        public Origin(string company, string country) {
            this.company = company;
            this.country = country; 
        }
    }
}
