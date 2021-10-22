using System;
namespace Exmpletion {
class NullCoal {
  public static void Main(System[] args) {
    //  Variable = left operand ?? right operand;
    // This checks if the left operand is null
    // If it is null it assigns the value to the right operand
    // If is not null it assigns the value to the left operand

    Object obj = null;
    Object obj1 = obj ?? new Object();
  }
}
}
