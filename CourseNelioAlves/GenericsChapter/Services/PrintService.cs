
using System;
using System.Collections.Generic;

namespace Services
{
    public class PrintService
    {
        private List<int> _values = new List<int>();

        public PrintService() { }

        public void AddValue(int value)
        {
            if (_values.Count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            _values.Add(value);
        }

        public int First()
        {
            if (_values.Count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }

            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            foreach (int value in _values)
            {
                Console.Write($" {value} ");
            }
            Console.Write("]");
        }
    }
}
