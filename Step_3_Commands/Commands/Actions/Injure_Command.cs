
namespace Step_3_Commands;

public record Injure_Command(IComponents components) : Action_Command(components)
{
    public override Actions Name => Actions.Injure;
    public override Actions_Description Action => Actions_Description.Injured;
}