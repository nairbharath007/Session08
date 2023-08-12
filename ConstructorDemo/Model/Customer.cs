using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo.Model
{
    internal class Customer
    {
        private readonly int _id;
        private string _name;
        private readonly string _email;
        public int Id
        {
            get { return _id;  }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
           
        }

        public Customer() //default
        {
            /*_id = 101;
            _name = "InitialName";*/

            Console.WriteLine("===========Object created===========");
        }
        public Customer(int id, string name) : this()
        {
            _id = id;
            _name = name;
            
        }

        public Customer(int id, string name, string email) : this(id, name)
        {
            /*_id = id;
            _name = name;*/
            _email = "name5@gmail.com";
        }

        public string ShowCustomerDetails()
        {
            return $"Id: {Id}\nName: {Name}\nEmail : {Email}";
        }   
    }
}
