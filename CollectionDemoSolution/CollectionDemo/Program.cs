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
            //declare a List<T>
            List<int> setOfNumbers = new List<int>();
            //add element to a list

            setOfNumbers.Add(55);
            //setOfNumbers.Add(41);
            setOfNumbers.Add(100);

            WriteLine($"The list contains {setOfNumbers.Count} elements");



        }
    }
}
