
namespace CourseNelioAlves
{
    class Employee
    {
        public string Name { get; set; }
        public char Genre { get; set; }
        public int Age { get; set; }

        public Employee() { }
        public Employee(string name, char genre, int age) : this()
        {
            Name = name;
            Genre = genre;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} is {Genre} with {Age} years old!";
        }
    }
}
