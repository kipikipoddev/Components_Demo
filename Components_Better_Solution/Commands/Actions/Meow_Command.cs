
namespace Components_Better_Solution;

public class Meow_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Name => Actions.Meow;
    public override Actions Was => Actions.Meowing;
}