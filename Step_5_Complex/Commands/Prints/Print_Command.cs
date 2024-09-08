
namespace Step_5_Complex;

public class Print_Action_Command : Command
{
    public Actions Action { get; }
    public bool Is_Was { get; }
    public Volume? Volume { get; }
    public Speed? Speed { get; }

    public Print_Action_Command(IComponents components, Actions action, bool is_was)
        : base(components)
    {
        Action = action;
        Is_Was = is_was;
        Send();
    }

    public Print_Action_Command(IComponents components, Actions action, bool is_was, Speed speed)
        : base(components)
    {
        Action = action;
        Is_Was = is_was;
        Speed = speed;
        Send();
    }

    public Print_Action_Command(IComponents components, Actions action, bool is_was, Volume volume)
    : base(components)
    {
        Action = action;
        Is_Was = is_was;
        Volume = volume;
        Send();
    }
}