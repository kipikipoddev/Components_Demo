
namespace Step_3_Commands;

public record Walk_Command(IComponents components) : Action_Command(components)
{
    public override Actions Name => Actions.Walk;
    public override Actions_Description Action => Actions_Description.Walking;
}