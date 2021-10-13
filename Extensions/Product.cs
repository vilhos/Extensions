

namespace ShoppingApp
{
    public class Product
    {
        public float Price { get; set; }
        public string Name { get; set; }

        public Product(float price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
