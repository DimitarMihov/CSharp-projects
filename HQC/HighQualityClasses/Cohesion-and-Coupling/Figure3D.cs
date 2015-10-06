using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class Figure3D : Figure2D
    {
        private double depth;

        public Figure3D(double depth, double width, double height) : base(width, height)
        {
            this.Depth = depth;
        }

        public double Depth
        {
            get
            {
                return depth;
            }
            set
            {
                if (value > 0)
                {
                    depth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Depth must be greater than zero!");
                }

            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = DistanceUtils.CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = DistanceUtils.CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }
        
    }
}
