/*
    1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing
a 3D point.
    2.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property 
to return the point O.
    11.Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version
in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point3DMain
{
    struct Point3D      // create a struct called Point3D - (task 1)
    {
        private double X{get; set;}
        private double Y{get; set;}
        private double Z{get; set;}

        private static readonly Point3D pointZero = new Point3D(0,0,0);  //create private static readonly field to hold the start of the coordinate system – the point O{0, 0, 0} - task 2

        public Point3D(double x, double y, double z)
        {
            this.X=x;
            this.Y=y;
            this.Z=z;
        }

        static Point3D ReturnPointZero        //Add a static property to return the point O - task 2
        {
            get{return pointZero;} 
            set{ pointZero=value; }
        }

        public override string  ToString()      // convert int (X,Y,Z) in ToString() - (task 1)
        {
 	        string pointAsString = string.Format("{{0}, {1}, {2}}", this.X,this.Y,this.Z);
            return pointAsString;
        }


        static void Main()
        {
            Point3D firstPoint = new Point3D(2,4,5);
            Point3D secondPoint = new Point3D(1,4,5);
        }
    }
}
