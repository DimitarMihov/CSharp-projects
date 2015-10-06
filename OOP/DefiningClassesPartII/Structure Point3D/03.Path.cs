/* Task 4 - 1
 * Create a class Path to hold a sequence of points in the 3D space.
*/


using System;
using System.Collections.Generic;


public class Path
{
    public static void Main()
    {
        Console.WriteLine("Hi there!\nThis is the first parth of the homework.\nThere are some points stored in a text file in /TestFile directory.\n" +
                            "If you want to enter other points manually,\nplease, delete the file \"Source.txt\"!\n");
        List<Point3D> path = new List<Point3D>();
        path = PathStorage.LoadPath();
        if (path != null)
        {
            foreach (var item in path)
            {
                string asString = String.Format(
                "3D point with coordinates" +
                " X = {0,3:d}, Y = {1,3:d}, Z = {2,3:d}",
                item.X, item.Y, item.Z
                );
                Console.WriteLine(asString);
            }

            Console.WriteLine();
        }
        else
        {
            path = GetPath();
        }

        PathStorage.SavePath(path);
        CalculateDistanceIn3DPoint.CalculateDistance3D(path);

    }
    
    private static List<Point3D> GetPath()
    {
        List<Point3D> points = new List<Point3D>();
        string key = "y";
        while (key == "y" || key == "Y")
        {
            Console.Write("Please, enter new point in 3D space with coordinates X, Y, Z: ");
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());
            int pointZ = int.Parse(Console.ReadLine());

            Point3D point = new Point3D();
            point.X = pointX;
            point.Y = pointY;
            point.Z = pointZ;

            points.Add(point);
            Console.Write("Add another point? y/another key: ");
            key = Console.ReadLine();
        }

        return points;
    }

    //public override string ToString()
    //{
    //    return asString;
    //}
}

