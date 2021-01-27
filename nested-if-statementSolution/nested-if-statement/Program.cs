using System;

namespace nested_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nested if Statement");

            //const double MINWAGEAMOUNT = 30000.00;
            //const int MINYEARSWORKED = 2;
            //double annuallyEarning = 35000.00;
            //int yearWorked = 3;
            //if (annuallyEarning < MINWAGEAMOUNT)
            //{
            //    if (yearWorked < MINYEARSWORKED)
            //    {
            //        Console.WriteLine("Not qualified for loan due to wages and years worked");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not qualified for loan due to low wages");
            //    }
            //}
            //else 
            //{
            //    if (yearWorked > MINYEARSWORKED)
            //    {
            //        Console.WriteLine("Are qualified for loan");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not qualified for loan due to not enough years worked");
            //    }
            //}

            //int testScore;

            ////coded using IF - ELSE IF
            //if (testScore < 50)
            //{
            //    Console.WriteLine("Yuor grade is F.");
            //}
            //else if (testScore < 60)
            //{
            //    Console.WriteLine("Yuor grade is D.");
            //}
            //else if (testScore < 70)
            //{
            //    Console.WriteLine("Yuor grade is C.");
            //}
            //else if (testScore < 80)
            //{
            //    Console.WriteLine("Yuor grade is B.");
            //}
            //else
            //{
            //    Console.WriteLine("Yuor grade is A.");
            //}//eo IF structure

            //Weather Translation
            string inputTemp = "";
            int fahrenheitTemp = 0;
            int celsiusTemp;

            Console.Write("Enter the temperature in Fahrenheit:\t");
            inputTemp = Console.ReadLine();
            fahrenheitTemp = int.Parse(inputTemp);
            celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
            if (celsiusTemp < 0)
            {
                Console.WriteLine($"Your Temperature is {celsiusTemp} and it\'s freezing out!");
            }
            else if (celsiusTemp < 15)
            {
                Console.WriteLine($"Your Temperature is {celsiusTemp} and go wear a jacket!");
            }
            else if (celsiusTemp < 30)
            {
                Console.WriteLine($"Your Temperature is {celsiusTemp} and it\'s a lovely day!");
            }
            else
            {
                Console.WriteLine($"Your Temperature is {celsiusTemp} and it\'s finally summer!");
            }

        }//eoMain
    }//eop
}//eon
