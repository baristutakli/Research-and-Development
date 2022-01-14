using ConsoleApp1.Extensions;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // How to use c# extension method
          
            string email= "asdfg@hotmail.com";
            string password="1234567gcyh89?AgE-";
            Console.WriteLine($"{email} is not NULL and not EMPTY: " + email.IsNotNullAndNotEmpty());
            Console.WriteLine($"{password} is not NULL and not EMPTY: " + password.IsNotNullAndNotEmpty());
            Console.WriteLine("IsLongEnough: " + password.IsLongEnough());
            Console.WriteLine("IsStrongEnough: " + password.IsStrongEnough());
        }
    }
}
