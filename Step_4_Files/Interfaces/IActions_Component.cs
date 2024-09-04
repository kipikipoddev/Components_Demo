namespace Step_4_Files;

public interface IActions_Component : IComponent
{
    IEnumerable<Actions> Actions { get; }
}