namespace NetCoreWebProject.Model.Oop
{
    // Inheritace
    public class Bread : Product
    {
        public string Type { get; set; }
        public int BasisWeight { get; set; }

        // Polymorphism
        public override double AddKdv()
        {
            return Price * 1.01;
        }

        public Bread(string productName, double price, string type, int basisWeight)
        {
            ProductName = productName;
            Price = price;
            Type = type;
            BasisWeight = basisWeight;
        }
    }
}
