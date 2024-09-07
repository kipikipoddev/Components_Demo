
namespace Step_3_Commands;

public class Bark_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Action => Actions.Bark;
}