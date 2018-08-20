using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPage
{
    public class ClassModel
    {
        public string Name { get; set; }
        public string Article { get; set; }
        public double Price { get; set; }

        public ClassModel(string name, string article, double price)
        {
            Name = name;
            Article = article;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " " + Article + " " + Price;
        }
    }
}
