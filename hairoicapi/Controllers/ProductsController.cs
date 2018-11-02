using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HairoicAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace HairoicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("HairoicPolicy")]
    public class ProductsController : ControllerBase
    {
        private readonly HairoicAPIContext _context;

        public ProductsController(HairoicAPIContext context)
        {
            _context = context;
        }

        // GET: api/Products?upc=UPC
        [HttpGet]
        public async Task<IActionResult> Index(long upc)
        {
            //var product = from m in _context.Product.Include(p => p.Name)
            //               select m;

            var product = await _context.Product
                //.Include("ProductIngredients.IngredientId")
                .Where(p => p.UPC == upc)
                .SingleAsync();

            var productIng = _context.ProductIngredient
                .Include(i => i.Ingredient)
                .Where(pi => pi.ProductId == product.ProductId)
                .Select(i => i.Ingredient).ToList();

            product.Ingredients = productIng;


            //var applicationDbContext = _context.Product.Include(p => p.ProductType);
            //return View(await applicationDbContext.ToListAsync());
            return Ok(product);
        }

        [HttpPost]
        [Authorize]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }


        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Product
                //.Include("ProductIngredients.IngredientId")
                .Where(p => p.ProductId == id)
                .SingleAsync();


            var productIng = _context.ProductIngredient
                .Include(i => i.Ingredient)
                .Where(pi => pi.ProductId == id)
                .Select(i => i.Ingredient).ToList();

            product.Ingredients = productIng;

            //var product =
            //from p in Product
            //join pi in ProductIngredient on p.ProductId equals pi.ProductId
            //join i in Ingredient on pi.IngredientId equals i.IngredientId
            //select new
            //{
            //    ProdId = p.Id, // or pc.ProdId
            //    IngId = i.CatId
            //    // other assignments
            //};


            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Product.Add(product);
            foreach(Ingredient ingredient in product.Ingredients)
            {
                var productIngredient = new ProductIngredient()
                {
                    IngredientId = ingredient.IngredientId,
                    ProductId = product.ProductId
                };
                _context.ProductIngredient.Add(productIngredient);
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}