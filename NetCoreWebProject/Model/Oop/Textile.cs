namespace NetCoreWebProject.Model.Oop
{
    // Inheritace
    public class Textile : Product
    {
        public string FabricType { get; set; }
        public int Size { get; set; }
        public string Manufacturer { get; set; }

        public Textile(string productName, double price, string fabricType, int size)
        {
            ProductName = productName;
            Price = price;
            FabricType = fabricType;
            Size = size;
        }
    }
}
