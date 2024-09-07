
namespace Step_4_Files;

public class Walk_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Action => Actions.Walk;
}