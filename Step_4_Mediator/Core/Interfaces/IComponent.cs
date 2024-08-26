namespace Step_4_Mediator.Core;

public interface IComponent
{
    IComponents Parent { get; set; }

    void Write(string message);
}