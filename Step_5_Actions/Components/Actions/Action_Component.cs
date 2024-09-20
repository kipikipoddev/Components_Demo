namespace Step_5_Actions;

public abstract class Action_Component : Component, IAction_Component
{
    protected bool Is_Disabled => Parent.Get<IDisabled_Component>().Is_Disabled;
    public abstract IEnumerable<Actions> Available_Actions { get; }

    protected void Print_Was(Actions_Description action)
    {
        new Print_Was_Command(Parent, action);
    }

    protected void Print_Cant(Actions action)
    {
        new Print_Cant_Command(Parent, action);
    }
}