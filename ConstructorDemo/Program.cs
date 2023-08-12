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
            /*Customer customer1 = new Customer();
            Console.WriteLine(customer1.ShowCustomerDetails());
            customer1.Name = "YourName";
            Console.WriteLine(customer1.ShowCustomerDetails());

            Customer customer2 = new Customer(101,"DifferentName");
            Console.WriteLine(customer2.ShowCustomerDetails());
*/
            Customer customer3 = new Customer(103, "Name3", "name3@gmail.com");
            Console.WriteLine(customer3.ShowCustomerDetails());

        }
    }
}
