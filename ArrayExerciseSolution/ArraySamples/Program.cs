using System;

namespace ArraySamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays are fixed-size
            //each element in the array is the same datatype

            //an integer array of size 6
            //this array will simulate a single dice (die)
            //the size indicates that there are 6 faces on this die

            int[] dieFace;  //I have a variable representing an integer array
                            //      which has NOT YET assigned size
                            //this variable CANNOT hold data at this time

            dieFace = new int[6];   //this statement assigns an area in memory
                                    //  of 6 int size elements
                                    //this variable CAN hold data at this time

            int[] die2Face = new int[6];    //declaring array AND allocating (requesting)
                                            //    an area in memory to be set aside
                                            //    for 6 int size elements

            int[] die3Face = new int[6] { 1, 2, 3, 4, 5, 6 };   //declare, allocate AND
                                                                //  assign my own initial
                                                                //  values to the array

            int[] die3Alternative = { 1, 2, 3, 4, 5, 6};    //declare, allocate and assign
                                                            //array size (allocation) was
                                                            //    determined by the number
                                                            //    of initial values

            string[] dieFaceName = { "One", "Two", "Three", "Four", "Five", "Six" };

            //traverse an array
            //what is needed to know: size of the array
            //How does one reference a particular element in the array: by index (starts at 0)
            //How does one change index: use interation (looping) logic

            //for (int index = 0; index < 6; index++)
            //{
            //    Console.WriteLine($"Default value {die2Face[index]}  Assigned value" +
            //        $" {die3Alternative[index]}  Face Name {dieFaceName[index]}" +
            //        $" data at index {index}");
            //}

            string inputTemp = "n";
            //Random rnd = new Random();
            //do
            //{
            //    //die3Face and dieFaceName are arrays
            //    //Remember that arrays names actually are addresses to where
            //    //  the physical data is located
            //    //This means the value actually passed to the method is
            //    //  NOT a copy of the physical data BUT a copy tothe address
            //    //  of where the physical data is located
            //    Roll(die3Face, dieFaceName, rnd);
            //    Console.Write("Roll the dice (y,n)?\t");
            //    inputTemp = Console.ReadLine();
            //} while (inputTemp.ToLower().Equals("y"));

            //Create an array to hold ten names
            string[] Names = new string[10];
            //create a counter to indicate how many names are in the array
            //this variable does a "natural" count (1, 2, 3...)
            int logicalSize = 0;
            bool stop = false;
            while (logicalSize < 10 && !stop)
            {
                logicalSize = GetName(Names, logicalSize);
                Console.Write("Enter another name (y/n)?\t");
                inputTemp = Console.ReadLine();
                if (inputTemp.ToLower().Equals("n"))
                {
                    stop = true;
                }
            }
            for (int index = 0; index < logicalSize; index++)
            {
                Console.WriteLine($"Name at [{index}] is {Names[index]}");
            }
        }//eo Main

        static int GetName(string[] NameLocal, int logicalSizeLocal)
        {
            Console.Write("Enter a name:\t");
            //logicalSizeLocal is playing the role of the next available array
            //  element for storage, so "acting" as an index
            NameLocal[logicalSizeLocal] = Console.ReadLine();
            logicalSizeLocal++;
            return logicalSizeLocal;
        }
        static void Roll(int[] die3FacePointer, string[] dieFaceNamePointer, Random rnd)
        {
            //die3FacePointer and dieFaceNamePointer data values are addresses
            //  to the actually physical data in the array
            //this is DIFFERENT than passing a simply variable (int, double, bool, ..)
            //  where the atucal physical data was copied and sent to the method
            //  parameter

            //SO, WHAT IS THE "BIG" DEAL

            //When using a simple variable within the method, you are working on a
            //  COPY of the original data. THUS any changes to the copy DOES NOT
            //  affect (no change to) the original data from the calling statement.

            //HOWEVER

            //Since the value that is passed for an array is an address, ANY alternation
            //  to data at the address, changes the physical data.
            //WARNING: if you alter the contents of your array element, you alter
            //  the contents of the physical data in memory. THEREFORE, when you
            //  return to the calling statement, ANY changes to the array while in the
            //  method will be present in the array at the calling statement.

            //remember faces are 1-6
            //however, indexes are 0-5
            //random upper limit is non inclusive, therefore range must be 0-6
            //the random number represents the index of the array
            int rollValue = rnd.Next(0, 6);
            Console.WriteLine($"You rolled a {die3FacePointer[rollValue]} ({dieFaceNamePointer[rollValue]})\n");
        }
    }
}
