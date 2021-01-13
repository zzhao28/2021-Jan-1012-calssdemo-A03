using System;

namespace FirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // the WriteLine() command will output the
            //    the to the console window.
            Console.WriteLine("Hello World!");
            Console.WriteLine("This course section is:\tOA03");
            Console.WriteLine("Your instructor name is:\t Don Welch");

            string myName = "Don Welch";
            Console.WriteLine($"This name is printed from a variable is:\t{myName}");
        }
    }
}
