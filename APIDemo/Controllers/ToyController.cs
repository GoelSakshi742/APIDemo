using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToyController : ControllerBase
    {
        static private List<Toy> toys = new List<Toy>
        {
            new Toy
            {  Id = 1,
                ToyName = "Millennium Falcon",
                Brand = "LEGO",
                Model = "75257"
            },
            new Toy
            {  Id = 2,
                ToyName = "Barbie Dreamhouse",
                Brand = "Mattel",
                Model = "FHY73"
            },
            new Toy
            { Id = 3,
                ToyName = "Hot Wheels Track Builder",
                Brand = "Mattel",
                Model = "GGH70"
            },
        };
        [HttpGet]
        public ActionResult <List<Toy>> GetToys() 
        {
            return Ok(toys);
        }
        [HttpGet("{id}")]
        public ActionResult<Toy> GetToyByID(int id)
        { 
            var toy = toys.FirstOrDefault(t=>t.Id == id);
            if (toy == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(toy);
            }

        }
        [HttpPost]
        public ActionResult<Toy> AddToys(Toy newToy)
        {
            if (newToy is null)
            {
                return BadRequest();
            }
            newToy.Id = toys.Max(t => t.Id) + 1;
            toys.Add(newToy);
            return CreatedAtAction(nameof(GetToyByID), new { id = newToy.Id }, newToy);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateToy(int id, Toy updateToy)
        {
            var toy = toys.FirstOrDefault(t => t.Id == id);
            if (toy == null)
            {
                return NotFound();
            }
            toy.Brand = updateToy.Brand;
            toy.Model = updateToy.Model;
            toy.ToyName = updateToy.ToyName;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteToy(int id)
        {
            var toy = toys.FirstOrDefault(t => t.Id == id);
            if(toy == null)
                return NotFound();
            toys.Remove(toy);
            return NoContent();
        }
    }
}
