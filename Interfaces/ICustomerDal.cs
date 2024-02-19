using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
     interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Sql Added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Sql Updated");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Sql Deleted");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Oracle Added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Oracle Updated");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }
    class CustomerManager
    {
        public void Add(OracleCustomerDal oracleCustomerDal)
        {
            Console.WriteLine(ICustomerDal customerDal){
                CustomerDal.Add();
            }
        }
    }
}
