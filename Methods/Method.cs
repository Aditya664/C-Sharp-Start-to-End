using System;

namespace Methods
{
    //Methods are set set of instructions that complete a task.
    //Before a method can be used it has to be declared
    // The set of instructions that the method performs are written in the method block
    //Methods accepts parameter as input

    class Methods
    {
       //Methods can be used by calling the name of the method

       SayHello();

       string sayMyNameResult = sayMyNameResult("kaybee");

       int AdditionResult = Addition(5, 9);
    }

    //Method declaration


    //The void keyword means that this method doesn't return a value.
        //This method does not accept an input
        public void SayHello()
        {
            Console.WriteLine("Hello World")
        }

        //The return type of the function is string
        // This method accepts a parameter name 
        public string SayMyName(string name)
        {
            return $"My name is {name}";
        }

        //The return type of the function is int
        //The method accepts a parameter int num1 and num2

        public int Addition(int num1 , int num2)
        {
            return num1 + num2;
        }
}