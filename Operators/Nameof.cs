using System;

namespace Nameof
{
class Nameof
{
    // nameof expression allows you to get the name of a variable, type or a function
    // in a form of a string constant

    private static void Main(string[] args)
    {
        Console.WriteLine(nameof(Main));
        Console.WriteLine(nameof(args));
        Console.WriteLine(nameof(Nameof));
    }
}
}
