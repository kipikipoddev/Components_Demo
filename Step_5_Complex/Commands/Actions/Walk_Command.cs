
namespace Step_5_Complex;

public class Walk_Command(IComponents components, Speed speed) : Action_Command(components)
{
    public override Actions Name => Actions.Walk;
    public override Actions Was => Actions.Walking;
    public Speed Speed { get; } = speed;
}