using SportsNutritionShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace SportsNutritionShop.Services.Database
{
    public class DatabaseService : IUserDatabaseService, IPaymentDatabaseService, 
        IOrderDatabaseService, IProductDatabaseService, IShoppingCartDatabaseService
    {
        private string _dataFilePath;
        private DatabaseData _databaseData;

        public DatabaseService(string dataFilePath)
        {
            _dataFilePath = dataFilePath;

            _databaseData = ReadData();
        }

        public void Save()
        {
            WriteData(_databaseData);
        }
        public List<User> ReadUsers()
        {
            return _databaseData.Users;
        }

        public void WriteUsers(List<User> users)
        {
            _databaseData.Users = users;
        }

        public List<Order> ReadOrders()
        {
            return _databaseData.Orders;
        }

        public void WriteOrders(List<Order> orders)
        {
            _databaseData.Orders = orders;
        }

        public void WriteReceipts(List<Receipt> receipts)
        {
            _databaseData.Receipts = receipts;
        }

        public List<Receipt> ReadReceipts()
        {
            return _databaseData.Receipts;
        }

        public List<Product> ReadProducts()
        {
            return _databaseData.Products;
        }

        public void WriteProducts(List<Product> products)
        {
            _databaseData.Products = products;
        }

        public List<ShoppingCart> ReadShoppingCarts()
        {
            return _databaseData.ShoppingCarts;
        }

        public void WriteShoppingCarts(List<ShoppingCart> shoppingCarts)
        {
            _databaseData.ShoppingCarts = shoppingCarts;
        }

        private DatabaseData ReadData()
        {
            DatabaseData data = new DatabaseData();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DatabaseData));

                using (StreamReader reader = new StreamReader(_dataFilePath))
                {
                    data = (DatabaseData)serializer.Deserialize(reader);
                }

                Console.WriteLine("Данные успешно прочитаны из файла.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении данных из файла: {ex.Message}");
            }

            return data;
        }

        private void WriteData(DatabaseData data)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DatabaseData));

                using (StreamWriter writer = new StreamWriter(_dataFilePath))
                {
                    serializer.Serialize(writer, data);
                }

                Console.WriteLine("Данные успешно записаны в файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи данных в файл: {ex.Message}");
            }
        }
    }

    [Serializable]
    public class DatabaseData
    {
        [XmlArray("Users")]
        [XmlArrayItem("User")]
        public List<User> Users { get; set; } = new List<User>();

        [XmlArray("Orders")]
        [XmlArrayItem("Order")]
        public List<Order> Orders { get; set; } = new List<Order>();

        [XmlArray("Payment")]
        [XmlArrayItem("Receipt")]
        public List<Receipt> Receipts { get; set; } = new List<Receipt>();

        [XmlArray("Products")]
        [XmlArrayItem("Product")]
        public List<Product> Products { get; set; } = new List<Product>();

        [XmlArray("ShoppingCarts")]
        [XmlArrayItem("ShoppingCart")]
        public List<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
    }
}
