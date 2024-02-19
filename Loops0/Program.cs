using System.Text;
using System.Threading.Tasks;

namespace Loops0
{
    class program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100 ; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // ForLoop();
            ForeachLoop();

            Console.ReadLine();

            //WhileLoop();
            //Console.ReadLine();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is a not prime number");
            }
            Console.ReadLine();

        }

        private static bool IsPrimeNumber(int number) 
        { 
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }
            return result;
            i = number;
        }



        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Ilayda", "Samet", "Osman" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        //private static void WhileLoop()
        //{
        //    DOwHILEloop();
        //}

        //private static void DOwHILEloop()
        //{
        //    int number = 100;
        //    while (number >= 0)
        //    {
        //        Console.WriteLine(number);
        //        number--;
        //    }
        //    Console.WriteLine("Now Number is {0}", number);
        //}

        private static void ForLoop()
        {
            //for (int i = 100; i > 0; i = i - 2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("FINISHED!!");
            //Console.ReadLine();
        }



    }
}

// while durdurulmaz azaltılmaz ya da arttırılmazsa sonsuz döngüye girer.