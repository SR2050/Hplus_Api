using Hplus.EfCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Ef_DataContext _context;

        public ProductsController(Ef_DataContext context)
        {
            _context = context;
        }


        //get all products
        //https://localhost:44347/api/Products

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }



        //Create or Add Products
        //https://localhost:44347/api/Products
        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetById), new { id = product.ProductId }, product);
            }
        }



        //find product with products id
        //https://localhost:44347/api/Products/id

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }


        //Update product With products id
        //https://localhost:44347/api/Products/id

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingProduct = _context.Products.FirstOrDefault(x => x.ProductId == id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.ProductName = product.ProductName;
            existingProduct.ProductDescription = product.ProductDescription;
            existingProduct.ProductPrice = product.ProductPrice;
           
            // Update other properties as needed

            _context.SaveChanges();

            return NoContent();
        }



        //Destroy or delete products
        //https://localhost:44347/api/Products/id
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
