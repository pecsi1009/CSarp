/* -----------------------------------------------------------------------
    Define abstract class Shape with only one abstract method CalculateSurface() and fields width and 
height.
 -----------------------------------------------------------------------*/

namespace ProgramForShapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Shape
    {
        //fields and properties
        protected double Width {get; set;}
        protected double Height {get; set;}

        // empty  method
        public abstract double CalculateSurface();
    }
}
