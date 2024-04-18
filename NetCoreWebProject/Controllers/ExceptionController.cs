using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace NetCoreWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExceptionController : ControllerBase
    {
        private ILogger<ExceptionController> _logger;

        public ExceptionController(ILogger<ExceptionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("exception")]
        public IActionResult Exception()
        {
            try
            {
                var a = "Hello World";
                var c = Convert.ToInt32(a);
                return Ok();
            }
            catch (Exception ex)
            {
                var message = $"Message: {ex.Message} , StackTrace: {ex.StackTrace}";
                _logger.LogError(message);
                return BadRequest(".... Hatası aldınız. Lütfen hatayı giderin.");
            }
        }

        [HttpGet]
        [Route("IndexOutOfRangeException")]
        public IActionResult IndexOutOfRangeException()
        {
            try
            {
                var arr = new int[3];
                var c = arr[arr.Length + 1];
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("IndexOutOfRangeException hatası aldık..");              
            }
        }

        [HttpGet]
        [Route("NullReferenceException")]
        public IActionResult NullReferenceException()
        {
            try
            {
                object o = null;
                var b = o.ToString();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("NullReferenceException hatası aldık..");
            }
        }

        [HttpGet]
        [Route("InvalidOperationException")]
        public IActionResult InvalidOperationException()
        {
            try
            {
                List<int> values = new();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("InvalidOperationException hatası aldık..");
            }
        }

        [HttpGet]
        [Route("exceptionWhen")]
        public IActionResult ExceptionWhen()
        {
            try
            {
                var a = "aaaaa";
                var c = Convert.ToInt32(a);
                return Ok();
            }
            catch (Exception ex) when (ex.Message.Contains("input"))
            {
                var message = $"Message: {ex.Message} , StackTrace: {ex.StackTrace}";
                _logger.LogError(message);
                return BadRequest(message);
            }
        }
    }
}






        
