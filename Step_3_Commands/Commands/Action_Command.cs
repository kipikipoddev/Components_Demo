
namespace Step_3_Commands;

public abstract record Action_Command(IComponents components) : Command(components)
{
    public abstract Actions Name { get; }
    public abstract Actions_Description Action { get; }
}