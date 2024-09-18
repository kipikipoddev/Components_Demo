
namespace Step_3_Commands;

public record Bark_Command(IComponents components) : Action_Command(components)
{
    public override Actions Name => Actions.Bark;
    public override Actions_Description Action => Actions_Description.Barking;
}