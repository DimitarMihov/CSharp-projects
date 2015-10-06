using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", DistanceUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", DistanceUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D thriDimensionalFigure = new Figure3D(5, 3, 4);
            Console.WriteLine("Volume = {0:f2}", thriDimensionalFigure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", thriDimensionalFigure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", thriDimensionalFigure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", thriDimensionalFigure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", thriDimensionalFigure.CalcDiagonalYZ());
        }
    }
}
