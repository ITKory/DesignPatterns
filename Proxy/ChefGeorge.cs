using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy;

public class ChefGeorge : StatusesDictionary ,IChef
{
    public string Name => "George";

    public List<Order> GetOrders()
    {
        List<Order> orders = new()
        {
            new Order(){ Name = "Burger", StatusId = new Random().Next(StatusesCount())},
            new Order(){ Name = "pasta carbonara", StatusId = new Random().Next(StatusesCount())},
            new Order(){ Name = "Cooke", StatusId = new Random().Next(StatusesCount())},
        };
        return orders;
    }

  
}
