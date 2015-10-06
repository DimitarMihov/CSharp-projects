/*Task 4 - 2
 *Create a static class PathStorage with static methods to save and
 *load paths from a text file. Use a file format of your choice.
 */


using System;
using System.Collections.Generic;
using System.IO;


static class PathStorage
{
    static string dirPath = @"..\..\..\TestFiles\";
    static string file = @"\Source.txt";

    public static List<Point3D> LoadPath()
    {
        try
        {
            List<Point3D> points = new List<Point3D>();
            StreamReader load = new StreamReader(dirPath + file);
            using (load)
            {
                string line = load.ReadLine();

                while (line != null)
                {
                    int[] point = new int[3];
                    string[] elements = line.Split(new char[] { ';' });
                    for (int i = 0; i < 3; i++)
                    {

                        string element = elements[i].ToString();
                        element = element.Trim();
                        point[i] = int.Parse(element);

                    }

                    Point3D point3d = new Point3D();
                    point3d.X = point[0];
                    point3d.Y = point[1];
                    point3d.Z = point[2];

                    points.Add(point3d);
                    line = load.ReadLine();
                }
            }

            return points;
        }
        catch (FileNotFoundException)
        {
            
            //If File does not exsist,it will be created at the end.
            return null;
        }
        catch
        {
            Console.WriteLine("Fatal error! Do not panic, leave slowly!");
            return null;
        }
    }

    public static void SavePath(List<Point3D> points)
    {
        StreamWriter save = new StreamWriter(dirPath + file);
        using (save)
        {
            foreach (var item in points)
            {
                string newLine = item.X+";"+item.Y+";"+item.Z;
                save.WriteLine(newLine);
            }
        }
    }

}

