
using System;

namespace Entities
{
    public class Musician : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Musician(string csv)
        {
            string[] values = csv.Split(",");
            if (values.Length == 2)
            {
                Name = values[0];
                Age = int.Parse(values[1]);
            }
        }

        public override string ToString()
        {
            return $"{Name} is {Age} years old!";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Musician))
            {
                throw new ArgumentException("Comparing error: argument is not an Musician");
            }

            Musician other = obj as Musician;
            return Age.CompareTo(other.Age);
        }
    }
}
