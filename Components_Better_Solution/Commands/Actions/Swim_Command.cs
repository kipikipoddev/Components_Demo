
namespace Components_Better_Solution;

public class Swim_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Name => Actions.Swim;
    public override Actions Was => Actions.Swiming;
}