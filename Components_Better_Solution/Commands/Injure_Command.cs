
namespace Components_Better_Solution;

public class Injure_Command(IComponents components) 
    : Action_Command(components)
{
    protected override Actions Action => Actions.Injure;
}