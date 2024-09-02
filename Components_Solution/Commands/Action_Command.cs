namespace Components_Solution;

public abstract class Action_Command : Command
{
    public abstract string Name { get; }
    public abstract string Did { get; }

    public Action_Command(IComponents components)
        : base(components)
    {
    }
}