using ConstructorDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(101, "Name1", "name1@yahoo.com");
            Customer customer2 = new Customer(102, "Name2", "name2@gmail.com");

            Console.WriteLine(customer1.ShowCustomerDetails());
            Console.WriteLine(customer2.ShowCustomerDetails());

            Console.WriteLine("Total Customers: "+Customer.CountCustomers);
            Console.WriteLine("Total Customers: " + Customer.Count());


        }
    }
}
