namespace Step_5_Complex;

public interface IActions_Component : IComponent
{
    IEnumerable<Actions> Actions { get; }
}