
namespace Proxy;
    public interface IChef
    {
        string Name { get; }
        IDictionary<int, string> GetStatuses();
        List<Order> GetOrders();


    }
