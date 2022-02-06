using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // MyDelegate del = new MyDelegate(MethodA);
            // MyDelegate del = MethodA;
            //  MyDelegate del = (string msg) => Console.WriteLine(msg);
            //  del("asdasdas");


            //Calculator myCalculator = new Calculator();
            ////ThisDelegateReturnInteger addition= myCalculator.Addition;
            //ThisDelegateReturnInteger addition = myCalculator.Addition;
            //ThisDelegateReturnInteger substraction = myCalculator.Substraction;
            //ThisDelegateReturnInteger thisDelegateReturnInteger = addition + substraction;
            //Console.WriteLine(thisDelegateReturnInteger(5,10));
            ////Console.WriteLine(addition(5,6));


            // ThisDelegateAddTwoNumber additionDelegate = Addition;
            //additionDelegate(9, 9);
            //  additionDelegate.Invoke(5, 5);

            //string ConcatTwoStrings = ThisMethodReturnsAString("Hello");
            //ConcatTwoStrings =  ThisMethodAlsoReturnsAString("World");
            //Console.WriteLine(ConcatTwoStrings);

           // ThisIsADelegate firstDelegate = ThisMethodReturnsAString;
          //  ThisIsADelegate secondDelegate = ThisMethodAlsoReturnsAString;

            //string concatTwoStringsUsingDelegate = firstDelegate("Hello") + " " + secondDelegate("World");
            //Console.WriteLine(concatTwoStringsUsingDelegate);

            //ThisIsADelegate concatenatingDelegate = firstDelegate;
          //  concatenatingDelegate += secondDelegate;


        //    Console.WriteLine(firstDelegate("1- Hello"));
         //   Console.WriteLine(secondDelegate("2- Hello"));
        //  Console.WriteLine(concatenatingDelegate.Invoke("Hello"));
            //  Console.WriteLine(firstDelegate("1- Hello")+ " "+ secondDelegate("2- Hello"));


            /////// Func////////////
            //Func<string,string> firstDelegate = ThisMethodReturnsAString;// set a target
            //Func<string, string> secondDelegate = ThisMethodAlsoReturnsAString;
            //firstDelegate += ThisMethodAlsoReturnsAString;
            //Console.WriteLine(secondDelegate("Hello"));
            //Console.WriteLine(firstDelegate("Hello"));

            //Func<string, string> firstDelegate = ThisMethodReturnsAString;// set a target
            //Console.WriteLine(firstDelegate("Hello"));
            //firstDelegate += ThisMethodAlsoReturnsAString;

            //Console.WriteLine(firstDelegate("Hello"));

            List<string> myList = new List<string> { "ada", "asda", "6455", "aaaa" };
            myList.RemoveAll(p => p.Length < 4);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

        }


        public delegate void ThisDelegateAddTwoNumber(int firstNumber, int secondNumber);
        public delegate void ThisDelegateCalculateSquareOfANumber(int secondNumber);
        public delegate string ThisIsADelegate(string message);
        // set target method
        
        
        
        // target method
        static void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber}: {firstNumber + secondNumber}");
        }
        public static string ThisMethodReturnsAString(string message)
        {
            //Console.WriteLine($"FirstMethod: {message}");
            return message+=" 1";
        }
        static string ThisMethodAlsoReturnsAString(string message)
        {
            //Console.WriteLine($"SecondMethod: {message}");
            return message+"2";
        }
    }
}


