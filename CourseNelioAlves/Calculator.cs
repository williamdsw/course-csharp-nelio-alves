using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

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

        public static int Sum (params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static void Triplicate (ref int number)
        {
            number *= 3;
        }
        
        public static void Triplicate (int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
