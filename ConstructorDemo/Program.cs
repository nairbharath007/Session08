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

            //Console.WriteLine(customer1.ShowCustomerDetails());
            //Console.WriteLine(customer2.ShowCustomerDetails());

            Employee employee1 = new Employee(1101, "Name3", "name3@gmail.com");
            Employee employee2 = new Employee(1102, "Name4", "name4@gmail.com");
            Employee employee3 = new Employee(1103, "Name5", "name5@gmail.com");

            Console.WriteLine("Total Customers: "+Customer.CountCustomers);
           // Console.WriteLine("Total Customers: " + Customer.Count());
            Console.WriteLine("Total Employees: " + Employee.CountEmployees);
            Console.WriteLine("Total Stakeholders: "+ Stakeholder.CountStakeholders);//5


        }
    }
}
