/* -----------------------------------------------------------------------
    Define class Circle and suitable constructor so that at initialization height must be kept equal to
width and implement the CalculateSurface() method. 
--------------------------------------------------------------------------*/

namespace ProgramForShapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Circle : Shape
    {
        //field
        public double Width { get; set; }
        public double Height { get; set; }

        //constructor
        public Circle(double width, double height) 
            : base (width, height)
        {
            if (Width != Height)
            {
                throw new Exception("Width must be equal of height");
            }
        }

        // method
        public override double  CalculateSurface()
        {  
            double surface = Math.PI * Math.Pow(Width,2);
            return surface; 
        }
    }
}
