using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        [HttpGet]
        [Route("concanate")]
        public IActionResult Concanate()
        {
            string s1 = "ibrahim";
            string s2 = "halil";
            string space = " ";
            //s1 += space + s2;
            //string c = string.Concat(s1,space,s2);
            string c2 = $"{s1}{space}{s2}";
            return Ok(c2);
        }

        [HttpGet]
        [Route("split")]
        public IActionResult Split([FromQuery] string names)
        {
            //emaillist = "ibrahim@halil.com;ibrahim@isik.com;ibrahimhalil@isik.com"
            string[] splittedValues = names.Split(",");
            return Ok(splittedValues);
        }

        [HttpGet]
        [Route("replace")]
        public IActionResult Replace([FromQuery] string names)
        {
            string replacedValues = names.Replace("halil", "ibrahim").Replace("/", "\\").Replace("1,645,00", "1.645.00");
            return Ok(replacedValues);
        }

        [HttpGet]
        [Route("substring")]
        public IActionResult Substring([FromQuery] string names)
        {
            string substring = names.Substring(1,5);
           
            return Ok(substring);
        }

        [HttpGet]
        [Route("substringjoin")]
        public IActionResult SubstringJoin()
        {           
            var join = string.Join(",", new string[] { "ibrahim", "halil", "isik" });
            return Ok(join);
        }
    }
}
