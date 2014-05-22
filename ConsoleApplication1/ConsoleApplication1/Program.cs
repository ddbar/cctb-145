using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 100: ");
            string text = Console.ReadLine();

            int inputNumber = int.Parse(text);
            if (inputNumber > 0 && inputNumber <= 100)
            {
                int totalEvenNumbers = 0;


                for (int curNumber = 1; curNumber <= inputNumber; curNumber++)
                {
                    if (IsEvenNumber(curNumber))
                    {
                    totalEvenNumbers += curNumber;
                    Console.Write(" {0} ", curNumber);
                    
                                              
                        if (curNumber < inputNumber)
                        
                        {
                            Console.Write("+");
                        }

                    }

                    } 
                  
                    Console.Write(" {0}", totalEvenNumbers);
                }
            

                else 
                
                {
                
                Console.WriteLine("invalid Number! Number must be between 1 and 100.");
               
                }
            
                        
                }

        static public bool IsEvenNumber(int intNumber)
        {
            return intNumber % 2 == 0;

        }

    }
}

