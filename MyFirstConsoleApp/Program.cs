using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What value do you want?");
            var input = Console.ReadLine();

            int? x= 34; // integer data type

            bool y = true; // boolean data type

            DateTime z = new DateTime(2019, 7, 12);

            string s = "asdf";

            double f = 12.34;

            object o = new { MyProperty = 1234 };

            var sam = new object[] { 1, 2, 3, 4, "asdf" }; // this is a comment

            var myList = new List<int> { 1, 1, 1, 1, 1 };
            myList.Remove(1);

            // if else if and else statement
            if (x == 0)
            {
                Console.WriteLine("yep, it's zero.");
            }
            else if (x == 1)
            {
                Console.WriteLine("yep, it's uno.");
            }
            else
            {
                Console.WriteLine("Nope!");
            }

            // switch statement
            switch (x)
            {
                case 0:
                    Console.WriteLine("yep, its zero");
                    break;
                case 1:
                    Console.WriteLine("yep, it's one");
                    break;
                case 2:
                    Console.WriteLine("yep, it's two");
                    break;
                default:
                    Console.WriteLine("Yep, it's one of those things");
                    break;
            }

            // ternary (bad example, but ternary nonetheless)
            var myNumberIsOne = x == 1 ? true : false;

            // for each
            foreach(var currentNumber in myList) // for each integer in my list, do this
            {
                Console.WriteLine($"current number was {currentNumber}. one of those things."); // with string interpolation
            }
            
            try
            {
                myList = null;
                myList.ToString();
            }
            catch (Exception e) // Catch any exception, and put it in a variable called e
            {
                Console.WriteLine(e); // And now we write e to the console
                throw; // And then throw it out
            }

        }
    }
}
