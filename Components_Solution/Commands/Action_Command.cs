namespace Components_Solution;

public abstract class Action_Command : Command
{
    public Action_Command(IComponents components)
        : base(components)
    {
    }
}