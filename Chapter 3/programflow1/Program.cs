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
            myApp.WhileStatementSamples();
            myApp.ForStatementSample();
            myApp.ListDivisibleBy(3);
            myApp.EnumSample(color.Green); // pass in a liteal value from my enum
            
            int someNumber;
            Console.Write("Enter a small number between 2 and 20: ");
            someNumber = int.Parse(Console.ReadLine());
            myApp.ListDivisibleBy(someNumber);

            Console.WriteLine("Goodbye.");
            Console.WriteLine("Press [enter] to exit.");
            Console.ReadLine();

        }

        private void ListDivisibleBy(int divisor)
        
        {
            Console.WriteLine("List all the numbers from 1 to 100 that are divisible by " + divisor);
            for (int counter = 1; counter <= 100; counter++)
            {
                if (counter % divisor == 0)
                
                {
                    Console.Write(counter);
                    Console.Write(", ");
                
                }

                Console.WriteLine(); // write a line-feed
            
            } // end of ListDivisibleBy() method
        }
 
        private void EnumSample(color favoriteColor)
        {
            Console.WriteLine("Sample Enumeration...");
            
                switch(favoriteColor)
                {
                    case color.Red:
                        Console.WriteLine("Your color is red.");
                        break;

                    case color.Blue:
                        Console.WriteLine("Your color is blue.");
                        break;

                    case color.Green:
                        Console.WriteLine("Your color is green.");
                        break;
                    default:
                        Console.WriteLine("You entered a different color:");
                        Console.WriteLine(favoriteColor);
                        break;

                }

        
        }

        private void ForStatementSample()
        {
            Console.WriteLine("For Sample..");
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(counter);
            
            }

        }


        private void WhileStatementSamples()
      
        {
            Console.WriteLine("While and Do-While Samples...");

            int counter = 10;

            while(counter > 0)
            
            {   // we only enter the loop if the above condition is true

                Console.WriteLine(counter);
                counter = counter - 1;
                            
            }

            int age;
            do
            
            {
                Console.WriteLine("Enter your age once more:");
                age = int.Parse(Console.ReadLine());


            } while (age < 1 || age > 100);

            string message;

            message = String.Format("You are {0} years old!", age);
            Console.WriteLine(message);



        }  // end of the WhileStatementSamples() method
        
        // end of the main() method

        public void IfStatementSample()
    {
        Console.WriteLine("If Statement Sample...");
        Console.Write("Enter your age:" );
        string stringAge = Console.ReadLine(); // get the text the user types in
        int age = int.Parse(stringAge); // convert the typed number to an integer


        if (age >= 65)
        
        {
            Console.WriteLine("You are a senior.");
        
        }

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
