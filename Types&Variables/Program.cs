using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class program
    {
        static void Main(string[] args)
        {
            int number1 = 258976485;
            long number2 = -8255511321646152984;
            short number3 = 28596;
            byte number4 = 255; // just from 0 to 255 
            bool Condition = false;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 10;
            Console.WriteLine("Number1 is {0}" , number1); // 32 byte
            Console.WriteLine("Number2 is {0}" , number2); // 64 byte
            Console.WriteLine("Number3 is {0}" , number3); 
            Console.WriteLine("Number4 is {0}" , number4); 
            Console.WriteLine("Charcter is : {0}" ,(int) character);
            Console.WriteLine("Number5 is {0}", number5);
            //Console.WriteLine("Hello, World!");
            Console.WriteLine( Days.Friday);
            Console.ReadLine();
        }
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}
// Enum (msgic string)



