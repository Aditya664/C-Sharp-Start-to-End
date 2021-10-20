using System;
using System.Collections.Generic;

namespace ForEachLoop {
// LOOPS:-
// -A loop Execute a piece of code repeatedly until a condition is fulfilled.
// -Many of the programs that you write will involve loops.
// -Only write the code once but run it over and over.
// -Two main type of loops:-
//     1.for
//     2.while
// -A for loop itertes over elements umtil the specified length is reached.
// -A While loop executes until a specified condition is met;

// Another type of loop is the for each loop
// it iterates over an array or list

class ForEachLoop {
  public static void Main(String[] args) {
    List<String> collection = new List<String>() { "a", "b", "c" };

    // for (var item in  collection)
    // {
    // // code block to be executed
    // }

    for (var item in collection) {
      Console.WriteLine(item);
    }
  }
}
}
