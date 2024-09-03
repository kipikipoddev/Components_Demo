
namespace Components_Better_Solution;

public abstract class Action_Command(IComponents components)
    : Command(components)
{
    public abstract Actions Name { get; }
    public abstract Actions Was { get; }
}