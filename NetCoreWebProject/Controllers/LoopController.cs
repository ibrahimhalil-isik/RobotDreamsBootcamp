using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NetCoreWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoopController : ControllerBase
    {
        [HttpGet]
        [Route("if")]
        public IActionResult ExampleIf(string name)
        {
            string result;

            if (name.StartsWith("m"))
            {
                result = "Adınız m harfi ile başlıyor.";
            }
            else if (name.StartsWith("M"))
            {
                result = "Adınız m harfi ile başlıyor.";
            }
            else
            {
                result = "Adınız m harfi ile başlamıyor.";
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("switchcase")]
        public IActionResult ExampleSwitchCase(string teamCode)
        {
            string result;

            switch (teamCode)
            {
                case "gs":
                    result = "Galatasaray";
                    break;
                case "fb":
                    result = "Fenerbahçe";
                    break;
                case "bjk":
                    result = "Beşiktaş";
                    break;
                case "ts":
                    result = "Trabzonspor";
                    break;
                default:
                    result = "Batman Petrol Spor";
                    break;
            }

            //--- switch case --- Yeni kullanım şekli ---
            //string result = teamCode switch
            //{
            //    "gs" => "Galatasaray",
            //    "fb" => "Fenerbahçe",
            //    "bjk" => "Beşiktaş",
            //    "ts" => "Trabzonspor",
            //    _ => "Batman Petrol Spor",
            //};

            return Ok(result);
        }

        [HttpGet]
        [Route("for")]
        public IActionResult ExampleFor()
        {
            List<int> numbers = new();
            for (int i = 0; i < 10; i++) 
            { 
                numbers.Add(i);                            
            }
            return Ok(JsonConvert.SerializeObject(numbers));
        }

        [HttpGet]
        [Route("while")]
        public IActionResult ExampleWhile()
        {
            int i = 0;
            List<int> numbers = new();
            while (i < 10)
            {
                numbers.Add(i);
                i++;
            }


            return Ok(JsonConvert.SerializeObject(numbers));
        }

        [HttpGet]
        [Route("foreach")]
        public IActionResult ExampleForeach()
        {
            List<int> numbers = new();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }

            List<int> result = new();
            foreach (var number in numbers)
            {
                result.Add(number);                                
            }
            return Ok(JsonConvert.SerializeObject(result));
        }

        [HttpGet]
        [Route("dowhile")]
        public IActionResult ExampleDoWhile()
        {
            int i = 0;
            List<int> numbers = new();
            do
            {
                numbers.Add(i);
                i++;
            } while (i<0);


            return Ok(JsonConvert.SerializeObject(numbers));
        }

        [HttpGet]
        [Route("break")]
        public IActionResult ExampleBreak()
        {
            List<int> numbers = new();
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                numbers.Add(i);
            }
            return Ok(JsonConvert.SerializeObject(numbers));
        }

        [HttpGet]
        [Route("continue")]
        public IActionResult ExampleContinue()
        {
            List<int> numbers = new();
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                numbers.Add(i);
            }
            return Ok(JsonConvert.SerializeObject(numbers));
        }

        [HttpGet]
        [Route("infinite")]
        public IActionResult ExampleInfiniteLoop()
        {
            for (; ; )
            {

            }

            while (true)
            {

            }

            while (1 == 1)
            {

            }
            
            return Ok();
        }
    }
}
