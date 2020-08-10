using System;

namespace CourseNelioAlves.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        { }
    }
}
