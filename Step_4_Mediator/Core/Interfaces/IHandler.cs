namespace Step_4_Mediator.Core;

public interface IHandler<TEvent>
    where TEvent : Event
{
    void Handle(TEvent evnt);
}