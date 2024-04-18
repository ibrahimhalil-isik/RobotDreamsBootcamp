namespace NetCoreWebProject.Model.Oop
{
    // Inheritace
    public class MobilePhone : Product
    {
        public string Specifications { get; set; }
        public string Brand { get; set; }

        public MobilePhone(string productName, double price, string brand)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
        }
    }
}
