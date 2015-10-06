using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Distance
    {
        public static double Calculate(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static bool CheckPlane(double x1, double x2)
        {
            bool inSamePlane = false;

            if (x1 == x2)
            {
                inSamePlane = true;
            }

            return inSamePlane;
        }
    }
}
