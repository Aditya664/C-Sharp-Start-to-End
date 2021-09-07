using System;

namespace System
{
    class TernaryOpr
    {
        //Conditional opertor
        public static void Main(String[] args)
        {
            int x;
            int value;
            bool isGreater = x > value ? true : false;
            if(x > value)
            {
                isGreater = true;
            }
            else
            {
                isGreater = false;
            }
        }
    }
}