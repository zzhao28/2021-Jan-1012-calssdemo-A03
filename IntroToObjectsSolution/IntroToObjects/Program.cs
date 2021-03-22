using System; //indicating a namespace


namespace IntroToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a variable
            //datatype and name
            //optionally you can assign a value to the variable as it is created.
            string inputTemp = null;

            //what about developer defined datatypes
            //the class name is used as the datatype
            //
            //declaring a variable of the developer datatype class
            //  sets aside a physical area in memory to hold the
            //  address location of the actual instance of the class
            //default of these variables is null
            Wallet myWallet = null;

            //how does one get an instance (occurance) of my class
            //the instance is referred as the object
            //the instance is a physical thing
            //the new command executes the constructor of your class

            myWallet = new Wallet();  //signature of the Default constructor

            Console.WriteLine($"cash {myWallet.CashBills + myWallet.CashCoins}");

            Wallet herWallet = new Wallet();

            Console.WriteLine($"cash {herWallet.CashBills + herWallet.CashCoins}");

            //signature of the Greedie constructor

            Wallet hisWallet = new Wallet(10,2,"ADDR1234",null,null,null);

            Console.WriteLine($"cash {hisWallet.CashBills + hisWallet.CashCoins}");

            //assigning a value to my instance using the property
            //instance is on the left side of an assignment statement
            //property is using the "set" 
            myWallet.CashCoins = 13;

            //access to the instance is using the preperties
            //the instance is on the right side of an assignment statement
            //property is using the "get"
            double addedNumbers = myWallet.CashBills + myWallet.CashCoins;

            Console.WriteLine($"cash {addedNumbers}");
        }
    }
}
