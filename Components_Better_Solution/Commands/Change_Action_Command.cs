
namespace Components_Better_Solution;

public class Change_Action_Command : Command
{
    public Actions[] Actions { get; }
    public bool Is_Add { get; }

    public Change_Action_Command(IComponents components, bool is_add, params Actions[] actions)
        : base(components)
    {
        Actions = actions;
        Is_Add = is_add;
    }
}