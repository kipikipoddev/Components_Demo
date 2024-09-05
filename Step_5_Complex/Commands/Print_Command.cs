
namespace Step_5_Complex;

public class Print_Command : Command
{
    public Actions Action { get; }
    public bool Is_Was { get; }
    public object? Description { get; }

    public Print_Command(IComponents components, Actions action, bool is_was, object? description = null)
        : base(components)
    {
        Action = action;
        Is_Was = is_was;
        Description = description;
        Send();
    }
}