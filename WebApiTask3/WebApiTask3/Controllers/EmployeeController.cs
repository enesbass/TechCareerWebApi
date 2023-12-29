using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTask3.Models.Context;

namespace WebApiTask3.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly AppDbContext _context;
		public EmployeeController()
		{
			_context = new AppDbContext();
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var employee = _context.Employees.ToList();
			return Ok(employee);
		}
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
			if (employee == null)
			{
				return NotFound();
			}
			return Ok(employee);
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
			if (employee == null)
			{
				return NotFound();
			}
			_context.Employees.Remove(employee);
			_context.SaveChanges();
			return Ok(employee);
		}
	}
}
