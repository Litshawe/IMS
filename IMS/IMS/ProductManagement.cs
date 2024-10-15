using System;
using System.Collections.Generic;  

namespace IMS
{
    public class ProductManagement
    {
        private List<Product> products = new List<Product>();

        public void ManageProducts()
        {
            while (true)
            {
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add Product"); 
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. View Products");
                Console.WriteLine("5. Back");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateProduct();
                        break;
                    case "3":
                        DeleteProduct();
                        break;
                    case "4":
                        ViewProducts();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            products.Add(new Product { Name = name, Price = price });
            Console.WriteLine("Product added successfully.");
        }

        private void UpdateProduct()
        {
            Console.Write("Enter product name to update: ");
            string name = Console.ReadLine();
            Product product = products.Find(p => p.Name == name);

            if (product != null)
            {
                Console.Write("Enter new price: ");
                product.Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        private void DeleteProduct()
        {
            Console.Write("Enter product name to delete: ");
            string name = Console.ReadLine();
            Product product = products.Find(p => p.Name == name);

            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        private void ViewProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.Name+"\n"+ product.Price);
            }
        }
    }



}