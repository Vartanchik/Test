using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPage
{
    public class Program
    {
        private static List<string> PageFormation(List<string> listOfEntities, int numberOfPage)
        {
            var listOfEntitiesOnCurrentPage = new List<string>();
            const int numberOfElementsOnPage = 2;
            var indexOfFirstElement = numberOfPage * numberOfElementsOnPage - numberOfElementsOnPage;
            var indexOfLastElement = numberOfPage * numberOfElementsOnPage;

            for (int i = indexOfFirstElement; i < indexOfLastElement; i++)
            {
                if (i < 0 || i >= listOfEntities.Count)
                {
                    break;
                }
                else
                {
                    listOfEntitiesOnCurrentPage.Add(listOfEntities[i]);
                }
            }
            return listOfEntitiesOnCurrentPage;
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

                    Console.WriteLine($"Page {numberOfPage}:");
                    var listOfEntitiesOnCurrentPage =  PageFormation(listOfEntities, numberOfPage);
                    for (int i = 0; i < listOfEntitiesOnCurrentPage.Count; i++)
                    {
                        Console.WriteLine($">{listOfEntitiesOnCurrentPage[i]}");
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
