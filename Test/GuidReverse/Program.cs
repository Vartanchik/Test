using System;
using System.Linq;

namespace GuidReverse
{
    public class Program
    {
        private static Guid ReverseGuid(Guid guid)
        {
            var guidStringWithoutDashes = guid.ToString().Replace("-", string.Empty);

            // Решение
            //var reversedGuidString = guidStringWithoutDashes.Reverse();
            //return Guid.Parse(string.Join(string.Empty, reversedGuidString));

            // Мой вариант с учетом Колиных замечаний
            char[] charArray = guidStringWithoutDashes.ToCharArray();
            Array.Reverse(charArray);
            var guidReverseString = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                guidReverseString += charArray[i];
            }
            return Guid.Parse(guidReverseString);
        }

        public static void Main(string[] args)
        {
            var guid = Guid.NewGuid();
            
            Console.WriteLine(guid.ToString());
            Console.WriteLine(ReverseGuid(guid));

            Console.ReadLine();
        }
    }
}
