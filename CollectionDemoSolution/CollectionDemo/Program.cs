using System;

#region Additional Namespace
using System.Collections.Generic;   //need for List<T> classes
using static System.Console;        //need for WriteLine, Readline, Write
#endregion

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicsOfLists();

            //using composite classes
            //class Room
            //  within the class: Wall, Opening, List<T>

            //create a collection of Walls for the room

            //when the List<T> is created, the instance will be empty (Count==0)
            List<Wall> Walls = new List<Wall>();
            Walls = InputWallsForRoom();
            List<Opening> Openings = new List<Opening>();
        }


        static void BasicsOfLists()
        {
            //declare a List<T> where <T> is the datatype
            List<int> setOfNumbers = new List<int>();
            //add element to a list

            setOfNumbers.Add(55);
            setOfNumbers.Add(41);
            setOfNumbers.Add(100);
            int number = 78;
            setOfNumbers.Add(number);
            setOfNumbers.Add(number + 1);

            //display the current number of items in the list .Count
            WriteLine($"The list contains {setOfNumbers.Count} elements");

            //traverse a List<T>
            for (int i = 0; i < setOfNumbers.Count; i++)
            {
                WriteLine($"the list item {i + 1} is {setOfNumbers[i]}");
            }

            //Sort a list
            // "for two element x and y do the following"
            //  ascending sort is x vs y
            //  descending sort is y vs x
            setOfNumbers.Sort((x,y) => y.CompareTo(x));

            //pre-test loop
            //system checks to see if there is a element in the list
            //if there is an element(s) in the list, each element is accessed
            //  on at a time, from start to end, and the element is processed
            //  by the logic in the loop coding block
            //the system checks for the end of the list and stops automatically
            foreach(int listElement in setOfNumbers)
            {
                //while in the loop your reference the current element via your
                //      placeholder (variable)
                WriteLine($"the list item is {listElement}");
            }

            //removing from a list<T>
            setOfNumbers.Remove(number + 1);

            foreach (int listElement in setOfNumbers)
            {
                //while in the loop your reference the current element via your
                //      placeholder (variable)
                WriteLine($"the list item is {listElement}");
            }
        }

        static List<Wall> InputWallsForRoom()
        {
            //declare a variable capable of holding an instance of
            //  the class Wall;
            Wall aWall = null;
            //you need to create a local List<T> BECAUSE
            //  you DID NOT pass in the collection to be filled
            //you will return the local List<T>
            List<Wall> inputWalls = new List<Wall>();
            bool finished = false;
            do
            {
                //to create a NEW UNIQUE instance of the class Wall, use the 
                //  new operator and the class name.
                //the new operator will use the Wall default constructor
                aWall = new Wall();
                //obtain the width for the wall
                aWall.Width = GetPositiveDouble("Enter the width of your wall:");
                //obtain the height for the wall
                aWall.Height = GetPositiveDouble("Enter the height of your wall:");
                //add the instance to the wall collection
                inputWalls.Add(aWall);
                if (GetNonEmptyString("Do you have another wall, Y or N.").ToUpper().Equals("N"))
                {
                    finished = true;
                }
            } while (!finished);
            //return the wall collection
            return inputWalls;
        }

        static double GetPositiveDouble(string prompt)
        {
            double number = 0.0;
            string inputTemp = "";
            bool valid = false;
            do
            {
                Console.Write($"{prompt}\t");
                inputTemp = ReadLine();
                if (double.TryParse(inputTemp, out number))
                {
                    if (number > 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        WriteLine($"Input is invalid {inputTemp}. Not a positive number. Try again.");
                    }
                }
                else
                {
                    WriteLine($"Input is invalid {inputTemp}. Try again.");
                }
            } while (!valid);
            return number;
        }

        static string GetNonEmptyString(string prompt)
        {
            string inputTemp = "";
            bool valid = false;
            do
            {
                Console.Write($"{prompt}\t");
                inputTemp = ReadLine();
                if (!string.IsNullOrEmpty(inputTemp))
                {
                        valid = true;
                }
                else
                {
                    WriteLine($"Input is empty. Try again to empty a string of characters.");
                }
            } while (!valid);
            return inputTemp;
        }
    }
}
