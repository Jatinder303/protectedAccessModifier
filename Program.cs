//In the code given below, the class Y inherits from X, therefore, any protected members of X can be accessed from Y but the values cannot be modified.
// C# Program to show the use of  
// protected Access Modifier 
using System;

namespace protectedAccessModifier
{
    static class Program
    {
        static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();

            // Displaying the value of x 
            Console.WriteLine("Value of x is : {0}", obj2.getX());
        }
    }
}
