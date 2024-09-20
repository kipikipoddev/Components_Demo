namespace Step_4_Files;

public class Action_Component : Component
{
    protected bool Is_Disabled => Parent.Get<IDisabled_Component>().Is_Disabled;

    protected void Print_Was(Actions_Description action)
    {
        new Print_Was_Command(Parent, action);
    }

    protected void Print_Cant(Actions action)
    {
        new Print_Cant_Command(Parent, action);
    }
}