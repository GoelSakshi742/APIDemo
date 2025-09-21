using APIDemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToyController(ToyDbContext context) : ControllerBase
    {
        private readonly ToyDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult <List<Toy>>> GetToys() 
        {
            return Ok(await _context.Toys.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Toy>> GetToyByID(int id)
        {
            var toy = await _context.Toys.FindAsync(id);
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
        public async Task<ActionResult<Toy>> AddToys(Toy newToy)
        {
            if (newToy is null)
            {
                return BadRequest();
            }
            _context.Toys.Add(newToy);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetToyByID), new { id = newToy.Id }, newToy);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateToy(int id, Toy updateToy)
        {
            var toy = await _context.Toys.FindAsync(id);
            if (toy == null)
            {
                return NotFound();
            }
            toy.Brand = updateToy.Brand;
            toy.Model = updateToy.Model;
            toy.ToyName = updateToy.ToyName;

            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteToy(int id)
        {
            var toy = await _context.Toys.FindAsync(id);
            if (toy == null)
            {
                return NotFound();
            }
            _context.Toys.Remove(toy);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
