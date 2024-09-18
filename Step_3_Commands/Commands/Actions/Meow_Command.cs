
namespace Step_3_Commands;

public record Meow_Command(IComponents components) : Action_Command(components)
{
    public override Actions Name => Actions.Meow;
    public override Actions_Description Action => Actions_Description.Meowing;
}