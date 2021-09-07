using System;

namespace Sizeof
{
    class Sizeof
    {
        public static void Main(String[] args)
        {
            //sizeOf()-
            // -used to obtain the size, in bytes of compile time known resources.
            // -reveals how many bytes of memory each type take up, in bytes.
            // -takes in a type and return in int.Equals.

            Console.WriteLine("Size of char:{0} ",sizeof(char));
            Console.WriteLine("Size of int:{0}",sizeof(int));
            Console.WriteLine("Size of float:{0}", sizeof(float));



        }
    }
}