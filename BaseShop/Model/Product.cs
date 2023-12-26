using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsShop.Model
{
    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public string Manufacturer { get; set; }
        public string YearOfManufacture { get; set; }
        public int StockQuantity { get; set; }

        public Product() { }

        public Product(string name, double price, string description, 
            string supplier, string manufacturer, string yearOfManufacture, int stockQuantity) 
        {
            Name = name;
            Price = price;
            Description = description;
            Supplier = supplier;
            Manufacturer = manufacturer;
            YearOfManufacture = yearOfManufacture;
            StockQuantity = stockQuantity;
        }
    }
}
