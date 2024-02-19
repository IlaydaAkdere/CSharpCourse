using Classes;
using System;
using System.Threading.Tasks;

namespace classes
{
    class program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customwer  = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ilayda";
            customer.SurName = "Yönel";
            customer.City = "Istanbul";


            // ikinci yol kulllanım için

            Customer customer2 = new Customer
            {
                Id = 2 , City = "Istanbul" , FirstName = "Ilayda" , SurName = "Yönel"

            };

        Console.WriteLine(customer2.FirstName);

        Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!!");
            //Console.ReadLine();
        }
    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated!!");
            //Console.ReadLine();
        }
    }

}
