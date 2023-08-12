using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails();
            PrintDetails(5);
            PrintDetails(5, 6);
            PrintDetails("hi");
            PrintDetails("hi",5);
            PrintDetails(5, "hi");

        }
        static void PrintDetails()
        {
            Console.WriteLine("hilo");
        }
        static void PrintDetails(int n)
        {
            Console.WriteLine(n);
        }
        //cannot have same function signature but different return types
        /*static int PrintDetails(int n)
        {
            Console.WriteLine(n);
        }*/
        
        static void PrintDetails(int n1, int n2)
        {
            Console.WriteLine($"{n1} {n2}");
        }
        static void PrintDetails(string s)
        {
            Console.WriteLine(s);
        }
        static void PrintDetails(int n, string s)
        {
            Console.WriteLine($"{n} {s}");
        }

        static void PrintDetails(string s, int n)
        {
            Console.WriteLine($"{s} {n}");
        }
    }
}

