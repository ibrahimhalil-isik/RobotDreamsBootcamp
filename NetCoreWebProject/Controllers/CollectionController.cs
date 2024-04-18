using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NetCoreWebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        [HttpGet]
        [Route("collectionlist")]
        public IActionResult CollectionList()
        {
            List<int> intList = new List<int>();
            intList.Add(0);
            intList.Add(0);
            intList.Distinct();
            intList.Find(p => p == 0);

            IEnumerable<int> ints = new List<int>(); //Veri eklemeyeceksek bu kullanılır.

            return Ok();
        }

        [HttpGet]
        [Route("collectionqueue")]
        public IActionResult CollectionQueue() 
        {
            var q  = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);   
            q.Enqueue(3);
            //q.Enqueue( n );   Listenin sonuna yeni üye ekler

            q.Dequeue(); // En eski üyeyi listeden kaldırır.

            q.Peek();

            string result = JsonConvert.SerializeObject(q);

            return Ok(result);                
        }

        [HttpGet]
        [Route("collectiondictionary")]
        public IActionResult CollectionDictionary()
        {
            var dict = new Dictionary<string, object>();

            dict.Add("parameter1", "ibrahim");
            dict.Add("parameter2", "1");
            dict.Add("isActive", true);
            
            // Eğer parameter2 yoksa null verir
            var parameter2 = dict.Where(p => p.Key == "parameter2").FirstOrDefault().Value;

            //Üstteki satır ile aynı işi yapar
            var parameter1 = dict.FirstOrDefault(p => p.Key == "parameter1").Value;

            return Ok(parameter2);
        }

    }
}
