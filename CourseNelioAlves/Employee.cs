
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

        public string GetName ()
        {
            return _name;
        }

        public void SetName (string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        public char GetGenre ()
        {
            return _genre;
        }

        public void SetGenre (char genre)
        {
            _genre = genre;
        }

        public int GetAge ()
        {
            return _age;
        }

        public void SetAge (int age)
        {
            _age = age;
        }

        public override string ToString()
        {
            return $"{_name} is {_genre} with {_age} years old!";
        }
    }
}
