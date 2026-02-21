using System;

namespace Services
{
    public class InventoryServices
    {
        private String[,] products = new string[2, 3]
        {
            {"Apples", "Oranges", "Bananas" },
            {"10", "20", "30"}
        };
        private String[] initalStock = { "10", "20", "30" };

        public String[,] viewInventory()
        {
            return products;
        }
        public void ResetInventory()
        {
            for (int i = 0; i < products.GetLength(1); i++)
            {
                products[1 , i] = initalStock[i];
            }
        }
        public void UpdateStock(int productIndex, int newStock)
        {
            if (productIndex >= 0 && productIndex < products.GetLength(1))
            {
                products[1, productIndex] = newStock.ToString();
            }
            else
            {
                Console.WriteLine("Invalid product index.");
            }
        }
    }
}
