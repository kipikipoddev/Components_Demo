
namespace Step_3_Commands;

public class Meow_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Action => Actions.Meow;
}