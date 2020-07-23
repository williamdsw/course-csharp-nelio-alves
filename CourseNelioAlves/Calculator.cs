using System;
using System.Collections.Generic;
using System.Text;

namespace CourseNelioAlves
{
    class Calculator
    {
        public static double Circumference(double radius)
        {
            return 2.0 * Math.PI * radius;
        }

        public static double Volume(double radius)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
}
