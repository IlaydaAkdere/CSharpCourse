using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "ilayda";
            students[1] = "samet";
            students[2] = "berat";

            string[] students2 = { "ilayda", "samet", "berat" };

            foreach (var student in students2)
            {
                Console.WriteLine(students);
            }
            string[,] regions = new string[5, 3]
            {
                {"ist","izmit","balıkesir" },
                {"ank","kon","krk" },
                {"ant","adn","mersin" },
                {"rize","samsun","trabzon" },
                {"izmir","mugla","manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("****************");
            }

            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}