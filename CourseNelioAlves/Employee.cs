
namespace CourseNelioAlves
{
    class Employee
    {
        private string _name;
        private char _genre;
        private int _age;

        public Employee() { }
        public Employee(string name, char genre, int age) : this()
        {
            _name = name;
            _genre = genre;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value;  }
        }

        public char Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public override string ToString()
        {
            return $"{_name} is {_genre} with {_age} years old!";
        }
    }
}
