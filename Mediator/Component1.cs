

// Конкретные Посредники реализуют совместное поведение, координируя
// отдельные компоненты.
// Конкретные Компоненты реализуют различную функциональность. Они не
// зависят от других компонентов. Они также не зависят от каких-либо
// конкретных классов посредников.
class Component1 : BaseComponent
{
    public void DoA()
    {
        Console.WriteLine("Component 1 does A.");

        this._mediator.Notify(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Component 1 does B.");

        this._mediator.Notify(this, "B");
    }
}
