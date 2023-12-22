using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareerWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CountriesController : ControllerBase
	{
		[HttpGet]
		public string[] Get()
		{
			string[] countries = new string[] { "USA", "Canada", "Mexico","Türkiye", "Germany","Holland", "Spain", "Russian", "Belgium", "China", 
				"France","Brazil","Argentina", "Norway", "South Africa", "Japan", "United Kingdom", "South Korea","India"," Australia"};
			return countries;
		}
		[HttpGet("{id}")]
		public string Get(int id)
		{
			string[] countries = new string[] { "USA", "Canada", "Mexico","Türkiye", "Germany","Holland", "Spain", "Russian", "Belgium", "China", 
							"France","Brazil","Argentina", "Norway", "South Africa", "Japan", "United Kingdom", "South Korea","India"," Australia"};
			
			if(id >= 0 && id < countries.Length)
			{
				return countries[id];
			}
			else
			{
				return $"Country with id {id} not found";
			}
		}

	}
}
