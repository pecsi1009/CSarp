/*
4.Create a class Path to hold a sequence of points in the 3D space. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point3DMain 
{
    class Path
    {
        public List<Point3D> path = new List<Point3D>();
        
        public List<Point3D> Paths
        {
            get
            {
                return this.path;
            }
            private set
            {
                this.path = value;
            }
        }
        public void AddPoint(Point3D point)
        {
            Paths.Add(point);
        }
        public void PrintPathList()
        {
            foreach (var p in path)
            {
                Console.WriteLine("({0},{1},{2})", p.X, p.Y, p.Z);
            }
        }
    }
}
