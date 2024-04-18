namespace NetCoreWebProject.Model.Oop
{
    public class Shoe
    {
        //public string Type;
        public string Material;
        public byte Number;
        public string Color;
        public bool IsLace;

        // private tanımlayıp dışardan erişilmesine izin vermiyoruz.
        // Bu değişkene erişmesi için class içerisine tanımladığımız methodları kullnması gerekiyor
        // Bu duruma "encapsulation" denir.
        private string Brand;

        // "Brand" özelliğinin değerini yanlızca okumak için kullanılacak bir metod:
        public string ReadBrand()
        {
            return Brand;
        }

        // "Brand" özelliğine yanlızca değer atamak için kullanılacak bir metod:
        public void WriteBrand(string brand)
        {
            Brand = brand;
        }

        //encapsulation için farklı bir örnek
        private string type;
        // "Type" özelliğini encapsulate ediyoruz.
        public string Type
        {
            get { return type; }  // ReadBrand methodu gibi..
            set { type = value; } // WriteBrand methodu gibi.. çalışır
        }

    }
}
