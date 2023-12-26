using AutoPartsShop.Model;
using AutoPartsShop.Controllers.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Controllers
{
    public class ShoppingCartController
    {
        public event Action OnShoppingCartChanged;

        private IShoppingCartDatabaseController _databaseController;
        private UserController _userController;
        private List<ShoppingCart> _shoppingCarts;
        private ShoppingCart _currentShoppingCart;

        public ShoppingCartController(UserController userController, IShoppingCartDatabaseController databaseController)
        {
            _userController = userController;
            _databaseController = databaseController;
            _shoppingCarts = databaseController.ReadShoppingCarts();

            _userController.OnUserChanged += ChangeUser;
            ChangeUser(_userController.CurrentUser);
        }
        ~ShoppingCartController()
        {
            _userController.OnUserChanged -= ChangeUser;
        }

        public void SaveShoppingCarts()
        {
            _databaseController.WriteShoppingCarts(_shoppingCarts);
        }

        private void ChangeUser(User user)
        {
            if (user == null)
            {
                _currentShoppingCart = null;
                OnShoppingCartChanged?.Invoke();
                return;
            }

            _currentShoppingCart = _shoppingCarts.Find(c => c.User.Username == user.Username);

            if( _currentShoppingCart == null )
            {
                _currentShoppingCart = new ShoppingCart(user);
                _shoppingCarts.Add( _currentShoppingCart );
            }
            OnShoppingCartChanged?.Invoke();
        }

        public List<ProductOrder> GetCartItems()
        {
            if(_currentShoppingCart == null )
                return new List<ProductOrder>();
            return _currentShoppingCart.Items;
        }

        public void ClearCartItems()
        {
            if (_currentShoppingCart == null)
            {
                OnShoppingCartChanged?.Invoke();
                return;
            }

            _currentShoppingCart.Clear();
            OnShoppingCartChanged?.Invoke();
        }

        public bool AddToCart(Product product, int quantity, out string message)
        {
            if(_currentShoppingCart == null )
            {
                message = "Войдите в аккаунт, чтобы пользоваться корзиной";
                return false;
            }

            ProductOrder existingItem = _currentShoppingCart.Items.Find(item => item.Product.ProductId == product.ProductId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _currentShoppingCart.Items.Add(new ProductOrder { Product = product, Quantity = quantity });
            }

            OnShoppingCartChanged?.Invoke();
            message = $"{quantity} шт. продукта \"{product.Name}\" добавлено в корзину.";
            return true;
        }

        public void RemoveFromCart(int productId, int quantity, out string message)
        {
            if (_currentShoppingCart == null)
            {
                message = "Войдите в аккаунт, чтобы пользоваться корзиной";
                return;
            }

            ProductOrder existingItem = _currentShoppingCart.Items.Find(item => item.Product.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity -= quantity;

                if (existingItem.Quantity <= 0)
                {
                    _currentShoppingCart.Items.Remove(existingItem);
                    OnShoppingCartChanged?.Invoke();
                }
                message = $"{quantity} шт. продукта \"{existingItem.Product.Name}\" удалено из корзины.";
            }
            else
            {
                message = "Продукт с идентификатором {productId} не найден в корзине.";
            }
        }

        public double CalculateTotal()
        {
            return _currentShoppingCart.Items.Sum(item => item.Product.Price * item.Quantity);
        }
    }
}
