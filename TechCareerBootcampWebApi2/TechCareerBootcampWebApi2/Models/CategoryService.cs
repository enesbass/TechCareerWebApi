namespace TechCareerBootcampWebApi2.Models
{
	public class CategoryService
	{
		public static List<Category> GetCategoryServices()
		{
			var categories = new List<Category>();
			categories.Add(new Category(1, "Beverages"));
			categories.Add(new Category(2, "Snacks"));
			categories.Add(new Category(3, "Confections"));

			return categories;
		}
	}
}
