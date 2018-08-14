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
                "first",
                "second",
                "third",
                "fourth",
                "fifth",
                "sixth",
                "seventh"
            };
            const int numberOfElementsOnPage = 2;
            string stringFromUser;
            int numberOfPage;

            Console.WriteLine("Type number of page and press enter or type \"exit\" to close application");
            do
            {
                stringFromUser = Console.ReadLine();
                if (Int32.TryParse(stringFromUser, out numberOfPage) && Convert.ToInt32(stringFromUser) >= 0)
                {
                    numberOfPage = Convert.ToInt32(stringFromUser);
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
