using System;
using System.Collections.Generic;
using System.Text;

namespace CourseNelioAlves
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getA()
        {
            return this.a;
        }

        public void setA(double a)
        {
            this.a = a;
        }
        public double getB()
        {
            return this.b;
        }

        public void setB(double b)
        {
            this.b = b;
        }
        public double getC()
        {
            return this.c;
        }

        public void setC(double c)
        {
            this.c = c;
        }

        public double GetArea ()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
