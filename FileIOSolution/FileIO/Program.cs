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
                inputTemp = MenuPrompt();   //a method containing the menu prompts
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
                    case "C":
                        {
                            WriteToFile();
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
                if (!(inputTemp.ToUpper().Equals("X") || inputTemp.ToUpper().Equals("C")))
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
            //Full_Path_FileName = Folder_Pathname + @"OneColumn.txt";
            //Full_Path_FileName = Folder_Pathname + @"TwoColumn.txt";
            //Full_Path_FileName = Folder_Pathname + @"VariableColumns.txt";
            Full_Path_FileName = Folder_Pathname + @"NewFile.txt";

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

        static void ProcessFile(string paramFullFilePathName)
        {
            //the parameter on the method header SHOULD be treated as a local variable
            //DO NOT redeclare parameter variable as local variables
            //If your parameter variable is a VALUE type variable then the name
            //   given to the passing of data into this method is called "Pass By Value"

            //Pass By Value
            //a physical copy of the data from the call statement is passed into
            //    the parameter variable

            //Read the contents of a single column record from a file
            //The number of records on the file is unknown
            //Include User Friendly Error handling

            int records = 0;

            //StreamReader is used to create a "pipeline" to your physical file
            //The StreamReader is one of the System.IO classes
            //your needs to create (request) an "instance" of the class
            //syntax is datatype (classname) StreamReader
            //creating the instance: new theclassname([list of parameters])
            //    the parameter required is the complete file path name
            StreamReader reader = null;

            //User Friendly Error handling
            //use the structure called Try/Catch[/Finally]
            //syntax structure
            //try
            //{
            //   coding to try and execute
            //}
            //catch (Exception ex)
            //{
            //   code use to handle the run time error
            //}
            //[finally
            //{
            //  code to execute whether there is no error or if there was an error
            //}]
            try
            {
                reader = new StreamReader(paramFullFilePathName);

                //logic of your program
                string readline = "";
                //read the first record from your StreamReader pipeline
                readline = reader.ReadLine();
                //your program will know when you have reached the end of the file
                //   when it receives a null value from the StreamReader method .ReadLine()
                //use pre-test loop
                while (readline != null)
                {
                    //a line has been returned from the physical file
                    records++;
                    Console.WriteLine($"\nContents of file record\t{readline}");

                    //this code demonstrates a technique to handle multiple values
                    //      on a single record which are separated by the comma character.
                    //this technique uses
                    //      a) the string method .Split('delimiter')
                    //      b) the pre-test loop called foreach()
                    // a file with records containing multiple value separated by a comma
                    //      is often referred to as  CSV file (Comma Separate Values)
                    int columnCounter = 0;
                    //the foreach loop is nice because
                    //      a) handles an unknown number of times for looping
                    //      b) the while condition is embedded within the loop and is
                    //             handled as "is there any more to do?"
                    //      c) stops automatically if there is no more to do
                    //      d) the "item" (data) to process is localed in the local loop
                    //             variable declare in the foreach syntax. In this example
                    //             the local loop variable is string value
                    //      e) the "in" variable sepecifies the data source location
                    foreach(string value in readline.Split(','))
                    {
                        columnCounter++;
                        Console.WriteLine($"Column {columnCounter} contains the value {value}");
                    }

                    //read the next line in the file
                    readline = reader.ReadLine();
                }
                Console.WriteLine($"\nYou read {records} records");
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
                //   desire
                reader.Close();
            }
        }

        static string MenuPrompt()
        {
            string inputTempLocal = "";
            Console.WriteLine("File I/O options:");
            Console.WriteLine("a) Hard-coded file name.");
            Console.WriteLine("b) Using Windows Environment (Desktop, Documents, Download) path file name.");
            Console.WriteLine("c) Using Openfile dialog to obtain file name.");
            Console.WriteLine("x) Exit.\n");
            Console.Write("Enter the menu option for File I/O\t");
            inputTempLocal = Console.ReadLine();
            return inputTempLocal;
        }

        static void WriteToFile()
        {
            string PathName = @"F:\GitHub\CPSC-1012\FileProcessing\";
            string FullPathName = PathName + @"NewFile.txt";
            // the "pipeline" variable to the output file
            StreamWriter writer;

            // create the pipeline
            //  a) the file path name
            //  b) a true or false indicate type of appending
            //      true: append to an existing file or create the file if it does not exist
            //      false: recreate the file as a new file (overwrite of existing file if the
            //             file exists)
            try  //user friendly error handling
            {
                writer = new StreamWriter(FullPathName, false);
                Random rnd = new Random(); //setting up the random number generate variable
                int linesout = rnd.Next(1, 6); //desire numbers 1 through 5
                for (int looper = 0; looper < linesout; looper++)   //fixed number of iterations
                {
                    //writing a line to your file
                    // NOTE: the \n at the end of the string to force the next line in the file
                    writer.Write($"line {looper}, terry\n");
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nError: {ex.Message}\n\n");
            }

        }
    }
}
