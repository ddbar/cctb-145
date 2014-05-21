using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programflow1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Todo: write the code that will run the samples...
            Program myApp = new Program(); // create an object based on this class
            myApp.IfStatementSample(); // call (i.e.: execute) the method

            Console.WriteLine("Goodbye.");

        }  // end of the main() method

        public void IfStatementSample()
    {
        Console.WriteLine("If Statement Sample...");
        Console.Write("Enter your age:" );
        string stringAge = Console.ReadLine(); // get the text the user types in
        int age = int.Parse(stringAge); // convert the typed number to an integer

        if (age >= 18)
    {
        Console.WriteLine("You are an adult.");
            
    }
    
         else
    
    {
        Console.WriteLine("You are not an adult.");
    }
            

    } // end of the IfStatementSample() Method


    } // end of the program class
} // end of the namespace for this file's code
