

namespace Components_Better_Solution;

public class Action_Component : Component, IActions_Component, IHandler<Change_Action_Command>
{
    private readonly HashSet<Actions> actions = [];

    public IEnumerable<Actions> Actions => actions;

    public void Handle(Change_Action_Command cmd)
    {
        if (cmd.Is_Add)
            actions.Add(cmd.Action);
        else
            actions.Remove(cmd.Action);
    }
}