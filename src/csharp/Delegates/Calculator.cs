using System;

namespace Delegates
{
    public class Calculator
    {
      
        
        public void Addition(int firstNumber,int secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber}: {firstNumber + secondNumber}");
        }

        public int Substraction(int firstNumber, int secondNumber)
        {
            Console.WriteLine("sub");
            return firstNumber + secondNumber;
        }

        public int Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Division(int firstNumber, int secondNumber)
        {
            return secondNumber != 0 ? firstNumber / secondNumber : throw new InvalidOperationException("Zero division!!!");
        }

    }
}



