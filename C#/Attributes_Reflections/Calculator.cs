namespace Attributes_Reflections
{
    using System;

    public class Calculator
    {
        public string ThisIsAField = "I'm a field";
        public int ThisIsAProperty { get; set; }
        public Calculator()
        {
            Console.WriteLine("I'm a calculator");
        }

        public int Square(int number) =>  number*number;
        public int Cube(int number) => number * number * number;
        public void Print() => Console.WriteLine("What are you doing?");

    }
}
