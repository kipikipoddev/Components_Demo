
namespace Step_5_Complex;

public abstract class Action_Command(IComponents components)
    : Command(components)
{
    public abstract Actions Name { get; }
    public abstract Actions Was { get; }

    public override void Send()
    {
        if (Is_Valid())
            base.Send();
        else
            new Print_Command(components, Name, false);
    }
}