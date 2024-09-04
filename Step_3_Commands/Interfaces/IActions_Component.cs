namespace Step_3_Commands;

public interface IActions_Component : IComponent
{
    IEnumerable<Actions> Actions { get; }
}