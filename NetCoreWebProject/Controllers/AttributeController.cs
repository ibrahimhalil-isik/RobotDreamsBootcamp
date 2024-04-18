using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebProject.Attributes;

namespace NetCoreWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Developer("ibrahim", "4", true)]
    public class AttributeController : ControllerBase
    {
        [HttpGet]
        [Route("getAttributeValues")]
        public IActionResult AttributeExample()
        {
            return Ok(GetAttribute(typeof(AttributeController)));
        }

        private string GetAttribute(Type t)
        {
            DeveloperAttribute myAttr = (DeveloperAttribute)(Attribute.GetCustomAttribute(t, typeof(DeveloperAttribute)));
            return $"Name: {myAttr.Name} -> Level: {myAttr.Level} -> Reviewed: {myAttr.Reviwed}";
        }
    }
}
