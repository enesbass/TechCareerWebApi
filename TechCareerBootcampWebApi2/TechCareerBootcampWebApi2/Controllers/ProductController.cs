using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareerBootcampWebApi2.Models;

namespace TechCareerBootcampWebApi2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		static List<Product> products;
		public ProductController()
		{
			if (products == null)
			{
				products = ProductService.GetProductServices();
			}
		}


		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(products);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var product = products.FirstOrDefault(p => p.Id == id);
			if (product == null)
			{
				return NotFound($"Product with id {id} not found");
			}
			else
			{
				return Ok(product);
			}

		}

		[HttpPost]
		public IActionResult Create()
		{
			return Ok("Add a new product");
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			return Ok($"Delete product with id {id}");
		}	
	}
}
