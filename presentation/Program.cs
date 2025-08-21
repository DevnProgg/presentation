using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        LaurenPresentationPart.Demonstrate();
    }
}

class LaurenPresentationPart
{
    // Represents a product with a name, category, and price
    class Product
    {
        // Name of the product
        public string Name { get; set; }
        // Category of the product (e.g., Laptop, Smartphone)
        public string Category { get; set; }
        // Price of the product
        public decimal Price { get; set; }

        // Constructor to initialize product properties
        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
    // Represents a collection of electronic products
    class ElectronicProducts
    {
        // Internal list to store products
        private List<Product> products = new List<Product>();

        // Adds sample electronic products to the list
        public void AddSampleData()
        {
            products.Add(new Product("Dell XPS 13", "Laptop", 999.99m)); // Add a laptop
            products.Add(new Product("Apple MacBook Pro", "Laptop", 1299.99m)); // Add another laptop
            products.Add(new Product("Samsung Galaxy S21", "Smartphone", 799.99m)); // Add a smartphone
            products.Add(new Product("Sony WH-1000XM4", "Headphones", 349.99m)); // Add headphones
            products.Add(new Product("Apple iPad Pro", "Tablet", 899.99m)); // Add a tablet
        }

        // Returns all products that match the specified category
        public List<Product> GetProductsByCategory(string category)
        {
            // Find all products where the category matches (case-insensitive)
            return products.FindAll(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }
    }

    public static void Demonstrate()
    {
        var electronicProducts = new ElectronicProducts();
        electronicProducts.AddSampleData();
        Console.WriteLine("Products in category 'Laptop':");
        var laptops = electronicProducts.GetProductsByCategory("Laptop");
        foreach (var product in laptops)
        {
            Console.WriteLine($"{product.Name} - R {product.Price}");
        }
    }
}
