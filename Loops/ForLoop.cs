using System;
using System.Collections.Generic;

namespace ForLoops
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
    class ForLoops
    {
        public static void Main(String[] args)
        {
            List<String> collection = new List<String>() { "a", "b", "c"};

                // for (statement 1; statement 2; statement 3) 
                // {
                // // code block to be executed
                // }

                
            for(int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);

            }
        }

    }
}