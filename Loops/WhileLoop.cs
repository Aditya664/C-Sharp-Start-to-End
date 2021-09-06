using System;
using System.Collections.Generic;

namespace WhileLoop
{
    // LOOPS:-
    // -A loop Execute a piece of code repeatedly until a condition is fulfilled.
    // -Many of the programs that you write will involve loops.
    // -Only write the code once but run it over and over.
    // -Two main type of loops:-
    //     1.for
    //     2.while
    // -A for loop itertes over elements umtil the specified length is reached.
    // -A While loop executes until a specified condition is met;

    class WhileLoop 
    {
        public static void Main(String[] args)
        {
            // while (condition) 
            // {
            // // code block to be executed
            // }

                int i = 3;
                while (i > 0)
                {
                    Console.WriteLine("Loading");
                    i--;
                }
        }
    }
}