using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebProject.Model.GenericType;
using NetCoreWebProject.Model.Oop;
using Newtonsoft.Json;

namespace NetCoreWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController : ControllerBase
    {
        [HttpGet]
        [Route("genericType")]
        public IActionResult GenericTypeExample()
        {
            Generic<string> generic = new Generic<string>();
            generic.Field = "String";

            return Ok(generic.Field);
        }

        [HttpGet]
        [Route("genericTypeClass")]
        public IActionResult GenericTypeExampleForClass()
        {
            Generic<Car> car = new Generic<Car>();
            car.Field = new Car { Brand = Enum.BrandEnum.Ferrari, 
                                  Color = "Black",Hatchback = false, 
                                  Model = Enum.ModelEnum.F50 };

            string result = JsonConvert.SerializeObject(car);
            return Ok(result);
        }

        [HttpGet]
        [Route("genericType3")]
        public IActionResult GenericTypeExample3()
        {
            var car = new Car
            {
                Color = "Black",
                Brand = Enum.BrandEnum.Ferrari,
                Model = Enum.ModelEnum.F50
            };

            var generic = new Generic<Car>();

            if (string.IsNullOrEmpty(car.Color))
            {
                generic.Code = 400;
                generic.Message = "Color is mandatory";
            }
            else
            {
                generic.Code = 200;
                generic.Message = "Successful";
                generic.Field = car;
            }

            return Ok(JsonConvert.SerializeObject(generic));
        }

        [HttpGet]
        [Route("genericTypeKeyValue")]
        public IActionResult GenericTypeKeyValue()
        {
            KeyValue<string, int> generic = new();
            generic.Key = "Success";
            generic.Value = 200;
            return Ok(JsonConvert.SerializeObject(generic));
        }

        [HttpGet]
        [Route("genericTypeArray")]
        public IActionResult GenericTypeArray()
        {
            var list = new GenericArray<Car>();

            Car car1 = new Car
            {
                Brand = Enum.BrandEnum.Tesla,
                Model = Enum.ModelEnum.Enzo,
                Color = "Kırmızı"
            };
            Car car2 = new Car
            {
                Brand = Enum.BrandEnum.Tesla,
                Model = Enum.ModelEnum.Enzo,
                Color = "Sarı"
            };

            list.Data[0] = car1;
            list.Data[1] = car2;

            return Ok(JsonConvert.SerializeObject(list.Data));
        }
    }
}
