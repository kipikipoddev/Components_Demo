namespace Components_Solution;

public class Change_Actions_Command : Command
{
    public Actions Action { get; }
    public bool Add { get; }

    public Change_Actions_Command(IComponents components, Actions action, bool add)
        : base(components)
    {
        Action = action;
        Add = add;
    }
}