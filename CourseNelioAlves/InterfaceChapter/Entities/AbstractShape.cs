
using Entities;
using Enums;

namespace Entities
{
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
