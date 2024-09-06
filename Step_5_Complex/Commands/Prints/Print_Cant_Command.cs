
namespace Step_5_Complex;

public class Print_Cant_Command : Command
{
    public Actions Action { get; }

    public Print_Cant_Command(IComponents components, Actions action)
        : base(components)
    {
        Action = action;
        Send();
    }
}