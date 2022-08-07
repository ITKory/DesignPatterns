namespace Proxy;
public class ChefHermes: StatusesDictionary, IChef
{
    public string Name => "Hermes";

    public List<Order> GetOrders()
    {
        List<Order> orders = new()
        {
            new Order(){ Name = "Bolognese", StatusId = new Random().Next(1,4)},
            new Order(){ Name = "Greek salad", StatusId = new Random().Next(1,4)},
            new Order(){ Name = "pizza", StatusId = new Random().Next(1,4)},
        };
        return orders;
    }
}
