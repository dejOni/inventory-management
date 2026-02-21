using Services;
using System;

namespace View
{
	public class InventoryView
	{
		private InventoryServices service = new InventoryServices();
		public void Run()
		{
		    bool looping = true;
            while (looping)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("(A) View Inventory");
                Console.WriteLine("(B) Update Stock");
                Console.WriteLine("(C) Reset Inventory");
                Console.WriteLine("(D) Exit");

                String optionsAnswer = Console.ReadLine().ToLower();

                switch (optionsAnswer)
                {

                    case "a":
                        DisplayInventory();
                        break;

                    case "b":
                        UpdateStockFlow();
                        break;

                    case "c":
                        service.ResetInventory();
                        Console.WriteLine("Inventory has been reset.");
                        break;

                    case "d":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        looping = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        private void DisplayInventory()
        {
            String[,] inventory = service.viewInventory();
            Console.WriteLine("Product\tStock");
            for (int i = 0; i < inventory.GetLength(1); i++)
            {
                Console.WriteLine($"{inventory[0, i]}\t{inventory[1, i]}");
            }
        }
        private void UpdateStockFlow()
        {
            Console.WriteLine("Enter the product index to update (0 for Apples, 1 for Oranges, 2 for Bananas):");
            int productIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new stock quantity:");
            int newStock = int.Parse(Console.ReadLine());
            service.UpdateStock(productIndex, newStock);
            Console.WriteLine("Stock updated successfully.");
        }
    }
}
