using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fried_Chicken.Models.Entity;
using SQLitePCL;
using Fried_Chicken.Adapters;
namespace Fried_Chicken.Services
{
    interface ICartService
    {
        List<CartItem> GetCart();// abtract method
        bool AddToCart(CartItem item);
        bool RemoveItem(CartItem item);
        bool UpdateItem(CartItem item, int newQty);
        bool ClearCart();
    }
    class CartService : ICartService
    {
        public bool AddToCart(CartItem item)
        {
            try
            {
                ISQLiteConnection connection = SQLiteHelper.GetInstance().SQLiteConnection;
                var sql_txt = "insert into Cart(Id, Name, Image, Price, Qty) values(?,?,?,?,?)";
                var statement = connection.Prepare(sql_txt);
                statement.Bind(1, item.Id);
                statement.Bind(2, item.Name);
                statement.Bind(3, item.Image);
                statement.Bind(4, item.Price);
                statement.Bind(5, item.Qty);
                var rs = statement.Step();
                return rs == SQLiteResult.OK;
                
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public bool ClearCart()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetCart()
        {
            throw new NotImplementedException();
        }

        public bool RemoveItem(CartItem item)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(CartItem item, int newQty)
        {
            throw new NotImplementedException();
        }
    }
}
