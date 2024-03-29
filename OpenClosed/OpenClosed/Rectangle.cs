﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle (double width,double height)
        {
            Width = width;
            Height = Height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
