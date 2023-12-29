using Microsoft.EntityFrameworkCore;

namespace WebApiTask3.Models.Context
{
	public class AppDbContext:DbContext
	{
		override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebApiTechCareer;Trusted_Connection=True;");
		}
		public DbSet<Employee> Employees { get; set; }
	}
}
