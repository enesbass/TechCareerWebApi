﻿namespace TechCareerBootcampWebApi2.Models
{
	public class Product
	{
        public Product(int id, string name, double unitPrice, Category category)
        {
            this.Id = id;
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Category = category;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public Category Category{ get; set; }
    }
}
