namespace Step_4_Commands.Core;

public interface IComponent
{
    IComponents Parent { get; set; }

    void Write(string message);
}