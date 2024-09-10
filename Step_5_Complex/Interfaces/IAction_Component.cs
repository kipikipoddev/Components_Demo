namespace Step_5_Complex;

public interface IAction_Component : IComponent
{
    IEnumerable<Actions> Actions_Handling { get; }
}