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



            //string inputTemp;
            //int aNumber;
            //int loopExecutions = 0;
            //int subMarks = 0;
            //int sumMarks = 0;
            //int averageMark = 0;

            ////post - test loop
            //do
            //{
            //    loopExecutions++;
            //    subMarks = sumMarks;
            //    Console.WriteLine("Enter a mark:\t");
            //    Console.WriteLine("* Enter 0 to end recording.");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //    sumMarks = subMarks + aNumber;



            //} while (aNumber > 0 && aNumber <= 100); //eowhile
            //averageMark = sumMarks / (loopExecutions - 1);
            //Console.WriteLine($"All marks are recorded, the average is {averageMark}.");


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

            //reqirements
            // data: counter for marks entered (int)
            //       totaling variable (int)
            //       final avg variable (rounded(int) or round(double,1))
            //processing: interative logic
            //              prompt, read, sum, check for next entry
            //          : what will be the terminating value
            //              could one use a character (string) to terminate ie x
            //          : claculate and display the number of students and average

            //declare my variable
            string inputTemp;
            int inputNumber = 0;
            int sumOfMarks = 0;
            int countOfStudents = 0;

            //get my first value
            //Console.Write("Enter a student mark or X to exit:\t");
            //inputTemp = Console.ReadLine();

            ////pre-test
            //while (inputTemp.ToUpper() != "X")
            //{
            //    sumOfMarks += int.Parse(inputTemp);
            //    countOfStudents++;  //fast way to add 1 to a counter
            //    Console.Write("\n\nEnter the student mark or X to exit:\t");
            //    inputTemp = Console.ReadLine();
            //}
            //if (countOfStudents == 0)
            //{
            //    Console.WriteLine("You did not enter any student marks.");
            //}
            //else
            //{
            //    Console.WriteLine($"There are {countOfStudents} students. Their average" +
            //    $"mark is {Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}");
            //}

            //post-test
            //get my first value
            
            do
            {
                Console.Write("\nEnter a student mark between 0 and 100 or X to exit:\t");
                inputTemp = Console.ReadLine();
                if (inputTemp.ToUpper() != "X")
                {
                    //is the data of the correct datatype
                    if (int.TryParse(inputTemp,out inputNumber))
                    {
                        //validating that the input number is within the range of 0 to 100
                        if (inputNumber >= 0 && inputNumber <= 100)
                        {
                            //Assume that data is good
                            sumOfMarks += inputNumber;
                            countOfStudents++;  //fast way to add 1 to a counter
                        }
                        else
                        {
                            Console.WriteLine($"Your number {inputNumber} is outside " +
                                $"the accepatable range of 0 to 100. Value Rejected. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Your entered value {inputTemp} is not a number or the " +
                            $"character X. Your value is invalid and rejected.");
                    }
                    
                }
             } while (inputTemp.ToUpper() != "X");

            if (countOfStudents == 0)
            {
                Console.WriteLine("You did not enter any student marks.");
            }
            else
            {
                Console.WriteLine($"There are {countOfStudents} students. Their average" +
                $"mark is {Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}");
            }


        }//eoMain
    }
}
