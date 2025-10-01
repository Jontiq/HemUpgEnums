using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemUpgEnums
{
    internal class Rectangle
    {
        //props
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area 
        { 
            get
            {
                return Width * Height;
            }
        }
        //constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //methods
    }
}
