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
            //int usageHours;
            //double usageBill;

            //Console.WriteLine("Internet Bill Calculator\n\n");
            //Console.Write("Please Enter Your Package:\t");
            //inputTemp = Console.ReadLine();
            //switch (inputTemp) {
            //        case "a":
            //        case "A":
            //            Console.Write("Please Enter Used Hours:\t");
            //            inputTemp = Console.ReadLine();
            //            if (int.TryParse(inputTemp, out usageHours) && usageHours > 0)
            //            {
            //                if (usageHours <= 10)
            //                {
            //                    Console.WriteLine($"Your bill is $9.95");
            //                }
            //                else
            //                {
            //                    usageBill = 9.95 + (2.00 * (usageHours - 10));
            //                    Console.WriteLine($"Your monthly bill is ${usageBill}");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{inputTemp} is not valid hours.");
            //            }
            //            break;
            //        case "b":
            //        case "B":
            //            Console.Write("Please Enter Used Hours:\t");
            //            inputTemp = Console.ReadLine();
            //            if (int.TryParse(inputTemp, out usageHours) && usageHours > 0)
            //            {
            //                if (usageHours <= 20)
            //                {
            //                    Console.WriteLine($"Your monthly bill is $13.95");
            //                }
            //                else
            //                {
            //                    usageBill = 13.95 + (1.00 * (usageHours - 20));
            //                    Console.WriteLine($"Your monthly bill is ${usageBill}");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{inputTemp} is not valid hours.");
            //            }
            //            break;
            //        case "c":
            //        case "C":
            //            Console.Write("Please Enter Used Hours:\t");
            //            inputTemp = Console.ReadLine();
            //            if (int.TryParse(inputTemp, out usageHours) && usageHours > 0)
            //            {
            //                Console.WriteLine($"Your monthly bill is $19.95");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{inputTemp} is not valid hours.");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine($"{inputTemp} is invalid. Please enter A, B or C for the package choosing.");
            //            break;
            //    }


            //2. Write a program that can allow the user to perform some simple unit conversions. The program
            //  should display a menu of available options to the user, prompt for the desired option, and then
            //  prompt for the value. The conversion should be performed and the new value should be displayed.
            //  Use the following table for conversions:

            //double convPoundNKilograms;
            //double convOuncesNLiters;
            //double convInchesNCentimeters;
            //double convFahrenheitNCelsius;

            //Console.WriteLine("UNIT CONVERSION TOOL\n\n");
            //Console.WriteLine("1. Pounds To Kilograms (or reversed).");
            //Console.WriteLine("2. Fluid Ounces To Liters (or reversed).");
            //Console.WriteLine("3. Inches To Centimeters (or reversed).");
            //Console.WriteLine("4. Fahrenheit To Celsius (or reversed).\n");
            //Console.Write("Choose your package:\t");
            //inputTemp = Console.ReadLine();
            //switch (inputTemp)
            //{
            //    case "1":
            //        Console.WriteLine("\nChoose which way of conversion between Pounds and Kilograms\n");
            //        Console.WriteLine("a. Pounds to Kilograms");
            //        Console.WriteLine("b. Kilograms to Pounds\n");
            //        Console.Write("Enter you choice:\t");
            //        inputTemp = Console.ReadLine();
            //        if ((inputTemp.ToLower() == "a") || (inputTemp.ToLower() == "b"))
            //        {
            //            if (inputTemp.ToLower() == "a")
            //            {
            //                Console.Write("Enter a number of pounds:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convPoundNKilograms) && convPoundNKilograms > 0)
            //                {
            //                    convPoundNKilograms /= 2.2046;
            //                    Console.WriteLine($"\n{inputTemp}lb = {Math.Round(convPoundNKilograms,4)}kg.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //            else
            //            {
            //                Console.Write("Enter a number of kilograms:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convPoundNKilograms) && convPoundNKilograms > 0)
            //                {
            //                    convPoundNKilograms *= 2.2046;
            //                    Console.WriteLine($"\n{inputTemp}kg = {Math.Round(convPoundNKilograms,4)}lb.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{inputTemp} is invalid choice. Please enter A or B.");
            //        }
            //        break;
            //    case "2":
            //        Console.WriteLine("\nChoose which way of conversion between Fluid Onuces (U.S.) and Liters\n");
            //        Console.WriteLine("a. Fluid Ounces to Liters");
            //        Console.WriteLine("b. Liters to Fluid Ounces\n");
            //        Console.Write("Enter you choice:\t");
            //        inputTemp = Console.ReadLine();
            //        if ((inputTemp.ToLower() == "a") || (inputTemp.ToLower() == "b"))
            //        {
            //            if (inputTemp.ToLower() == "a")
            //            {
            //                Console.Write("Enter a number of fluid ounces:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convOuncesNLiters) && convOuncesNLiters > 0)
            //                {
            //                    convOuncesNLiters /= 33.8140226;
            //                    Console.WriteLine($"\n{inputTemp}ounces = {Math.Round(convOuncesNLiters,4)}liter.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //            else
            //            {
            //                Console.Write("Enter a number of Liters:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convOuncesNLiters) && convOuncesNLiters > 0)
            //                {
            //                    convOuncesNLiters *= 33.8140226;
            //                    Console.WriteLine($"\n{inputTemp}liters = {Math.Round(convOuncesNLiters,4)}ounces.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{inputTemp} is invalid choice. Please enter A or B.");
            //        }
            //        break;
            //    case "3":
            //        Console.WriteLine("\nChoose which way of conversion between Inches and Centimeters\n");
            //        Console.WriteLine("a. Inches to Centimeters");
            //        Console.WriteLine("b. Centimeters to Inches\n");
            //        Console.Write("Enter you choice:\t");
            //        inputTemp = Console.ReadLine();
            //        if ((inputTemp.ToLower() == "a") || (inputTemp.ToLower() == "b"))
            //        {
            //            if (inputTemp.ToLower() == "a")
            //            {
            //                Console.Write("Enter a number of Inches:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convInchesNCentimeters) && convInchesNCentimeters > 0)
            //                {
            //                    convInchesNCentimeters /= 0.39370;
            //                    Console.WriteLine($"\n{inputTemp}inches = {Math.Round(convInchesNCentimeters, 4)}cm.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //            else
            //            {
            //                Console.Write("Enter a number of Centimeters:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convInchesNCentimeters) && convInchesNCentimeters > 0)
            //                {
            //                    convInchesNCentimeters *= 0.39370;
            //                    Console.WriteLine($"\n{inputTemp}cm = {Math.Round(convInchesNCentimeters, 4)}inches.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{inputTemp} is invalid choice. Please enter A or B.");
            //        }
            //        break;
            //    case "4":
            //        Console.WriteLine("\nChoose which way of conversion between Fahrenheit and Celsius\n");
            //        Console.WriteLine("a. Fahrenheit to Celsius");
            //        Console.WriteLine("b. Celsius to Fahrenheit\n");
            //        Console.Write("Enter you choice:\t");
            //        inputTemp = Console.ReadLine();
            //        if ((inputTemp.ToLower() == "a") || (inputTemp.ToLower() == "b"))
            //        {
            //            if (inputTemp.ToLower() == "a")
            //            {
            //                Console.Write("Enter a number of Fahrenheit:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convFahrenheitNCelsius))
            //                {
            //                    convFahrenheitNCelsius = (convFahrenheitNCelsius - 32) / 1.800;
            //                    Console.WriteLine($"\n{inputTemp}F = {Math.Round(convFahrenheitNCelsius, 4)}C.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //            else
            //            {
            //                Console.Write("Enter a number of Celsius:\t");
            //                inputTemp = Console.ReadLine();
            //                if (double.TryParse(inputTemp, out convFahrenheitNCelsius))
            //                {
            //                    convFahrenheitNCelsius = (convFahrenheitNCelsius * 1.8) + 32;
            //                    Console.WriteLine($"\n{inputTemp}C = {Math.Round(convFahrenheitNCelsius, 4)}F.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid Input, please enter a real number.");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{inputTemp} is invalid choice. Please enter A or B.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine($"{inputTemp} is invalid choice. Please enter 1, 2 or 3.");
            //        break;
            //}


            //Loop Problems
            //1. Find the sum of the squares of the integers from 1 to MySquare, where MySquare is input by the
            //  user.E.g.user enters 4 then return 1x1 + 2x2 + 3x3 + 4x4 = 30

            //int aNumber;
            //int sumNumbers = 0;
            //int loopCounter = 1;
            //string loopString = "";

            //Console.Write("Enter a integer to MySquare:\t");
            //inputTemp = Console.ReadLine();
            //if (int.TryParse(inputTemp, out aNumber) && aNumber > 0)
            //{
            //    while (loopCounter <= aNumber)
            //    {
            //        loopString = loopString + $"{loopCounter}x{loopCounter} + ";
            //        sumNumbers += (int)Math.Pow(loopCounter,2);
            //        loopCounter++;
            //    }
            //    int loopStringLength = loopString.Length;
            //    loopString = loopString.Substring(0, loopStringLength - 2);
            //    Console.WriteLine($"{loopString}= {sumNumbers}");
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is not valid integer.");
            //}


            //2. Input a list of positive numbers from the user and then calculate and display the average age. Use
            //  the input of the number zero(i.e. 0) to stop prompting for numbers.

            //int ageInput;
            //int sumOfAges = 0;
            //int averageAge;
            //int loopCount = 0;
            //Console.WriteLine("Average Age Calculator\n\n");
            //do
            //{
            //    Console.Write("Please Enter Your Age (enter 0 to stop recording):\t");
            //    inputTemp = Console.ReadLine();
            //    if (int.TryParse(inputTemp, out ageInput))
            //    {
            //        if (ageInput > 0)
            //        {
            //            sumOfAges += ageInput;
            //            loopCount++;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{inputTemp} is not a positive number.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputTemp} is invalid number of age.");
            //    }
            //} while (ageInput != 0);
            //averageAge = sumOfAges / loopCount;
            //Console.WriteLine($"The average age is {averageAge}");


            //3. Write a program that reads in a value N and then prints its digits in a column, starting with the last
            //  digit.E.g. if N = 3456, then the program should print the following:
            //                                                                          6
            //                                                                          5
            //                                                                          4
            //                                                                          3

            //int aNumber;

            //Console.Write("Enter a value N (i.e., 3456):\t");
            //inputTemp = Console.ReadLine();
            //if (int.TryParse(inputTemp, out aNumber))
            //{
            //    int aNumberLength = aNumber.ToString().Length;
            //    //index starts with 0, so '3456' => 0=3 1=4 2=5 3=6 ===> loopCounter = aNumberLength - 1
            //    for (int loopCounter = aNumberLength - 1; loopCounter >= 0; loopCounter--)
            //    {
            //        Console.WriteLine($"{inputTemp.Substring(loopCounter,1)}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is not valid value of N, please re-enter.");
            //}


            //More Looping Problems
            //1. A bacteriologist determines that the approximate final population of bacteria present in a
            //  culture after time(in days) is given by the following formula:

            //  FinalPopulation = InitialPopulation * e^(GrowthRate * Time)

            //  where InitialPopulation is the number present at the beginning of the observation period
            //  (Note: InitialPopulation does not change its value). Let the user input the
            //  InitialPopulation, which is the number of bacteria present at the beginning of the trial and
            //  the GrowthRate(as a percentage). Then compute the number of bacteria in the culture
            //  after each day for the first 10 days(Time will have values 1 through 10).Do this in a
            //  loop so the user can see the results in a table(properly format your table with column
            //  headers and a title).The output table should have headings for Day and Number of
            //  Bacteria Present(on that day).

            //  NOTE: The number e is a mathematical constant that is the base of the natural
            //  logarithm.It is approximately equal to 2.71828 and is available in the C# Math library.

            //double initialPopulation = 0.0;
            //double growthRate = 0.0;
            //double finalPopulation = 0.0;
            //const int MAXDAYS = 10;

            //Console.WriteLine("Final Population of Bacteria Calculator\n\n");
            //Console.Write("Enter an initial population:\t");
            //inputTemp = Console.ReadLine();
            //if (double.TryParse(inputTemp, out initialPopulation))
            //{
            //    Console.Write("\nEnter the growth rate (i.e., 1.24% -> input 1.24):\t");
            //    inputTemp = Console.ReadLine();
            //    if (double.TryParse(inputTemp, out growthRate))
            //    {
            //        Console.WriteLine("\n{0,5} {1,25}", "Day", "Number of Bacteria Present (on that day)");
            //        for (int i = 1; i <= MAXDAYS; i++)
            //        {
            //            finalPopulation = initialPopulation * Math.Pow((Math.E), ((growthRate / 100) * (double)i));
            //            Console.WriteLine("{0,5} {1,25:0.00000}", i, finalPopulation);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputTemp} is invalid number of growth rate");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid number of initial population.");
            //}


            //2. Write a program that will prompt the user for a string (could be anything), and then
            //  prompts the user for a single character.The program should then display a count of the
            //  number of times the character entered appears in the string.

            //Console.Write("Enter anything you like:\t");
            //inputTemp = Console.ReadLine();
            //int stringLength = inputTemp.Length;
            //Console.WriteLine("{0,5}", "Character");
            //for (int loopCounter = 0; loopCounter <= stringLength - 1; loopCounter++)
            //{
            //    Console.WriteLine("{0,5}", inputTemp.Substring(loopCounter, 1));
            //}
            //Console.WriteLine($"The number of times the character entered appears in the string is {stringLength}");


            //3. Write a program for an Internet service provider so they can calculate how much to bill
            //  their customers. The provider offers customers 3 packages:

            //PACKAGE COST CALCULATION
            //  A $9.95 per month for 10 hours; additional hours are billed at $2.00 per hour
            //  B $13.95 per month for 20 hours; additional hours are billed at $1.00 per hour
            //  C $19.95 per month of unlimited hours

            //The program should prompt for the letter of the service package (A, B, or C) and the
            //  number of hours they have used. The program should then display the total amount
            //  billed.The program should allow for multiple bills to be processed(i.e.use a loop).

            int usedHours = 1;
            double userBill = 0.0;

            Console.WriteLine("User Billings Calculator\n\n");
            Console.Write("Enter the customer Package: (A, B or C):\t");
            inputTemp = Console.ReadLine();
            switch (inputTemp)
            {
                case "a":
                case "A":
                    while (usedHours != 0)
                    {
                        Console.Write("Enter the used hours (enter 0 to end calculation):\t");
                        inputTemp = Console.ReadLine();
                        if (int.TryParse(inputTemp, out usedHours) && usedHours >= 0)
                        {
                            if (usedHours > 10)
                            {
                                userBill = 9.95 + ((usedHours - 10) * 2.0);
                                Console.WriteLine("The monthly bill is {0:0.00}", userBill);
                            }
                            else
                            {
                                Console.WriteLine($"The monthly bill is $9.95");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{inputTemp} is invalid number of hours.");
                        }
                    }
                    break;
                case "b":
                case "B":
                    while (usedHours != 0)
                    {
                        Console.Write("Enter the used hours (enter 0 to end calculation):\t");
                        inputTemp = Console.ReadLine();
                        if (int.TryParse(inputTemp, out usedHours) && usedHours >= 0)
                        {
                            if (usedHours > 20)
                            {
                                userBill = 13.95 + ((usedHours - 20) * 1.0);
                                Console.WriteLine("The monthly bill is {0:0.00}", userBill);
                            }
                            else
                            {
                                Console.WriteLine($"The monthly bill is $9.95");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{inputTemp} is invalid number of hours.");
                        }
                    }
                    break;
                case "c":
                case "C":
                    while (usedHours != 0)
                    {
                        Console.Write("Enter the used hours (enter 0 to end calculation):\t");
                        inputTemp = Console.ReadLine();
                        if (int.TryParse(inputTemp, out usedHours) && usedHours >= 0)
                        {
                            Console.WriteLine($"The monthly bill is $9.95");
                        }
                        else
                        {
                            Console.WriteLine($"{inputTemp} is invalid number of hours.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine($"{inputTemp} is invalid package choice, please enter A, B or C.");
                    break;
            }



        }
    }
}
