using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //pre-test loop structure (a.k.a. DO-While structure)
            //
            //string inputTemp;
            //int aNumber;

            //Console.Write("Enter a number:\t");
            //inputTemp = Console.ReadLine();
            //aNumber = int.Parse(inputTemp);
            //int loopExecutions = 0;
            ////pre-test loop
            //while (aNumber != 0)
            //{
            //    //all codewithin this coding block ({....})
            //    //  belongs to the loop

            //    //a fast way of adding 1 to a counter
            //    //loopExecutions = loopExecutions + 1;
            //    loopExecutions++;

            //    Console.WriteLine($"You entered the number {aNumber}");
            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //}//eowhile

            ////next statement is the 1st executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions}");


            ////post-test loop
            //do
            //{
            //    //all codewithin this coding block ({....})
            //    //  belongs to the loop

            //    //a fast way of adding 1 to a counter
            //    //loopExecutions = loopExecutions + 1;
            //    loopExecutions++;
            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //    if (aNumber != 0) //termination number DO NOT PRINT
            //    {
            //        Console.WriteLine($"You entered the number {aNumber}");
            //    }
            //} while (aNumber != 0); //eowhile

            ////next statement is the 1st executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions}");


            ////Assume you are a an instructor.
            ////Enter a mark for each student in your class.
            ////continue enter marks for the student and after
            ////    all marks are have been entered, calculate the average.
            ////The heighest mark for any student is 100.
            ////The lowest mark for any student is 0.
            

         
            string inputTemp;
            int aNumber;
            int loopExecutions = 0;
            int subMarks = 0;
            int sumMarks = 0;
            int averageMark = 0;

            //post - test loop
            do
            {
                loopExecutions++;
                subMarks = sumMarks;
                Console.WriteLine("Enter a mark:\t");
                Console.WriteLine("* Enter 0 to end recording.");
                inputTemp = Console.ReadLine();
                aNumber = int.Parse(inputTemp);
                sumMarks = subMarks + aNumber;



            } while (aNumber > 0 && aNumber <= 100); //eowhile
            averageMark = sumMarks / (loopExecutions - 1);
            Console.WriteLine($"All marks are recorded, the average is {averageMark}.");


            //pre-test loop
            //Console.WriteLine("Enter a mark:\t");
            //Console.WriteLine("* Enter 0 to end recording.");
            //inputTemp = Console.ReadLine();
            //aNumber = int.Parse(inputTemp);
            //while (aNumber > 0 && aNumber <= 100)
            //{
            //    loopExecutions++;
            //    subMarks = sumMarks;
            //    Console.WriteLine("Enter a mark:\t");
            //    Console.WriteLine("* Enter 0 to end recording.");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //    sumMarks = subMarks + aNumber;
            //}

            //averageMark = sumMarks / (loopExecutions - 1);
            //Console.WriteLine($"All marks are recorded, the average is {averageMark}.");

        }//eoMain
    }
}
