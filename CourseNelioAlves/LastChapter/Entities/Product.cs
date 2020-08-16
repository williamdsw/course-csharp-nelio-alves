
using System.Globalization;
using System.Text;

namespace LastChapter.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Id).Append(", ");
            builder.Append(Name).Append(", ");
            builder.Append(Price.ToString("F2", CultureInfo.InvariantCulture)).Append(", ");
            builder.Append(Category);
            return builder.ToString();
        }
    }
}
