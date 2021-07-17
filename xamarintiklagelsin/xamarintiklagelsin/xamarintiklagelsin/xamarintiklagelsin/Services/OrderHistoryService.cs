using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using xamarintiklagelsin.Models;

namespace xamarintiklagelsin.Services
{
    public class OrderHistoryService
    {
        FirebaseClient client;
        List<OrdersHistory> UserOrders;
        public OrderHistoryService()
        {
            client = new FirebaseClient("https://xamarintiklagelsin-a4de1-default-rtdb.firebaseio.com/");
            UserOrders = new List<OrdersHistory>();
        }

        public async Task<List<OrdersHistory>> GetOrderDetailsAsync()
        {
            var uname = Preferences.Get("Username", "Guest");

            var orders = (await client.Child("Orders").
                OnceAsync<Order>()).
                Where(o => o.Object.Username.Equals(uname)).
                Select(o => new Order()
                {
                    OrderId = o.Object.OrderId,
                    ReceiptId = o.Object.ReceiptId,
                    TotalCost = o.Object.TotalCost
                }).ToList();
            foreach (var order in orders)
            {
                OrdersHistory oh = new OrdersHistory();
                oh.OrderId = order.OrderId;
                oh.ReceiptId = order.ReceiptId;
                oh.TotalCost = order.TotalCost;

                var orderDetails = (await client.Child("OrderDetails").
                OnceAsync<OrderDetails>()).
                Where(o => o.Object.OrderId.Equals(order.OrderId)).
                Select(o => new OrderDetails()
                {
                    OrderId = o.Object.OrderId,
                    OrderDetailId = o.Object.OrderDetailId,
                    ProductID = o.Object.ProductID,
                    ProductName = o.Object.ProductName,
                    Quantity = o.Object.Quantity,
                    Price = o.Object.Price
                }).ToList();

                oh.AddRange(orderDetails);

                UserOrders.Add(oh);
            }
            return UserOrders;
        }
    }
}
