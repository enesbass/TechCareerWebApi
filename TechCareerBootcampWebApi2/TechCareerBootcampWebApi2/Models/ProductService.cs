namespace TechCareerBootcampWebApi2.Models
{
	public class ProductService
	{
		public static List<Product> GetProductServices()
		{
			var categories = GetAllCategory();
			var products = new List<Product>();
			products.Add(new Product(1, "Cola", 25.00, categories.FirstOrDefault(c => c.Name == "Beverages")));
			products.Add(new Product(2, "Pringles", 45.00, categories.FirstOrDefault(c => c.Name == "Snacks")));
			products.Add(new Product(3, "Snickers", 18.00, categories.FirstOrDefault(c => c.Name == "Confections")));
			products.Add(new Product(4, "Toblerone", 30.00, categories.FirstOrDefault(c => c.Name == "Confections")));

			return products;
		}
		public static List<Category> GetAllCategory()
		{
			var categories = new List<Category>();
			categories.Add(new Category(1, "Beverages"));
			categories.Add(new Category(2, "Snacks"));
			categories.Add(new Category(3, "Confections"));

			return categories;
		}
	}
}
