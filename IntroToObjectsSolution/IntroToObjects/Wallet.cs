using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToObjects
{
    //public access allows outside users access to the class
    //who is the "outside user"?
    //  the outside user is anything NOT in the class
    public class Wallet
    {
        //data members
        //  a data member is a piece of data
        //  the data needs to be valid datatype
        //  Typically, these variables are private to the class
        private double _CashBills;
        private double _CashCoins;
        private string _DriverLicense;
        private string _BankCard;

        //Properties
        //  each data member that you wish to ex[pse tp the outside user
        //      will typically has its OWN property
        //  each property is public
        //  each property has the option of 
        //      a) reading the private data member (get)
        //      b) assigning a value to the private data member (set)
        //          is the likely option that an outside user does not has access to
        //syntax:
        //  for a Fully Implementted Property
        //  when to use:
        //      a) if you plan on saving the data to your own private data member
        //      b) if you have to do ANY programing before returning the private data member to the outside user
        //      c) if you have to do ANY programing before assigning the incoming data to your private data member (validation)
        //   public datatype propertyname
        //   {
        //      get { .....}
        //      [set {......}]
        //          on the set, your incoming data is referenced using the keyword: value
        //   }
        public string DriverLicense
        {
            get { return _DriverLicense; }
            set { _DriverLicense = value; }
        }
        //  for an Auto Implemented Property
        //  when to use:
        //      id there is NO addtional processing needed for the data cominng in or going out.
        //  NOTE: when you use auto implemented properties you DO NOT create your OWN private
        //          data member
        //        instead, the system, ON YOUR BEHAVE, will create a storage area for the data, will put the value in this
        //          this area for you, will retrieve the data for you.
        //syntax
        //  public datatype propertyname {get; set;}

        public string GasCard { get; set; }
        public string VisaCard { get; set; }

        //Fully Implemented Property examples
        public double CashBills
        {
            get { return _CashBills; }
            set { _CashBills += value; }
        }
        public double CashCoins
        {
            get { return _CashCoins; }
            set { _CashCoins += value; }
        }
        public string BankCard
        {
            get { return _BankCard; }
            set { _BankCard = string.IsNullOrEmpty(value) ? null : value; }
        }
    }
}
