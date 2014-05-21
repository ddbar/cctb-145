using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesValuesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Order of operations - arithmetic operators..
            
            double result = 30.5;
            Console.WriteLine(result);

            double otherresult = (7 / 2 + 9) * 2.5;
            Console.WriteLine(otherresult);

            // Variables of various data types, with values

            Console.WriteLine("The result of the math is " + result);

            // casting

            char singleDigit = '5';
            int simpleNumber = 25;

            // the result of casting

            Console.WriteLine("Casting '5' ...");
            Console.WriteLine((int)singleDigit);

            Console.WriteLine("Casting 25 ...");
            Console.WriteLine((double)simpleNumber);

            // the result of converting...

            Console.WriteLine("Converting '5' ...");
            Console.WriteLine(Convert.ToInt32(singleDigit));
            Console.WriteLine("Converting 25 ...");
            Console.WriteLine(Convert.ToDouble(simpleNumber));
            // "alternate" way of converting using the Parse method
            Console.WriteLine("Converting '5' using int.Parse()");
            // Console.WriteLine(int.Parse(singleDigit)); // can't "parse" a single char
            Console.WriteLine(int.Parse(singleDigit.ToString()));
            Console.WriteLine("The value in the variable singleDigit is " + singleDigit.ToString());

            Console.WriteLine("Converting '5' after calling .ToString() ...");
            Console.WriteLine(Convert.ToInt32(singleDigit.ToString()));

            Console.WriteLine((int)result);

            // variables of various data types, with values
            string sentance = "a string can hold many characters.";
            string empty = ""; // a string can be "empty" (zero characters)
            string nothing = null; // a string can be null (not the same as "empty")

            bool booleanVariable = true; // booleans can only hold values of true or false

            bool bool1 = false;
            
            // please note that true is not the same as "true"
            //                 \bool/                  \string/

            // Variable names are decided upon by you when you declare the variable.
            // Like everything else in c#, variable names are case sensitive..

            int number = 25; // -> number assigned as 25
            int Number = 15;
            int NuMbER = 10;

            // all of the above are case sensitive

            // boolean expressions
            
            int highNumber = 100;
            int lowNumber = 2;

            bool highIsBiggerThanLow = highNumber > lowNumber;
            //                         \relational expression/
            //                          \   true or false   /
            bool highIsBiggerThan50 = highNumber > 50;
            bool highIs100 = highNumber == 100;

            bool highIsBiggerThanLowAndBiggerThan50;
            highIsBiggerThanLowAndBiggerThan50 = highIsBiggerThanLow && highIsBiggerThan50;



        }
    }
}
