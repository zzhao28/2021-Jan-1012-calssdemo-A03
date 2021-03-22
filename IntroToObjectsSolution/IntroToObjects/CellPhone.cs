using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToObjects
{
    class CellPhone
    {
        #region Data Member
        //Data Members
        private int _Photos;
        private string _Contacts;
        private string _ContactNumbers;
        private string _Apps;
        #endregion

        #region Properties
        //Properties
        //both Fully and Auto implemented properties
        public int Photos
        {
            get { return _Photos; }
            set { _Photos += value; }
        }

        public string Contacts
        {
            get { return _Contacts; }
            set { _Contacts = string.IsNullOrEmpty(value) ? null : value; }
        }

        public string ContactNumbers
        {
            get { return _ContactNumbers; }
            set { _ContactNumbers = value; }
        }

        public string Apps
        {
            get { return _Apps; }
            set { _Apps += value; }
        }

        public string Emails { get; set; }

        #endregion

        #region Constructor
        //Constructors
        public CellPhone(int photos, string contacts, string contactnumbers, string apps, string emails)
        {
            Photos = photos;
            Contacts = contacts;
            ContactNumbers = contactnumbers;
            Apps = apps;
            Emails = emails;
        }
        #endregion

        #region Behaviour
        //Behaviour
        #endregion
    }
}
