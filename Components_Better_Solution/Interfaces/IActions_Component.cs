namespace Components_Better_Solution;

public interface IActions_Component : IComponent
{
    IEnumerable<Actions> Actions { get; }
}