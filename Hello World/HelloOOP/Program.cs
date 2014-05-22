
// todo: add comments to the following code, indentifying what parts are
// - fields
// - properties
// - constructors
// - methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    class Program
    {   // This is a method
        static void Main(string[] args)
        {
            // Declare two variables (object references)
            Greeter walmartEmployee, klingonWarrior;

            // Instantiate (create) the objects (giving values to the variables)
            walmartEmployee = new Greeter("Welcome to Walmart!",
                                          "Thank you for shopping at Walmart!!");
            klingonWarrior = new Greeter("nuqneH! yI'el!",
                                         "Qapla'!");

            // Use the objects 
            Console.WriteLine("The Walmart Employee sample:"); // write line in the program (tells users what the employee is going to say)
            Speak(walmartEmployee, "Dan"); // function within the program

            Console.WriteLine("The Klingon Warrior sample:"); // write line in the program (tells users what the klingon is going to say)
            Speak(klingonWarrior, "Worf"); // function within the program
        }

        static void Speak(Greeter someone, string name) // method with variable parameters
        {
            Console.WriteLine(someone.SayGreeting(name)); // output text for the method
            Console.WriteLine(someone.SayGoodbye()); // more output text for the method
            Console.WriteLine(); // blank line
        }
    }
}
