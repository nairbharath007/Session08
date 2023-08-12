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
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        //static variable
        private static int _countCustomers = 0;

        //static properties
        public static int CountCustomers
        {
            get { return _countCustomers; }
        }

        //static constructor
        static Customer()
        {
            Console.WriteLine("Static Constructor");
        }

        public Customer()
        {
            Console.WriteLine("Default Constructor");
            _countCustomers++;
        }

        public Customer(int id, string name, string email) : this()
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public string ShowCustomerDetails()
        {
            return $"Id: {Id}\nName: {Name}\nEmail : {Email}";
        }   

        //static method
        public static int Count()
        { return _countCustomers; }
    }
}
