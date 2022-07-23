using Observer;

List<ConcreteObserver> concretes = new()
{
    new ConcreteObserver(),
    new ConcreteObserver(),
    new ConcreteObserver(),
    new ConcreteObserver()
};

void Print()
{
foreach(var concreteObserver in concretes)
    Console.WriteLine($"Name: {concreteObserver.ObserverName}\nValue: {concreteObserver.CurrentValue}\n");
}

Console.WriteLine("Before updtate subscribers info");
Print();

Observers observers = new();
foreach(var concreteObserver in concretes)
    observers.AddObserver(concreteObserver);
observers.UpdateObserverValue(10);


Console.WriteLine("After updtate subscribers info");
Print();
