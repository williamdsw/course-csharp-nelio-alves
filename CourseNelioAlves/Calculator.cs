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

        public static int Sum (int n1, int n2)
        {
            return n1 + n2;
        }
        
        public static int Sum (int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        
        public static int Sum (int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

        /*
        public static int Sum (int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
        */

        public static int Sum (params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
