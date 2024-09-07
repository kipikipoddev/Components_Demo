
namespace Step_3_Commands;

public class Print_Command : Command
{
    public Actions Actions { get; }
    public bool Is_Was { get; }

    public Print_Command(IComponents components, Actions actions, bool is_was) : base(components)
    {
        Actions = actions;
        Is_Was = is_was;
        Send();
    }
}