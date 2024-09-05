
namespace Step_5_Complex;

public abstract class Action_Command(IComponents components)
    : Command(components)
{
    public abstract Actions Name { get; }

    public override bool Send()
    {
        if (Is_Valid())
            return base.Send();
        new Print_Command(components, Name, false);
        return false;
    }
}