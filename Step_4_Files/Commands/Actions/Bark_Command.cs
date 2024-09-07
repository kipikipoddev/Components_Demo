
namespace Step_4_Files;

public class Bark_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Action => Actions.Bark;
}