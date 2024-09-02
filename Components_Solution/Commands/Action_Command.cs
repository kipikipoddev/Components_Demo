namespace Components_Solution;

public abstract class Action_Command : Command
{
    public abstract Actions Name { get; }
    public abstract Actions Did { get; }

    public Action_Command(IComponents components)
        : base(components)
    {
    }
}