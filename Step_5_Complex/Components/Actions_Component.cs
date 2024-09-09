
namespace Step_5_Complex;

public class Actions_Component : Component, IActions_Component, IHandler<Change_Action_Command>
{
    private readonly HashSet<Actions> actions;

    public Actions_Component()
    {
        Mediator.Add_Handler(this);
        actions = [];
    }

    public void Handle(Change_Action_Command cmd)
    {
        if (cmd.Is_Add)
            actions.Add(cmd.Action);
        else
            actions.Remove(cmd.Action);
    }

    public IEnumerable<Actions> Actions => actions;
}