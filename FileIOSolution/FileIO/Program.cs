using System;
using System.IO; // clarifies the requirement for File I/O

namespace FileIO
{
    class Program
    {
        [STAThread]
        //Main() is a method
        // special method
        // entry point into your program execution
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
            string FullFilePathName = "";

            //post loop structure, used to control menu
            do
            {
                Console.WriteLine("File I/O options:");
                Console.WriteLine("a) Hard-coded file name.");
                Console.WriteLine("b) Using Windows Environment (Desktop, Documents, Download) path file name.");
                Console.WriteLine("c) Using Openfile dialog to obtain file name.");
                Console.WriteLine("x) Exit.\n");
                Console.Write("Enter the menu option for File I/O\t");
                inputTemp = Console.ReadLine();
                switch(inputTemp.ToUpper())
                {
                    case "A":
                        {
                            //Hard coded file-name
                            //
                            // the calling statement
                            //
                            // [receiving variable =] MethodName([List of argument]);
                            //
                            // on the calling statement your method's list of parameters
                            //      are property referred to as "list of argument"
                            FullFilePathName = HardCodedFileName();
                            break;
                        }
                    case "B":
                        {
                            FullFilePathName = WindowEvironmentFileName();
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
                //Console.WriteLine($"your full path name is {FullFilePathName}");

                //pass a argument value into a method
                if (!inputTemp.ToUpper().Equals("X"))
                {
                    //a calling statement which is supplying a single argument value
                    //      to the method.
                    //there is NO assignment operator which indicates a) nothing is
                    //      being returned from the method OR b) a logic desicion has
                    //      been made to ignore any returned value
                    ProcessFile(FullFilePathName);
                }
            } while (inputTemp.ToUpper() != "X");
             
        }
        /*  Methods
         * 
         * Why????
         *      reduce code redundancy
         *      break up your code into smaller managable pieces (modularization)
         *      
         * Where do methods go?
         *      methods go into your program class
         *      
         * Syntax for a method
         *     accesstype returndatatype MethodName([list of parameters])
         *     {
         *         coding block
         *     }
         *     
         *     accesstype?
         *     This is dependant on what is the Main access type or if the
         *          class is NOT the entry point to your entire application,
         *          could be public, private, internal, protected,..
         *          
         *     returndatatype
         *     Methods have been called by many names
         *     Methods have been called subroutines, functions, methods
         *     Subroutines and functions are different in that subroutines return
         *          no data to the calling statement; whereass functions will return
         *          data to the calling statement.
         *     the return datatype must be a valid language datatype
         *     the return datatype in C# that returns nothing is the keyword void
         *     
         *     MethodName
         *     This is what the method is called
         *     The method name is usually unique
         *     The method names that are not uniques are paired with their list of
         *         parameters to create a method signature. The method signature
         *         MUST be unique. This is referred to as overload methods.
         *          
         *     [list of parameters]     
         *     What is a parameter?
         *     datatype parametername
         *     consider the parameter a variable within your method that has
         *          already been declare and can be used as other variables
         *     datatype parametername
         *     
         *     What is a list of parameters?
         *     datatype parametername, datatype parametername, .....
         */
        static string HardCodedFileName()
        {
            //ANY locally create variables ARE DESTROYED when the method TERMINATES
            //local variables have "scope" to the method they exist in
            
            //setup a path name to the folder on your machine that contains
            //   the file to be read
            string Folder_Pathname = @"F:\GitHub\CPSC-1012\FileProcessing\";

            //concatenate a file name to the pathname
            string Full_Path_FileName;
            Full_Path_FileName = Folder_Pathname + @"OneColumn.txt";

            //BECAUSE the method indicates a returned datatype of string (anything
            //      but void), the method REQUIRES a return xxxx; statement
            //the returned value is a physical copy of contents of the variable
            //      on the statement
            //You may return ONLY one value.
            return Full_Path_FileName;
        }

        static string WindowEvironmentFileName()
        {
            //Using Environment.GetFolderPath allows the program to get to the
            //  special folders of your Windows file system (Desktop, Documents, Download,..)
            string myMachinePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if you have a folder structure on your Desktop where the file is located
            //   then add that path to the MachinePath
            myMachinePath += @"\CPSC1012-FileIO\";
            //Add the actual file name to the Full path
            string Full_Path_FileName;
            Full_Path_FileName = myMachinePath + @"OneColumn.txt";
            return Full_Path_FileName;
        }

        static void ProcessFIle(string paramFullFilePathName)
        {
            //the parameter on the method head SHOULD be treated as a local variable
            //DO NOT redeclare parameter variable as local variables
            //If your parameter variable is a VALUE type variable then the name
            //  given to the passing of data into this method is called "Pass By Value"

            //Pass By Value
            //a physical copy of the data from the call statement is passed into
            //  the parameter variable

            //Read the contents of a single column record from a file
            //The number of records on the file is unknown
            //Include User Friendly Error handling

            int records = 0;

            //StreamReader is used to create a "pipeline" to your physical file
            //The streamReader is one of the System.IO classes
            //your needs to create (request) an "instance" of the class
            //syntax is datatype (classname) StreamReader
            //creating the instance: new theclassname([list of parameters])
            //      the parameter required is the complete file path name
            StreamReader reader = new StreamReader(paramFullFilePathName);

            //User Friendly Error handling
            //use the structure called Try/Catch[/Finally]
            //syntax structure
            //try
            //{
            //    coding to try and execute
            //}
            //catch (Exception ex)
            //{
            //    code use to handle the run time error
            //}
            //[finally
            //{
            //    code to execute whether there is no error or if there was an error
            //}]
            try
            {
                //logic of your program
                string readline = "";
                //read the first record from your StreamReader pipeline
                readline = reader.ReadLine();
                //your program will know when you have reached the end of the file
                //   when it receives a null value from the string reader method .ReadLine()
                //user pre-test loop
                while (readline != null)
                {
                    //a line has been returned from the physical file
                    records++;
                    Console.WriteLine($"Contents of file record\t{readline}");
                    //read the next line in the file
                    readline = reader.ReadLine();
                }
                Console.WriteLine($"\nYou read{records} records");
            }
            catch (Exception ex)
            {
                //display a message indicating the problem
                Console.WriteLine($"You had a problem reading the file. \nError:\t{ex.Message}");
            }
            finally
            {
                //due to the fact that we are reading a file
                //the file must be closed when you have finished reading all that you
                //  desire
                reader.Close();
            }
        }
    }
}
