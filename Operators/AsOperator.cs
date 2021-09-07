using System;

namespace AsOperator
{

    class AsOperato
    {
        // As operator
        // -Sometimes we are going to want to cast a variable of one type to another type.
        // -The as operator helps us to avoid an invalid cast exception when
        // -If the cast is valid, the as operator will return the object cast to the new type.
        public static void Main(System[] args)
        {
            string s1 = "abc";
            object obj1v= s1;
            string s2 = obj1v as string;
        }
    }
}