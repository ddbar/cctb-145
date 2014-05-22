using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lessThan5 = 0;
            int greaterThan5 = 0;

            for (int outerloop = 5; outerloop > 0; outerloop--)
            {
                for (int innerLoop = 1; innerLoop <= 3; innerLoop++)

                {
                    int result = innerLoop * outerloop;
                    if (result < 5)
                    {
                        lessThan5++;
                    }

                    else if (result > 5)
                    {
                        greaterThan5++;
                    }

                    if (result != 5)
                    {
                        Console.WriteLine("{0} ", result.ToString());

                    }


                }


            
            }

            Console.WriteLine("{0} are less than 5.", lessThan5.ToString());
            Console.WriteLine("{0} are greater than 5", greaterThan5.ToString());

        }
    }
}
