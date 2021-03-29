using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class Wall
    {
        //private members
        private double _Width;
        private double _Height;

        //properties
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

        //constructor
        //default
        public Wall()
        {
            Width = 10.0;
            Height = 8.0;
        }
        //greedy
        public Wall(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //behaviour (aka method)
        public double WallArea()
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
