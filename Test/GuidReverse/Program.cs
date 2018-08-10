using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidReverse
{
    class Program
    {
        public static Guid ReverseGuid(Guid guid)
        {
            string string1 = guid.ToString().Replace("-", "");
            char[] charArray = string1.ToCharArray();
            Array.Reverse(charArray);
            string string2 = "";
            for (int i = 0; i < 32; i++)
            {
                string2 += charArray[i];
            }
            return Guid.Parse(string2);
        }

        static void Main(string[] args)
        {
            Guid myGuid = new Guid();
            myGuid = Guid.NewGuid();
            
            Console.WriteLine(myGuid.ToString());
            Console.WriteLine(ReverseGuid(myGuid));

        }
    }
}
