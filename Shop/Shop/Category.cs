using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Category
    {
        public string categoryName { get; set; }

        public Category() { }

        public Category(string category)
        {
            this.categoryName = category;
        }
    }
}
