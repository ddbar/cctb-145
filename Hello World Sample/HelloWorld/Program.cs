using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Tell me your name:");
            
            // write line is a static method
            // create some local variables

            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            int five = 5;
            int seven = 7;

            //initialization statements
            
            int total;
            
            // variable declaration statement

            total = five + seven;
            Console.WriteLine("Five + Seven is " + total);


            double price = 10.95;
            int quantity = 3;

            double totalPrice;
            totalPrice = price * quantity;

            // assignment statement

            Console.Write(price);
            Console.Write(" times");
            Console.Write(quantity);
            Console.Write(" equals ");
            Console.WriteLine(totalPrice);
            Console.WriteLine("Computers do math...");

        }
    }
}
