using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventory
{
    public class Product
    {
         int ID,quantity, price;// Properties
        string productName;

        public Product()
        {
            ID = 0;
            quantity = 0;
            price = 0;
            productName = "";
        }
        public Product(int id, int quantity, int price, string productName)// Constructor
        {
            ID = id;
            quantity = quantity;
            price = price;
            productName = productName;
        }
        public List<Product>  GetProducts()// Method to get products
        {
             List<Product> products = new List<Product>()
            {
                new Product(1, 8, 32, "Chips"),
                new Product(2, 6, 20, "Biscuits"),
                new Product(3, 4, 12, "Energy")
            };
            // Using LINQ to filter products with quantity less than 5


            List<Product> prodcuctLow=products.Where(p => p.quantity < 5).ToList();


            var myLinqQuery = from p in products
                        where p.quantity < 5
                        select p;

          
            return products;// Return the list of products
        }

    }
}
