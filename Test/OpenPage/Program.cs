using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var listOfEntities = new List<string>
            {
                "fisrt",
                "second",
                "third",
                "fourth",
                "fifth",
                "sixth",
                "seventh"
            };
            const int numberOfElementsOnPage = 2;

            Console.WriteLine("Type number of page and press enter");
            var numberOfPage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Page {0}:", numberOfPage);
            for (int i = numberOfPage * numberOfElementsOnPage - numberOfElementsOnPage; i < numberOfPage * numberOfElementsOnPage; i++)
            {
                if (i < 0 || i >= listOfEntities.Count)
                    break;
                else
                    Console.WriteLine(">{0}", listOfEntities[i]);
            }
            Console.WriteLine("End of page");

            Console.ReadLine();
        }
    }
}
