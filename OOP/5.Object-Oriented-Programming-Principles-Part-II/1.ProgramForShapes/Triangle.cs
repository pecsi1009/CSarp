/* -----------------------------------------------------------------------
    Define two new classes Triangle and Rectangle that implement the virtual method and return the surface
of the figure (height*width for rectangle and height*width/2 for triangle). 
--------------------------------------------------------------------------*/

namespace ProgramForShapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Triangle : Shape
    {
        //fields
        public double Width { get; set; }
        public double Height { get; set; }

        //constructor.We need it, because class must have some argument, or give error.
        public Triangle(double width, double height)
            : base (width, height)
        {
        }

        //method
        public override double CalculateSurface()
        {
            double surface = (this.Width * this.Height) / 2;
            return surface;
        }

    }
}
