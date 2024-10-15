 using System;
using System.Collections.Generic;

namespace IMS
{
    public class SupplierManagement
    {
        private List<Supplier> suppliers = new List<Supplier>();

        public void ManageSuppliers()
        {
            while (true)
            {
                Console.WriteLine("Supplier Management");
                Console.WriteLine("1. Add Supplier");
                Console.WriteLine("2. Update Supplier");
                Console.WriteLine("3. Delete Supplier");
                Console.WriteLine("4. View Suppliers");
                Console.WriteLine("5. Back");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSupplier();
                        break;
                    case "2":
                        UpdateSupplier();
                        break;
                    case "3":
                        DeleteSupplier();
                        break;
                    case "4":
                        ViewSuppliers();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void AddSupplier()
        {
            Console.Write("Enter supplier name: ");
            string name = Console.ReadLine();
            Console.Write("Enter supplier contact: ");
            string contact = Console.ReadLine();

            suppliers.Add(new Supplier { Name = name, Contact = contact });
            Console.WriteLine("Supplier added successfully.");
        }

        private void UpdateSupplier()
        {
            Console.Write("Enter supplier name to update: ");
            string name = Console.ReadLine();
            Supplier supplier = suppliers.Find(s => s.Name == name);

            if (supplier != null)
            {
                Console.Write("Enter new contact: ");
                supplier.Contact = Console.ReadLine();
                Console.WriteLine("Supplier updated successfully.");
            }
            else
            {
                Console.WriteLine("Supplier not found.");
            }
        }

        private void DeleteSupplier()
        {
            Console.Write("Enter supplier name to delete: ");
            string name = Console.ReadLine();
            Supplier supplier = suppliers.Find(s => s.Name == name);

            if (supplier != null)
            {
                suppliers.Remove(supplier);
                Console.WriteLine("Supplier deleted successfully.");
            }
            else
            {
                Console.WriteLine("Supplier not found.");
            }
        }

        private void ViewSuppliers()
        {
            foreach (var supplier in suppliers)
            {
                Console.WriteLine("Name: {supplier.Name}, Contact: {supplier.Contact}");
            }
        }

    }

} 
 