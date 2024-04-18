namespace NetCoreWebProject.Model.Oop
{
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public virtual double AddKdv()
        {
            return Price * 1.18;
        }

        public Product()
        {
        }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
