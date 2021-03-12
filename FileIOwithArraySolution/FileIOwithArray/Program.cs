﻿using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //your code goes here
            const int ARRAYSIZE = 100;
            int logicalSize = 0;
            int[] Marks = new int[ARRAYSIZE];

            string inputTemp = "";
            string FullFilePathName = "";
            do
            {
                inputTemp = MenuPrompt();
                switch (inputTemp.ToUpper())
                {
                    case "A":
                        {
                            FullFilePathName = HardCodedFileName();
                            logicalSize = ProcessFile(FullFilePathName,Marks,ARRAYSIZE);
                            break;
                        }
                    case "B":
                        {
                            //your code goes here
                            //pass the array to the method along with the number of active
                            //  elements in the array (logical size)
                            DisplayArray(Marks, logicalSize);
                            break;
                        }
                    case "C":
                        {
                            WriteToFile();
                            break;
                        }
                    case "D":
                        {
                            SequenceSearch(Marks, logicalSize);
                            break;
                        }
                    case "E":
                        {
                            BubbleSort(Marks, logicalSize);
                            break;
                        }
                    case "F":
                        {
                            int foundIndex = -1;
                            foundIndex = BinarySearch(Marks, logicalSize);
                            if (foundIndex > -1)
                            {
                                Console.WriteLine($"The value you are searching for is located at" +
                                    $" index {foundIndex} in the array. The search value was" +
                                    $" {Marks[foundIndex]}");
                            }
                            else
                            {
                                Console.WriteLine("The search value is not in the array");
                            }
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Have a nice day.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($" {inputTemp} is not a valid menu option. Try again.");
                            break;
                        }
                }
            } while (inputTemp.ToUpper() != "X");
        }

        static string HardCodedFileName()
        {

            string Folder_Pathname = @"F:\GitHub\CPSC-1012\FileProcessing\";
            string Full_Path_Filename;
            Full_Path_Filename = Folder_Pathname + @"OneColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"TwoColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"VariableColums.txt";
            //Full_Path_Filename = Folder_Pathname + @"BadFileDoesNotExist.txt";
            return Full_Path_Filename;
        }

        static int ProcessFile(string paramFullFilePathName, int[] Marks, int physicalSize)
        {
            //each record will represent an element in the array Marks
            //therefore the variable "records" will represent the logical number of
            //  elements used in the array
            int records = 0;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(paramFullFilePathName);
                string readline = "";
                readline = reader.ReadLine();
                while (readline != null)
                {
                    Console.WriteLine($"\nContents of file record\t{readline}");
                    int columncounter = 0;
                    foreach (string value in readline.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Column {columncounter} contains the value {value}");

                        //add the data to the appropriate array
                        //Concerns:
                        //  is there enough room in the array for another value
                        //  does the string input need to be converted
                        if (records < physicalSize)
                        {
                            //there is room for the value in the array
                            //ADD the value to the array
                            Marks[records] = int.Parse(value);
                            records++;
                        }
                        else
                        {
                            //creating your own error to handle a "logical" run problem
                            //this is NOT bad logic, it is a user generated problem
                            throw new Exception("Insufficient room for more data in the program");
                        }
                    }
                    readline = reader.ReadLine();
                }
                Console.WriteLine($"\nYou read {records} records");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"You had a problem reading the file. \nError:\t{ex.Message}");
            }
            finally
            {
                reader.Close();
            }
            return records;
        }

        static string MenuPrompt()
        {
            string inputTempLocal = "";
            Console.WriteLine("File I/O options:");
            Console.WriteLine("a) Hard-coded file name.");
            Console.WriteLine("b) Display array.");
            Console.WriteLine("c) Writing to a file.");
            Console.WriteLine("d) Search an array: Sequence Search.");
            Console.WriteLine("e) Sort an array: Bubble sort.");
            Console.WriteLine("f) Search an array: Binary Search.");
            Console.WriteLine("x) Exit.\n");
            Console.Write("Enter the menu option for File I/O\t");
            inputTempLocal = Console.ReadLine();
            return inputTempLocal;
        }

        static void WriteToFile()
        {
            string PathName = @"F:\\GitHub\\CPSC-1012\\FileProcessing\\";
            string FullPathName = PathName + @"NewFile.txt";
            StreamWriter writer;
            try
            {
                writer = new StreamWriter(FullPathName, false);
                Random rnd = new Random();
                int linesout = rnd.Next(1, 6);
                for (int looper = 0; looper < linesout; looper++)
                {
                    writer.Write($"line {looper}, terry\n");
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nError: {ex.Message}\n\n");
            }
        }

        static void DisplayArray(int[] Marks, int logicalSize)
        {
            //Traverse the array from the beginning to the end
            //write each element contents to the screen

            //with the while, YOU are responsible for all control of looping
            //  ensuring that your do NOT go beyond the contents of the array
            //the index is the physical position within the array (which element position)
            //      calculation of element position is  arrayAddress + (index * element size)
            //the logical size is a natural count of the number of active elements in the array

            //int index = 0;
            //while (index < logicalSize)
            //{
            //    Console.WriteLine($"Element at index {index} has a value of {Marks[index]}");
            //    index++;
            //}

            //all of the separate lines of looping count used for the while loop exists in the
            //  setup for the for loop
            for (int index = 0; index < logicalSize; index++)
            {
                Console.WriteLine($"Element at index {index} has a value of {Marks[index]}");
            }

            //  all control of the loop is embedded within the software of foreach
            //  foreach:
            //       checks to see if there is anything to process
            //       process the collection (array) from the start to the end!!!!!!!
            //       after an interation, automatically checks to see if another interation is
            //               required
            //       stops automatically when there is  nothing more to process
            //
            //  the foreach isolates a single instance of your collection using a placeholder
            //       variable
            //  during the processing, use the placeholder to obtain the contents of the
            //       element in your array that is currently being processed
            //
            //WARNING!!!!
            //  the foreach loop will process your ENTIRE collect INCLUDING any unused array
            //       elements
            //  if you which to used this looping and ONLY process the used array element
            //       YOU MUST still supply logic to NOT do certain processing for unused elements
            //foreach (int CurrentElement in Marks)
            //{
            //    Console.WriteLine($"Element has a value of {CurrentElement}");
            //}
        }

        static void SequenceSearch(int[] Marks, int logicalSize)
        {
            int searchValue = InputForInt();

            //
            //  Setup for search
            //
            bool foundFlag = false;
            int foundIndex = 0;
            //
            //  Search
            //  there are 2 conditions to stop the loop
            //      a) examine all elements
            //      b) did you find the element (if so stop)
            //
            //  for (int index = 0; index < logicalSize && !foundFlag; index++)     //start to end
            for (int index = logicalSize - 1; index >= 0 && !foundFlag; index--)       //end to start

            if(Marks[index] == searchValue)
            {
                foundFlag = true; //cause the loop to terminate
                foundIndex = index; //record the element index where your item was found
            }
            //
            //  Test search results
            //
            if (foundFlag)
            {
                Console.WriteLine($"You found your value ({searchValue}) in the array element" +
                    $" located at index {foundIndex}. Array Element value is >{Marks[foundIndex]}<\n");
            }
            else
            {
                Console.WriteLine($"\nYou did not find your value ({searchValue}).");
            }
        }

        static void BubbleSort(int[] Marks, int logicalSize)
        {
            //temp swap area
            int temp = 0;

            //swap flag (was a swap done on this iteration of the outer loop
            //if there was no swap done on an interation of the outer loop, it means
            //    that all required swapping has been done AND the array is in order
            //this optimizes the logic for sorting
            bool swapped = true;

            //loop to ensure every combination in the array is covered
            //since we known the number of iteration required (logicalSize)
            //      the best looping choice is for()
            for(int allIndex = 0; allIndex < logicalSize - 1 && swapped; allIndex++)
            {
                //the actual comparison loop is the inner loop
                //this loop needs to be done for each iteration of the outer
                //  loop
                //reset the swap flag for each array iteration
                swapped = false;

                //in a Bubble sort, one compares adjacent elements to determine
                //  if the elements need to be switched
                //to optimize the looping, on each execution of the outer loop
                //      one can short the number of iterations on the inner loop
                for (int swapIndex = 0; swapIndex < logicalSize - allIndex - 1; swapIndex++)
                {
                    //test to swap
                    //ascending order: greater than
                    //descending order: less than
                    if (Marks[swapIndex] > Marks[swapIndex + 1])
                    {
                        //swap
                        //extra code to see the swap
                        //Console.WriteLine("Pre Swap");
                        //DisplayArray(Marks, logicalSize);

                        //swap
                        //move one of the value out of the way (into the swap area)
                        temp = Marks[swapIndex];
                        Marks[swapIndex] = Marks[swapIndex + 1];
                        Marks[swapIndex + 1] = temp;
                        swapped = true;

                        //extra code to see the swap
                        //Console.WriteLine("Post Swap");
                        //DisplayArray(Marks, logicalSize);
                    }
                }
            }
        }

        static int BinarySearch(int[] Marks, int logicalSize)
        {
            int searchArg = InputForInt();
            int firstIndex = 0;
            int lastIndex = logicalSize - 1;
            int middleIndex = 0;
            //the found index is also serving as the flag to indicate that the
            //  search value has been found
            //since array do NOT have indexes, if the foundIndex is
            //  altered then the logical reason is the index point to a place int
            //  your array where your search argument exists.
            int foundIndex = -1;

            //there will be an unknown number of times through the loop
            //thus the best choice for looping will be the while loop
            while(firstIndex <= lastIndex && foundIndex == -1)
            {
                //find the middle index
                //this must be done using integer arithmetic
                middleIndex = (firstIndex + lastIndex) / 2;
                Console.WriteLine($"Pre-test: first {firstIndex} last {lastIndex} middle {middleIndex}");

                //comparisons
                if (searchArg > Marks[middleIndex])
                {
                    //everything in the SORTED array below the value at the middleIndex
                    //  AND the middleIndex cannot logically be my search argument
                    //therefore the NEW firstIndex is the element after the middle index element
                    firstIndex = middleIndex + 1;
                }
                else
                {
                    if (searchArg < Marks[middleIndex])
                    {
                        //everything in the SORTED array below the value at the middleIndex
                        //  AND the middleIndex cannot logically be my search argument
                        //therefore the NEW firstIndex is the element before the middle index element
                        lastIndex = middleIndex - 1;
                    }
                    else
                    {
                        //the current middleIndex element of the array is the element that
                        //      your program is looking for
                        //thus stop the search
                        //stopping the search done by changing your foundIndex to a non negative
                        //      value indicating the index location in the array
                        foundIndex = middleIndex;
                    }
                }

                Console.WriteLine($"Post-test: first {firstIndex} last {lastIndex} middle {middleIndex}");

            }
            return foundIndex;
        }

        static int InputForInt()
        {
            string inputTemp;
            bool valid = false;
            int value = 0;
            do
            {
                Console.Write("Enter a whole number (ex 5)\t");
                inputTemp = Console.ReadLine();
                if (int.TryParse(inputTemp, out value))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine($"Your value of >{inputTemp}< is invalid. Try again.");
                }
            } while (!valid);
            return value;
        }
    }
}
