using Proxy;

IChef chef ;

static void Print(IChef chef)
{
    Console.WriteLine($"|||{chef.Name} Orders|||");
    List<Order> orders = chef.GetOrders();
    foreach (Order order in orders)
    {
        //Database query emulation
        string status = chef.GetStatuses().First(s => s.Key == order.StatusId).Value;
        Console.WriteLine($"{order.Name} :: {status}");
    }
    Console.WriteLine();
}


while (true)
{
    Thread.Sleep(4000);
    Console.Clear();
    //with Proxy
    chef = new ChefProxy(new ChefHermes());
    Print(chef);    
    chef = new ChefProxy(new ChefGeorge());
    Print(chef);


    //Withhout Proxy
    chef = new ChefHermes();
    Print(chef);
    chef = new ChefGeorge();
    Print(chef);

}