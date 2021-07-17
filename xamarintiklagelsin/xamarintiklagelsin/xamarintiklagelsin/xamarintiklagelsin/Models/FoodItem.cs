using System;
using System.Collections.Generic;
using System.Text;

namespace xamarintiklagelsin.Models
{
    public class FoodItem
    {
        public int FoodItemID { get; set; }
        public string FoodItemName { get; set; }
        public decimal Price { get; set; }
        public int Rating {get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public int RestaurantID { get; set; }


    }
}
