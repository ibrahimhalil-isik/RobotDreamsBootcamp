namespace NetCoreWebProject.Model.Oop
{
    public class Basket
    {
        public List<Product> Products = new List<Product>();

        public double TotalPrice { get; set; }

        public double Sum()
        {
            double totalPrice = 0;

            foreach (Product product in Products)
            {
                totalPrice += product.AddKdv();
            }
            return totalPrice;
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}
