/*
 3.Write a static class with a static method to calculate the distance between two points in the 3D space.
 */

using System;
using System.Linq;
using Point3DMain; 

static class CalculateDistance
{

    static double CalculatedDistance(Point3D firstPoint, Point3D secondPoint)
    {
        double calculatedDistance = ((firstPoint.X-secondPoint.Y)^2 + (firstPoint.Y-secondPoint.Y)^2 + (firstPoint.Z-secondPoint.Z)^2)^(1/2);
        return calculatedDistance;
    }
}

