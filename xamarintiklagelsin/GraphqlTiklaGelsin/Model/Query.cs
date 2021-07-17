using GraphqlTiklaGelsin.İService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlTiklaGelsin.Model
{
    public class Query
    {
        IFoodService _foodService = null;

        public Query(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public List<FoodItems> FoodItems => _foodService.GetFoodItems();
    }
}
