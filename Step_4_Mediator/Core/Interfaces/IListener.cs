namespace Step_4_Mediator.Core;

public interface IListener<TEvent>
    where TEvent : Event
{
    void Handle(TEvent evnt);
}