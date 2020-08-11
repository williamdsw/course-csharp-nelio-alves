
using Enums;

namespace Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
