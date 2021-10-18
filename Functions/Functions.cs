using System;

namespace Functions
{
    class Functions
    {
        // What is a Function?
        // -Function,or methods, are blocks of code that can be reused throughout our program.
        // -they make it easy to reuse code without typing it over and over.
        // -We can make a change in the Function body and not have to change it everywhere the function is called.
        // -Save the time and make our code more readable and manageable.

        public static void Main(String[] args)
        {
            PrintHi("Hello World!");
        }
        //This is the function
        static void PrintHi(string message)
        {
            Console.WriteLine(message);
        }

    }
}