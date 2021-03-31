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
            List<Opening> Openings = new List<Opening>();
            WriteLine($"After Load: Number of walls {Walls.Count,5} Number of openings {Openings.Count,-5}");
            //
            //loading using a returned List<T>
            Walls = InputWallsForRoom();
            
            //Loading using a List<T> as a method parameter argument
            InputOpeningsForRoom(Openings);
            WriteLine($"After Load: Number of walls {Walls.Count,5} Number of openings {Openings.Count,-5}");

            //create and load a class called Room
            //Room is a composite class
            //a composite class is identified by using other classes within its definition
            string name = GetNonEmptyString("Enter the name of the room:");
            string color = GetNonEmptyString("Enter the paint color of the room:");
            Room myRoom = null;
            try
            {
                //third way of creating an loading an instance
                //attach a coding block to your new statement
                //it DOES NOT MATTER if your class has OR has not got
                //      coded constructors to be able to use this technique
                //NOTE: not well formed if you are trying to use a "greedy" constructor
                myRoom = new Room()
                {
                    //syntax
                    //  class propertyname = value
                    Name = name,
                    color = color,
                    Walls = Walls,
                    Openings = Openings
                };

                //find the next area surface of the room
                //sum up all the room wall areas
                //sum up all the opening areas
                // surfaceArea = roomSurfaceArea - openingArea
                double wallSurfaceArea = 0.00;
                double openingArea = 0.0;
                //by using the Property Walls in the class Room, we prove
                //  that the List<T> (Walls) was truly loaded to the instance of Room
                foreach(Wall item in myRoom.Walls)
                {
                    //item is an instance of the List<Walls> in the collection loaded
                    //      to the Room instance myRoom
                    wallSurfaceArea += item.WallArea();
                }
                foreach (Opening item in myRoom.Openings)
                {
                    //item is an instance of the List<Walls> in the collection loaded
                    //      to the Room instance myRoom
                    openingArea += item.OpeningArea();
                }
                WriteLine($"\n\nTotal wall area {wallSurfaceArea} Total opening area {openingArea} giving a net" +
                    $" surface area to paint the color of {myRoom.color} of {wallSurfaceArea - openingArea} in the" +
                    $" room {myRoom.Name}");
            }
            catch(Exception ex)
            {
                WriteLine($"\nError: {ex.Message}\n");
            }
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

                //Step 1: create the instance
                aWall = new Wall();

                //Step 2: collect data and load the instance
                //obtain the width for the wall
                aWall.Width = GetPositiveDouble("Enter the width of your wall:");
                //obtain the height for the wall
                aWall.Height = GetPositiveDouble("Enter the height of your wall:");

                //Step 3: save the instance
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

        static void InputOpeningsForRoom(List<Opening> openings)
        {
            
            Opening anOpening = null;
            bool finished = false;
            double width = 0.0;
            double height = 0.0;
            string description = null;
            do
            {
                //loading using the "greedy" constructor
                //need to have all value for the instance BEFORE creating the
                //  actually instance (via new)
                
                //Step 1: collect data
                width = GetPositiveDouble("Enter the width of your opening:");
                height = GetPositiveDouble("Enter the height of your opening:");
                description = GetNonEmptyString("Enter a description of the opening (such as window, door," +
                    " fireplace, etc.)");

                //Step 2: create and load new instance using greedy constructor
                anOpening = new Opening(width, height, description);

                //Step 3: save the instance
                openings.Add(anOpening);
                if (GetNonEmptyString("Do you have another wall, Y or N.").ToUpper().Equals("N"))
                {
                    finished = true;
                }
            } while (!finished);
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
