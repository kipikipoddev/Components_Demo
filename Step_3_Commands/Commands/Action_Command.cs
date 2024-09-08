
namespace Step_3_Commands;

public abstract class Action_Command : Command
{
    public Action_Command(IComponents components)
        : base(components)
    {
    }

    public abstract Actions Action { get; }

    public override bool Send()
    {
        var is_success = base.Send();
        if (!is_success)
            new Print_Command(Components, Action, false);
        return is_success;
    }
}