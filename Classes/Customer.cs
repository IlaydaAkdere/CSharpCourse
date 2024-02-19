using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // musterı bılgılerı tutacagımız alan
    public class Customer
    {
        //property
        public int Id { get; set; }

        //ENCAPSULATION

        private string _Firstname;
        public string FirstName 
        {
            get
            {
                return "Mr." + FirstName; // ismin basına mr ekledik 
            }
            set
            {
                _Firstname = value;
            }
        }
        public string SurName { get; set; }
        public string City { get; set; }
        //public int Id { get; set; }
    }
}
