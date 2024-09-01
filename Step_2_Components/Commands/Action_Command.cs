namespace Components_Demo;

public abstract class Action_Command(IComponents components)
    : Command(components)
{
    public abstract Actions Name { get; }
}
