using System;

namespace LoopProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTemp = "";
            int inputNumber = 0;
            int sumOfNumbers = 0;

            //post-test

            do
            {
                Console.Write("\nEnter a number of MySquare:\t");
                inputTemp = Console.ReadLine();
                if (int.TryParse(inputTemp, out inputNumber))
                {
                    sumOfNumbers = (inputNumber / inputNumber) * 
                }
                else
                {

                }


            } while (inputNumber >= 1);
            
        }
    }
}
