
namespace Step_5_Complex;

public class Print_Command : Command
{
    public Actions Action { get; }
    public bool Is_Was { get; }

    public Print_Command(IComponents components, Actions action, bool print_was)
        : base(components)
    {
        Action = action;
        Is_Was = print_was;
        Send();
    }
}