using System;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  process
             * 
             * this program will demonstrate methods, menu looping and various styles of File I/O
             * 
             * create a post-loop (do/while) to handle the menu
             *      the menu will have 3 options, one for each type of File I/O style
             *      
             * methods will be used to obtain the file name to be read for this program
             *      the methods will have no incoming parameter, will return a string datatype
             *      
             * the reading and display of the file will be placed in a separate method
             *      the method will have a string incoming parameter,
             *      the method will not return anything (void datatype),
             *      the method demonstrate error handling using Try/Catch/Final
             *      
             */

            string inputTemp;

            //post loop structure, used to control menu
            do
            {


                Console.WriteLine("File I/O options:");
                Console.WriteLine("a) Hard-coded file name.");
                Console.WriteLine("b) Using Windows Environment (Desktop, Documents, Download) path file name.");
                Console.WriteLine("c) Using Openfile dialog to obtain file name.");
                Console.WriteLine("x) Exit.\n");
                Console.Write("Enter the menu option for File I/O");
                inputTemp = Console.ReadLine();
                switch(inputTemp.ToUpper())
                {
                    case "A":
                        {
                            break;
                        }
                    case "B":
                        {
                            break;
                        }
                    case "C":
                        {
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Have a nice day.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"{inputTemp} is not a valid menu option. Try again.");
                            break;
                        }



                }

            } while (inputTemp.ToUpper() != "X");
            

            
        }
    }
}
