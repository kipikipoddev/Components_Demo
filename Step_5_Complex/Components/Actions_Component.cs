
namespace Step_5_Complex;

public class Actions_Component :
    Component,
    IActions_Component,
    IValidator<Action_Command>
{
    public Actions_Component()
    {
        Mediator.Add_Validator(this);
    }

    public IEnumerable<Actions> Available_Actions =>
        Parent.Get_All<IAction_Component>().SelectMany(c => c.Actions_Handling);

    public bool Is_Valid(Action_Command cmd)
    {
        return Available_Actions.Contains(cmd.Action);
    }
}