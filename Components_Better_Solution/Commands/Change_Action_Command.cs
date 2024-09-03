
namespace Components_Better_Solution;

public class Change_Action_Command : Command
{
    public Actions Action { get; }
    public bool Is_Add { get; }
    
    public Change_Action_Command(IComponents components, Actions action, bool is_add)
        : base(components)
    {
        Action = action;
        Is_Add = is_add;
    }
}