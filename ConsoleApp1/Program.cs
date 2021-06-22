using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "water";
            List<string> strings = new List<string>();
            int count = myString.Length;
            int middle = 0;
            int realMiddle = 0;
            if (myString.Length % 2 == 0)
            {
                strings.Add(myString.Substring((myString.Length / 2) - 1, 2));
            }
            else
            {
                //strings.Add(myString[myString.Length / 2].ToString());
                middle = myString.Length / 2;
                realMiddle = middle;
            }
            for (int i = 0; i < count; i++)
            {
                if (middle > 0)
                {
                    if (middle < myString.Length)
                    {
                        strings.Add($"{myString[middle > myString.Length ? middle - 1 : middle]}");
                        middle++;
                        i = 0;
                    }
                    else
                    {
                        if (i <= realMiddle)
                            strings.Add(myString[i - 1].ToString());
                    }
                }
                else
                {

                }
            }
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
