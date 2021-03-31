﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    //Composite Class
    //  a composite class contains references to other classes
    //  the reference may be a single instance or within a List<T>
    public class Room
    {
        //data members are simply fields to hold data
        private string _Color;
        private List<Opening> _Openings;
        public string Name { get; set; }
        public string color
        {
            get { return _Color; }
            //the keyword value in this example is a datatype of string
            //the mutator validation does a default setting.
            set { _Color = string.IsNullOrEmpty(value) ? "White" : value; }
        }

        public List<Wall> Walls { get; set; }

        public List<Opening> Openings
        {
            get { return _Openings; }
            set 
            { 
                //the keyword value in this example is a datatype of List<T>
             if (value.Count == 0)
                {
                    //the mutator validation throw an error
                    throw new Exception("Your room needs at least one opening.");
                }
                else
                {
                    _Openings = value;
                }
            }
        }

        //NOTE: no constructors were created for this class.
        //When an instance of this class is created, the system will use the
        //  "system default constructor"

    }
}
