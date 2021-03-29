using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class Opening
    {
        //private members
        private double _Width;
        private double _Height;

        //properties
        //fully implemented property
        public double Width
        {
            //accessor
            get { return _Width; }
            set { _Width = value > 0 ? value : throw new Exception("Width is invalid"); }
        }

        public double Height
        {
            //accessor
            get { return _Height; }
            //mutator
            set { _Height = value > 0 ? value : throw new Exception("Height is invalid"); }
        }

        //auto implemented property
        public string Description { get; set; }

        //constructor
        //default
        public Opening()
        {
            Width = 3.0;
            Height = 2.5;
        }
        //greedy
        public Opening(double width, double height, string description)
        {
            Width = width;
            Height = height;
            Description = description;
        }

        //behaviour (aka method)
        public double OpeningArea()
        {
            //note no parameters were set up
            //WHY?
            //  the method can eccess the data within the instance
            //  by using either the Properties or the private data member
            //GOOD RULE OF THUMB properties over dta members
            return Width * Height;
        }
    }
}
