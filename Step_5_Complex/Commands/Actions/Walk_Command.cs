
namespace Step_5_Complex;

public class Walk_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Name => Actions.Walk;
    public override Actions Was => Actions.Walking;
}