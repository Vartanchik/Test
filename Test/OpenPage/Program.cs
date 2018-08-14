using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPage
{
    public class Program
    {
        // сначала думал перенести инициализацию списка в этот метод,
        // но потом подумал, что ему здесь не место
        // или все таки он здесь должен быть?
        private static void PageOpening(List<string> listOfEntities, int numberOfPage)
        {
            const int numberOfElementsOnPage = 2;
            var indexOfFirstElement = numberOfPage * numberOfElementsOnPage - numberOfElementsOnPage;
            var indexOfLastElement = numberOfPage * numberOfElementsOnPage;

            Console.WriteLine($"Page {numberOfPage}:");
            for (int i = indexOfFirstElement; i < indexOfLastElement; i++)
            {
                if (i < 0 || i >= listOfEntities.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($">{listOfEntities[i]}");
                }
            }
            Console.WriteLine("End of page");

        }

        public static void Main(string[] args)
        {
            var listOfEntities = new List<string>
            {
                "first",
                "second",
                "third",
                "fourth",
                "fifth",
                "sixth",
                "seventh"
            };
            string stringFromUser;
            Console.WriteLine("Type number of page and press enter or type \"exit\" to close application");
            do
            {
                stringFromUser = Console.ReadLine();
                //int numberOfPage;  // правильно будет если эту переменную задам сразу в TryParse?
                if (Int32.TryParse(stringFromUser, out int numberOfPage) && numberOfPage > 0)
                {
                    numberOfPage = Convert.ToInt32(stringFromUser);
                    PageOpening(listOfEntities, numberOfPage);
                }
                else if (stringFromUser == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered incorrect value. Try again");
                }

                Console.WriteLine();
            } while (stringFromUser != "exit");
        }
    }
}
