namespace Components_Solution;

public class Action_Component : Component, IAction_Component, IHandler<Change_Actions_Command>
{
    public Actions Name { get; }

    public bool Is_Disabled { get; private set; }

    public Action_Component(Actions name)
    {

    }

    public void Handle(Change_Actions_Command cmd, Action next)
    {
        // if (cmd.Add)
        //      actions.Add(cmd.Action);
        //  else
        //     actions.Remove(cmd.Action);
    }
}