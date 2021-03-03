using System;

namespace MethodProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //driver

            //any local variable within a method is "alive" only as loing as the
            //    method is also "alive"
            //variables between method may have the same name BUT are local to
            //    the method the variable exists in (term is called: scope)
            string inputTemp = "";
            int lowerRange = 1;
            int higherRange = 10;
            int target = 0;
            const string CORRECT = "Correct";
            Random rnd = new Random();
            bool playGame = false;

            do
            {
                inputTemp = DisplayMenu();
                switch (inputTemp.ToLower())
                {
                    case "a":
                        //prompt for the game's lower range
                        lowerRange = InputNumeric("Enter the number for the lower range limit");
                        //prompt for the game's higher range
                        higherRange = InputNumeric("Enter the number for the higher range limit");
                        Console.WriteLine($"Your range is from {lowerRange} to {higherRange}");
                        playGame = true;
                        //could test to see if lower + 1 < higher
                        //why
                        //  ensures that you have spread of 3 possible (lower 4, upper 6)
                        //  ensures that the player did not entry the high number than
                        //      the lower number just to mess up your program
                        break;
                    case "b":
                        if (playGame == false)
                        {
                            Console.WriteLine("Please set your range before playing game.");
                        }
                        else
                        {
                            //scope: within the case coding block
                            int guessCount = 0;
                            string guessResult = "";

                            //a random number within the range
                            target = rnd.Next(lowerRange, higherRange + 1);

                            while (!guessResult.Equals(CORRECT))
                            {
                                guessCount++;
                                guessResult = MakeGuess(lowerRange, higherRange, target);
                                if (!guessResult.Equals(CORRECT))
                                {
                                    Console.WriteLine($"You did not guess correctly. Your guess is too {guessResult}");
                                }
                                else
                                {
                                    Console.WriteLine($"\nCorrect. The secret number was {target}. It took you {guessCount} times" +
                                        $" to guess the number.\n");
                                }
                            }
                        }
                        break;
                    case "x":
                        Console.WriteLine("Thank you for playing our game. Please play again.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid menu choice. Try again.\n");
                        break;
                }

            } while (!inputTemp.ToLower().Equals("x"));
            
        }
        
        //a method stub is the method header and any return statement that is required
        //there is no logic in the method stub
        //it is a skeleton setup for the required method
        //this allows the call statement to the method to be coded elsewhere in your
        //      program so the program will compile
        static string DisplayMenu()
        {
            //methods that return a value are also known as functions
            //methods that do not return a value are also known as subroutines
            //
            //string inputTemp = "";
            Console.WriteLine("\nHigh/Low Guessing Game\n");
            Console.WriteLine("a) Set range");
            Console.WriteLine("b) Play game");
            Console.WriteLine("x) Exit\n");
            Console.Write("Enter your meanu choice:\t");
            //inputTemp = Console.ReadLine();
            //return inputTemp;
            return Console.ReadLine();
        }

        static int InputNumeric(string prompt)
        {
            //any local variable within a method is "alive" only as loing as the
            //    method is also "alive"
            //variables between method may have the same name BUT are local to
            //    the method the variable exists in (term is called: scope)
            string inputTemp = "";
            int aNumber = 0;

            //you might see logic that sets a boolean value (commonly call a flag)
            //   and the loop condition tests to see if the value indicates
            //   another iteration is required
            bool flag = false;

            while (flag == false)
            {
                Console.Write($"{prompt}:\t");
                inputTemp = Console.ReadLine();

                //xxx.TryParse(input string, out output conversion)
                //returns true if successful and does the conversion
                //returns false if not able to convert and DOES not do the conversion
                if (int.TryParse(inputTemp, out aNumber))
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine($"Your input of >{inputTemp}< is not a whole number (ex 5)");
                }
            }
            return aNumber;
        }

        static string MakeGuess(int low, int high, int target)
        {
            int guessNumber = 0;
            string guessResult = "";
            guessNumber = InputNumeric($"Guess a number between {low} and {high}");
            if (guessNumber == target)
            {
                guessResult = "Correct";
            }
            else if (guessNumber < target)
            {
                guessResult = "low";
            }
            else
            {
                guessResult = "high";
            }
            return guessResult;
        }
    }
}
