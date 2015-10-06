using System;

namespace CohesionAndCoupling
{
    public class Figure2D
    {
        private double width;
        private double height;

        public Figure2D(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get 
            { 
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than zero!");
                }
                 
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than zero!");
                }

            }
        }

        public double CalcDiagonalXY()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, Width, Height);
            return distance;
        }
    }
}
