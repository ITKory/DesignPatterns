

// Конкретные Посредники реализуют совместное поведение, координируя
// отдельные компоненты.
// Базовый Компонент обеспечивает базовую функциональность хранения
// экземпляра посредника внутри объектов компонентов.
class BaseComponent
{
    protected IMediator _mediator;

    public BaseComponent(IMediator mediator = null)
    {
        this._mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        this._mediator = mediator;
    }
}
