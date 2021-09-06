using System;

namespace IfElse 
{
    // C# has the following conditional statements:

    // Use if to specify a block of code to be executed, if a specified condition is true
    // Use else to specify a block of code to be executed, if the same condition is false
    // Use else if to specify a new condition to test, if the first condition is false
    // Use switch to specify many alternative blocks of code to be executed

    class IfElse
    {
        public static void Main(string[] args)
        {
            // SYNTAX
            // if (condition) 
            // {
            // // block of code to be executed if the condition is True
            // }

        int x = 20;
        int y = 180;
        if (x > y) 
        {
        Console.WriteLine("x is greater than y");
        }else
        {
            Console.WriteLine("x is smaller than y");
        }
        }
    }
}