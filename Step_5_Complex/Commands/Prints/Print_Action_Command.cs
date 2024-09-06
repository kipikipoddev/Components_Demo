
namespace Step_5_Complex;

public class Print_Action_Command : Command
{
    public Actions Action { get; }
    public Volume? Volume { get; }
    public Speed? Speed { get; }

    public Print_Action_Command(IComponents components, Actions action)
        : base(components)
    {
        Action = action;
        Send();
    }

    public Print_Action_Command(IComponents components, Actions action, Speed speed)
        : base(components)
    {
        Action = action;
        Speed = speed;
        Send();
    }

    public Print_Action_Command(IComponents components, Actions action, Volume volume)
    : base(components)
    {
        Action = action;
        Volume = volume;
        Send();
    }
}