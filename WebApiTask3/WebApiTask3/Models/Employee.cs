using System.ComponentModel.DataAnnotations;

namespace WebApiTask3.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Name is required")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "LastName is required")]
		public string? Adress { get; set; }
		public string? City { get; set; }
		public DateTime? AddDate { get; set; }
		//[DataType(DataType.Date)]
	}
}
