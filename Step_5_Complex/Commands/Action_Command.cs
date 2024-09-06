
namespace Step_5_Complex;

public abstract class Action_Command : Command
{
    public Action_Command(IComponents components)
        : base(components)
    {
    }

    public abstract Actions Name { get; }

    public override bool Send()
    {
        var is_valid = base.Send();
        if (!is_valid)
            new Print_Cant_Command(Components, Name);
        return is_valid;
    }
}