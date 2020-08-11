
using System;
using System.Collections.Generic;

namespace Services
{
    public class PrintService<T>
    {
        private List<T> _values = new List<T>();

        public PrintService() { }

        public void AddValue(T value)
        {
            if (_values.Count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            _values.Add(value);
        }

        public T First()
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
            foreach (T value in _values)
            {
                Console.Write($" {value} ");
            }
            Console.Write("]");
        }
    }
}
