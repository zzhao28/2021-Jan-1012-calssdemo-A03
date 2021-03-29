using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    //Composite Class
    //  a composite class contains references to other classes
    //  the reference may be a single instance or within a List<T>
    public class Room
    {
        private string _Color;
        public string Name { get; set; }
        public string color
        {
            get { return _Color; }
            set { _Color = string.IsNullOrEmpty(value) ? "White" : value; }
        }

        public List<Wall> Walls { get; set; }

        public List<Opening> Openings { get; set; }

    }
}
