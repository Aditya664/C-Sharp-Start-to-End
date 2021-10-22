using System;
using System.Collections.Generic;
using Linq;

namespace Linq
{
//LINQ stands for Language-Integrated Query
//That is a language for making query.
//The importance of LINQ cannot be over empahsized
//To use LINQ we have to import the Linq namespace
//Imagining have a long list of data lets say a million record
//You need just one record from the million record
//Running a loop over a million record will take a lot of time and resources that can be better utilized
//LINQ makes it easy to easily get the record you want
//There are two syntax of writing LINQ
//Query Syntax - which looks more or less like a SQL query language
//Method Syntax - which looks like C# syntax

class Linq
{
    public static void Main(String[] args)
    {
        //we have some list of students
        //To get an student that meets a certain criteria using a loop we will have loop over all the list of student
        // coupled with an if-statement to check if it meets our criteria
        // To get the teenager student using query syntaxt .
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13},
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20},
            new Student() {
                StudentID = 5, StudentName = "Ron", Age = 15
            }
        };
        //Let us do this with LINQ


        //Query Syntax
        //Query Syntax is more like a SQL query
        //Teenager are between the ages of 12 to 20;

        var querySyntax = from s in studentList
                          where s.Age > 12 And s.Age < 20 _
                          Select s).ToList();


        //Method Syntax
        //Method Syntax is more like C# syntax
        //Teenager are between the ages of 12 to 20;

        var methodSyntax = studentList.where(x => x.Age > 12 && x.Age < 20).ToList();
        //Sweet and concise

        //The Query syntax and the method syntax returns the same value. it is a matter of prefrences

        //The possibilities are endless with linq
        //With LINQ it makes it easier to query a database right from your Code.

    }

}
}