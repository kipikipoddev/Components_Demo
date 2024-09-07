
namespace Step_5_Complex;

public abstract class Action_Command : Command
{
    public Action_Command(IComponents components)
        : base(components)
    {
    }

    public abstract Actions Action { get; }

    public override bool Send()
    {
        var is_valid = base.Send();
        if (!is_valid)
            Print_Cant();
        return is_valid;
    }

    protected void Print_Cant()
    {
        new Print_Action_Command(Components, Action, false);
    }
}