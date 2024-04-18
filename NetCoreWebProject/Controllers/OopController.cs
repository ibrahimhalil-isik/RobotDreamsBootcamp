using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebProject.Model.Abstract;
using NetCoreWebProject.Model.Interface;
using NetCoreWebProject.Model.Oop;
using Newtonsoft.Json;

namespace NetCoreWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Inheritace
    public class OopController : ControllerBase
    {
        [HttpGet]
        [Route("oop")]
        public IActionResult Oop()
        {
            Shoe shoe = new Shoe
            {
                Type = "Sport",
                Number = 47,
                Color = "White",
                IsLace = true,
            };

            var serializedShoe = JsonConvert.SerializeObject(shoe);

            return Ok(serializedShoe);
        }

        [HttpGet]
        [Route("encapsulation1")]
        public IActionResult Encapsulation()
        {
            Shoe shoe2 = new Shoe();

            shoe2.WriteBrand("Adidas");

            return Ok(shoe2.ReadBrand());
        }

        [HttpGet]
        [Route("encapsulation2")]
        public IActionResult Encapsulation2()
        {
            Shoe shoe3 = new Shoe();

            shoe3.Type = "Sport";

            return Ok(shoe3.Type);
        }

        [HttpGet]
        [Route("constructors")]
        public IActionResult Constructors()
        {
            //Car car = new Car("Nissan");

            Car car = new Car(Enum.ModelEnum.F50, Enum.BrandEnum.Ferrari);

            var carSerialized = JsonConvert.SerializeObject(car);

            return Ok(carSerialized);
        }

        [HttpGet]
        [Route("polymorphism")]
        public IActionResult Polymorphism()
        {
            Basket basket = new Basket();

            Bread bread = new Bread("Uno", 35, "Buğday", 500);
            MobilePhone phone = new MobilePhone("mi Note 15", 25000, "Xiaomi");

            basket.Add(bread);
            basket.Add(phone);

            // Telefon ve ekmek için ayrı kdv oranı hesaplaması "polymorphism" olarak adlandırılır.
            basket.TotalPrice = basket.Sum();
            string basketSerialized = JsonConvert.SerializeObject(basket);

            return Ok(basketSerialized);
        }

        [HttpGet]
        [Route("abstract")]
        public IActionResult Abstract()
        {
            Guitar guitar = new() { Name = "ESP", Description = "Amerika üretimi" };
            Drum drum = new() { Name = "Tama", Description = "Japon üretimi" };
            Piano piano = new() { Name = "Kawai", Description = "Japon üretimi" };

            Musician guitarist = new() { Name = "James", Surname = "Hetfield", Instrument = guitar, HowToPlay = guitar.Play() };
            Musician drummer = new() { Name = "Lars", Surname = "Ulrich", Instrument = drum, HowToPlay = drum.Play() };
            Musician pianist = new() { Name = "Lang", Surname = "Lang", Instrument = piano, HowToPlay = piano.Play() };

            string serializedGuitarist = JsonConvert.SerializeObject(guitarist);
            string serializedDrummer = JsonConvert.SerializeObject(drummer);
            string serializedPianist = JsonConvert.SerializeObject(pianist);

            string result = serializedDrummer + serializedPianist + serializedGuitarist;
            return Ok(result);
        }

        [HttpGet]
        [Route("interface")]
        public IActionResult Interface()
        {
            Player player = new Player();
            player.Name = "ibrahim";
            player.Age = 23;
            player.Weapon = new M51();
            player.LifeBar = 100;

            Player player2 = new Player();
            player2.Name = "halil";
            player2.Age = 24;
            player2.Weapon = new B43();
            player2.LifeBar = 75;

            string M51TakeAim = player.TakeAim();
            string M51Attack = player.Attack();

            string B43TakeAim = player2.TakeAim();
            string B43Attack = player2.Attack();

            string result = "M51 : " + M51TakeAim + " " + M51Attack + " \nB43 : " + B43TakeAim + B43Attack;
            return Ok(result);
        }
    }
}