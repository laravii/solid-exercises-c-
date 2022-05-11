namespace ExerciseIV.Models
{
    public class Product
    {
        public readonly Guid Id = Guid.NewGuid();

        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public Product(string productName, string productDescription, decimal price)
        {
            Name = productName;
            Description = productDescription;
            Price = price;
        }
    }
}
