
namespace Step_3_Commands;

public record Swim_Command(IComponents components) : Action_Command(components)
{
    public override Actions Name => Actions.Swim;
    public override Actions_Description Action => Actions_Description.Swiming;
}