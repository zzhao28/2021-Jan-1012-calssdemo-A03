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

            //int aNumber;
            //int digitOne;
            //int digitTwo;
            //int digitThree;

            //Console.WriteLine("Calculate the sum of three-digit number\n\n");
            //Console.Write("Please enter a three-digit whole number:\t");
            //inputTemp = Console.ReadLine();

            //if (int.TryParse(inputTemp, out aNumber) && aNumber >= 100 && aNumber <= 999)
            //{
            //    digitOne = aNumber / 100 % 10;
            //    digitTwo = aNumber / 10 % 10;
            //    digitThree = aNumber % 10;
            //    int sumNumbers = digitOne + digitTwo + digitThree;
            //    Console.WriteLine($"The numbers are {digitOne} {digitTwo} {digitThree} -> sum = {sumNumbers}");

            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid, enter a three-digit number.");
            //}


            //Decision Making Problems
            //1. Write a program that will prompt for a number and display “positive” if it is greater than zero,
            //  “negative” if it is less than zero, and “zero” if it is equal to zero.

            //int aNumber;

            //Console.Write("Enter a number:\t");
            //inputTemp = Console.ReadLine();
            //if (int.TryParse(inputTemp, out aNumber))
            //{
            //    if (aNumber > 0)
            //    {
            //        Console.WriteLine("\nPositive");
            //    }
            //    else if (aNumber < 0)
            //    {
            //        Console.WriteLine("\nNegative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nZero");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"\n{inputTemp} is invalid number.");
            //}


            //2. Write a program that will determine the cost of admission for a theatre. The price of admission
            //  is based on the age of the customer.Your program should prompt the user for their age and
            //      then display the correct admission amount.

            //int customerAge;
            //Console.WriteLine("Cost of Theatre Admission Checking System\n\n");
            //Console.Write("Enter your age:\t");
            //inputTemp = Console.ReadLine();
            //if (int.TryParse(inputTemp, out customerAge) && customerAge > 0)
            //{
            //    if (customerAge <= 6)
            //    {
            //        Console.WriteLine("Your cost of admission is free.");
            //    }
            //    else if (customerAge <= 17)
            //    {
            //        Console.WriteLine("Your cost of admission is $9.80.");
            //    }
            //    else if (customerAge <= 54)
            //    {
            //        Console.WriteLine("Your cost of admission is $11.35.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your cost of admission is $10.00.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid age.");
            //}


            //3. Write a program that will prompt the user for a student’s name and their mark. The program
            //  should display the student’s name along with a letter grade calculated using the following table:

            //int studentMark;
            //Console.WriteLine("Grade Checking System\n\n");
            //Console.Write("Enter your name:\t");
            //string studentName = Console.ReadLine();
            //Console.Write("Enter your mark:\t");
            //inputTemp = Console.ReadLine();
            //if (int.TryParse(inputTemp, out studentMark) && studentMark >= 0 && studentMark <= 100)
            //{
            //    if (studentMark < 50)
            //    {
            //        Console.WriteLine($"{studentName} your grade is F.");
            //    }
            //    else if (studentMark <70)
            //    {
            //        Console.WriteLine($"{studentName} your grade is D.");
            //    }
            //    else if (studentMark < 80)
            //    {
            //        Console.WriteLine($"{studentName} your grade is C.");
            //    }
            //    else if (studentMark < 90)
            //    {
            //        Console.WriteLine($"{studentName} your grade is B.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentName} your grade is A.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid number.");
            //}


            //4. Write a program that will compute the income tax due on a taxable income entered by the user.
            //  Use the following table to determine the tax owed:
            //double taxableIncome;
            //double incomeTax;
            //Console.WriteLine("Income Tax Calculation\n\n");
            //Console.Write("Enter your taxable income:\t");
            //inputTemp = Console.ReadLine();
            //if (double.TryParse(inputTemp, out taxableIncome) && taxableIncome > 0)
            //{
            //    if (taxableIncome < 50000.00)
            //    {
            //        incomeTax = taxableIncome * 0.05;
            //        Console.WriteLine($"\nYour income tax is ${Math.Round(incomeTax,2)}");
            //    }
            //    else if (taxableIncome < 100000.00)
            //    {
            //        incomeTax = 2500.00 + ((taxableIncome - 50000.00) * 0.07);
            //        Console.WriteLine($"\nYour income tax is ${Math.Round(incomeTax, 2)}");
            //    }
            //    else
            //    {
            //        incomeTax = 6000.00 + ((taxableIncome - 100000.00) * 0.09);
            //        Console.WriteLine($"\nYour income tax is ${Math.Round(incomeTax, 2)}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid number.");
            //}


            //Decision Making Problems – Switch
            //1. Write a program for an Internet service provider so they can calculate how much to bill their
            //  customers.The provider offers customers 3 packages:
            //  The program should prompt for the letter of the service package (A, B, or C) and the number of
            //  hours they have used if either option A or B has been selected.
            int usageHours;
            double usageBill;

            Console.WriteLine("Internet Bill Calculator\n\n");
            Console.Write("Please Enter Your Package:\t");
            inputTemp = Console.ReadLine();
            if (inputTemp.ToUpper() == "A" || inputTemp.ToUpper() == "B" || inputTemp.ToUpper() == "C")
            {
                switch (inputTemp) {
                    case "a":
                    case "A":
                        Console.Write("Please Enter Used Hours:\t");
                        inputTemp = Console.ReadLine();
                        if (int.TryParse(inputTemp, out usageHours) && usageHours > 0)
                        {
                            if (usageHours <= 10)
                            {
                                Console.WriteLine($"Your bill is $9.95");
                            }
                            else
                            {
                                usageBill = 9.95 + (2.00 * (usageHours - 10));
                                Console.WriteLine($"Your monthly bill is ${usageBill}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{inputTemp} is not valid hours.");
                        }
                        break;
                    case "b":
                    case "B":
                        Console.Write("Please Enter Used Hours:\t");
                        inputTemp = Console.ReadLine();
                        if (int.TryParse(inputTemp, out usageHours) && usageHours > 0)
                        {
                            if (usageHours <= 20)
                            {
                                Console.WriteLine($"Your monthly bill is $13.95");
                            }
                            else
                            {
                                usageBill = 13.95 + (1.00 * (usageHours - 20));
                                Console.WriteLine($"Your monthly bill is ${usageBill}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{inputTemp} is not valid hours.");
                        }
                        break;
                    case "c":
                    case "C":
                        Console.Write("Please Enter Used Hours:\t");
                        inputTemp = Console.ReadLine();
                        if (int.TryParse(inputTemp, out usageHours) && usageHours > 0)
                        {
                            Console.WriteLine($"Your monthly bill is $19.95");
                        }
                        else
                        {
                            Console.WriteLine($"{inputTemp} is not valid hours.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"{inputTemp} is invalid. Please enter A, B or C for the package choosing.");
            }



        }
    }
}
