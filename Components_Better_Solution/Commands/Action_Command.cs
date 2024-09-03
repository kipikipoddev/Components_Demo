
namespace Components_Better_Solution;

public abstract class Action_Command(IComponents components)
    : Command(components)
{
    protected abstract Actions Action { get; }

    public override void Send()
    {
        if (Is_Valid())
            base.Send();
        else
            new Print_Command(Components, Action, false);
    }
}