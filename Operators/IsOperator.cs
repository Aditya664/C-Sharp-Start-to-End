using System;

namespace IsOperator
{
    public class Ex1{

    }
    public class Ex2 : Ex1{}
    class IsOperator
    {
        // IsOperator 
        // -used to check if a value is of a certain type
        // -Helps us avoid an invalidCastException
        // -Lets us know if a value is of a certain type


        public static void Main(String[] args)
        {
            // bool b = "abc" is String;
            // Console.WriteLine(b);

            Ex2 ex2Object = new Ex2();
            bool b = ex2Object is Ex1;
            Console.WriteLine(b);
        }
    }
}