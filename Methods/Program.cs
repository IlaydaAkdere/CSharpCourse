﻿using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            Add();

            var result = Add2(20, 30);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);

            //Console.WriteLine(number1);
            Console.WriteLine(result2);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));
            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }
        public static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        public static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number , params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
