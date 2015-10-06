/*Task 2
 * Add a private static read-only field to hold the start of the coordinate system –
 *the point O{0, 0, 0}. Add a static property to return the point O.
 *
 * Task 3
 * Write a static class with a static method to calculate the distance between two points in the 3D space.
 */

using System;
using System.Collections.Generic;


static class CalculateDistanceIn3DPoint
{
    
    private static readonly int[] zeroPoint = new int[] { 0, 0, 0 };

    public static int[] ZeroPoint
    {
        get
        {
            return zeroPoint;
        }
    }

    private static double distance;

    public static void CalculateDistance3D(List<Point3D> points)
    {
        double distance;
        List<int[]> coordinates = new List<int[]>();

        if (points.Count < 2)
        {
            Console.WriteLine("Cannot calculate distance, because at least two points are needed!");
            return;
        }

        while (points.Count > 0)
        {
            int[] coord = new int[3];
                coord[0] = points[0].X;
                coord[1] = points[0].Y;
                coord[2] = points[0].Z;
                points.RemoveAt(0);
                
            coordinates.Add(coord);
            if (coordinates.Count >= 2)
            {
                distance = Math.Sqrt(Math.Pow((coordinates[1][0] - coordinates[0][0]), 2) +
                                    Math.Pow((coordinates[1][1] - coordinates[0][1]), 2) +
                                    Math.Pow((coordinates[1][2] - coordinates[0][2]), 2));

                Console.WriteLine("The distance between points is {0}", distance);
                coordinates.RemoveAt(0);
            }
            
        }

        Console.WriteLine("There is no more points to calculate!");
    }


    
}

