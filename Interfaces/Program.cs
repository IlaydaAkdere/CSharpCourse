using Classes;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class program
    {
        //public static int Id { get; private set; }
        //public static string FirstName { get; private set; }
        //public static string LastName { get; private set; }
        //public static string Address { get; private set; }

        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo2();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();

        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //manager.Add(new Customer{ Id = 1, FirstName = "Ilayda", LastName = "Yönel", Address = "Istanbul" }); //farklı yolla kullanımı
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ilayda",
                LastName = "Yönel",
                Address = "Istanbul"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Samet",
                LastName = "Yönel",
                Departmant = "Computer Engineering"
            };
            //manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; }
            int FirstName { get; }
            int LastName { get; }
        }
        class Customer : IPerson
        {
            public int Id { get; }
            public string FirstName { get; }
            public string LastName { get; }
            public string Address { get; }
        }
        //int IPerson.Id => throw new NotImplementedException();

        //int IPerson.FirstName => throw new NotImplementedException();

        //int IPerson.LastName => throw new NotImplementedException();

        class Student : IPerson
        {
            //int IPerson.Id => throw new NotImplementedException();

            //int IPerson.FirstName => throw new NotImplementedException();

            //int IPerson.LastName => throw new NotImplementedException();
            public int Id { get; }
            public string FirstName { get; }
            public string LastName { get; }
            public string Departmant { get; }

        }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(.FirstName);
        }
    }
}

// IPerson olarak ekledikelrimiz personda olnların hepsını orada da göreceğiz demektir.


