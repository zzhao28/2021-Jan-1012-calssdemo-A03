using System;

namespace ReadingWeekPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Problems
            //1. Write a program that will prompt the user for three real numbers and computes their mean
            //  average.Display the average to the user.
            //Using your knowledge of data types, modify the program you wrote for Question 1 so that it
            //  will round the mean average to two decimal places.

            string inputTemp;
            //int aNumber;
            //int bNumber;
            //int cNumber;
            //Console.WriteLine("Calculating the average of three real numbers.\n\n");
            //Console.Write("Enter 1st real number:\t");
            //inputTemp = Console.ReadLine();
            //if (int.TryParse(inputTemp, out aNumber))
            //{
            //    Console.Write("\nEnter 2nd real number:\t");
            //    inputTemp = Console.ReadLine();
            //    bNumber = int.Parse(inputTemp);
            //    Console.Write("\nEnter 3rd real number:\t");
            //    inputTemp = Console.ReadLine();
            //    cNumber = int.Parse(inputTemp);
            //    double sumAvg = (aNumber + bNumber + cNumber) / 3.0;
            //    Console.WriteLine($"The average is {Math.Round(sumAvg,2)}.");
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid, please enter real numbers.");
            //}

            //The Pythagorean Theorem can be used to find the length of the hypotenuse of a right
            //  triangle. Write a program that can solve for the hypotenuse once provided with the height
            //      and base of the right triangle.Use the following information:

            //double triangleHeight = 0.0;
            //double triangleBase = 0.0;


            //Console.WriteLine("The Pythagorean Theorem - Hypotenuse Calculator\n\n");
            //Console.Write("Please enter a height:\t");
            //inputTemp = Console.ReadLine();
            //if (double.TryParse(inputTemp, out triangleHeight))
            //{
            //    Console.Write("Please enter a base:\t");
            //    inputTemp = Console.ReadLine();
            //    if (double.TryParse(inputTemp, out triangleBase))
            //    {
            //        double triangleHypotenuse = Math.Sqrt(Math.Pow(triangleHeight,2) + Math.Pow(triangleBase,2));
            //        Console.WriteLine($"\nThe hypotenuse of your triangle is {Math.Round(triangleHypotenuse,2)}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\nHeight is fine, but base {inputTemp} is invalid input.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"\nHeight {inputTemp} is invalid input.");
            //}


            //Write a program that will prompt the user for a three-digit whole number.The program will
            //then calculate the sum of the digits of the number, and then display both the number and its
            //digit sum. (i.e. 123->sum = 6)

            int aNumber;
            int digitOne;
            int digitTwo;
            int digitThree;

            Console.WriteLine("Calculate the sum of three-digit number\n\n");
            Console.Write("Please enter a three-digit whole number:\t");
            inputTemp = Console.ReadLine();

            if (int.TryParse(inputTemp, out aNumber))
            {
                digitOne = aNumber % 10;
                digitTwo = aNumber / 10 % 10;
                digitThree = aNumber / 100 % 10;
                int sumNumbers = digitOne + digitTwo + digitThree;
                Console.WriteLine($"The numbers are {digitOne} {digitTwo} {digitThree}, and sum is {sumNumbers}");

            }
            else
            {
                Console.WriteLine($"{inputTemp} is invalid");
            }

        }
    }
}
