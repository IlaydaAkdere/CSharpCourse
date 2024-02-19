using System;
using System.Threading.Tasks;
using System.Linq;


namespace Inheritance
{
    class program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                //new Customer(), new Student()

                new Customer
                {
                    name =" ılayda"
                },
                new Student
                {
                    name = "ayse"
                },
                new Person
                {
                    name  ="beyhan"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(perosn.name);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

    }
    class Customer : Person
    {
    
        public string city { get; set; }
        public string departmant { get; set; }
    
    }

}