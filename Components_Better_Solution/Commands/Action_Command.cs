
namespace Components_Better_Solution;

public abstract class Action_Command : Command
{
    protected abstract Actions Action { get; }

    public Action_Command(IComponents components)
        : base(components)
    {
    }

    protected override void Send<T>(T cmd)
    {
        if (cmd.Is_Valid())
            base.Send(cmd);
        else
            cmd.Components.Print_Cant(Action);
    }
}