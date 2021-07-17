using GraphqlTiklaGelsin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlTiklaGelsin.İService
{
    public interface IFoodService
    {
        List<FoodItems> GetFoodItems();
    }
}
