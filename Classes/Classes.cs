using System;

namespace Classes {
// Classes

// With basic data types such as int, string , float, double which are best in
// performing bacis operation. Real world is a little more complex than just
// basic operations. Classes are best for representing complex things like in
// real life situations

// i.e There is no way to represent an animal with int or float or double.
//  Here is where Classes comes to the rescue
// A class is like a blue-print i.e it defines all the attribute and properties
// it should have

// We can have a class Animal
// We can give it some attribues like, Move, Legs etc.

// Or we can have a class House and give it some properties like Size, Color,
// Shape, etc.

// let us look at defining our own class
//
public class Animal {
  public string Name { get; set; }
  public string Move { get; set; }
  public int NumberOfLegs { get; set; }
  public string Color { get; set; }

  // Make sound is a method
  public string MakeSound(string sound) { return sound; }
}
class Classes {
  public static void Main(String[] args) {
    // instantiating a new instance of an Animal with the name animal1
    var animal1 = new Animal();

    animal1.Name = "Dog";
    animal1.Move = "Run and Walk and Jump";
    animal1.NumberOfLegs = 4;
    animal1.Color = "white";
    animal1.MakeSound("Bark!!!");

    var animal2 = new Animal { Name = "Snake", Move = "Glide", NumberOfLegs = 0,
                               Color = "Black", MakeSound("Hiss!!!") };

    // animal1 and animal2 are different instance of Animal or called object
    // animal1 and animal2 are called object

    // Classes are used to solve for more complex scenerios
  }
}

}
