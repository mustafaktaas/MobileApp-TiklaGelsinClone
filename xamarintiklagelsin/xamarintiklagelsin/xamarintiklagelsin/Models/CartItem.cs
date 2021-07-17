using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace xamarintiklagelsin.Models
{
    [Table("CartItem")]
    public class CartItem
    {
        [AutoIncrement,PrimaryKey]
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
