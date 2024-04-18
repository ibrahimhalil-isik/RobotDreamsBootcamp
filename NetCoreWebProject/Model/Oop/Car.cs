using NetCoreWebProject.Enum;

namespace NetCoreWebProject.Model.Oop
{
    public class Car
    {
        //Constructors
        public Car() { }
        public Car(ModelEnum model, BrandEnum brand)
        {
            Model = model;
            Brand = brand;
        }

        public string Color { get; set; }
        public int EnginePowerCc { get; set; }
        public bool Hatchback { get; set; }
        public ModelEnum Model { get; set; }
        public BrandEnum Brand { get; set; }

        public bool IsHatchback(string brand)
        {
            if (brand == "Ferrari")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
