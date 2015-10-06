using System;

namespace Abstraction
{
    class FiguresExample
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            double circlePerimeter = circle.CalcPerimeter();
            double circleSurface = circle.CalcSurface();

            Console.WriteLine("I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.", circlePerimeter, circleSurface);

            Rectangle rectangle = new Rectangle(2, 3);
            double rectanglePerimeter = rectangle.CalcPerimeter();
            double rectangleSurface = rectangle.CalcSurface();

            Console.WriteLine("I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.",
                rectanglePerimeter, rectangleSurface);
        }
    }
}
