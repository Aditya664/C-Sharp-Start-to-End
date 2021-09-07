using System;

namespace Typeof
{
    class Typeof
    {
        public static void Main(String[] args)
        {
            //Typeof operator
            //-not really used in everday programming;
            //-Reveals what is going on under the hood;
            //-alllows us to get a type at compile time;
            Console.WriteLine("Type of char:{0}", typeof(char));
            Console.WriteLine("Type of int:{0}", typeof(int));
            Console.WriteLine("Type of float:{0}", typeof(float));

        }
    }
}