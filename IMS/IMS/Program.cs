using System;
using System.Collections.Generic;

namespace IMS
{
   
    class Program
    {
        static void Main(string[] args)
        {
            
            ProductManagement productManagement = new ProductManagement();
            SupplierManagement supplierManagement = new SupplierManagement();

          
            while (true)
            {
                Console.WriteLine("Inventory Management System");
                Console.WriteLine("1. Manage Products");
                Console.WriteLine("2. Manage Suppliers");
                Console.WriteLine("3. Stock Alerts");
                Console.WriteLine("4. Reporting");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        productManagement.ManageProducts();
                        break;
                    case "2":
                        supplierManagement.ManageSuppliers();
                        break;
                    case "3":
                        Console.WriteLine("Stock alerts feature under development.");
                        break;
                    case "4":
                        Console.WriteLine("Reporting feature under development.");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
