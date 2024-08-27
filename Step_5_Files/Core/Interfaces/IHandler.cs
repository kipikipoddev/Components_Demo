namespace Step_5_Files.Core;

public interface IHandler<TEvent>
    where TEvent : Event
{
    void Handle(TEvent evnt);
}