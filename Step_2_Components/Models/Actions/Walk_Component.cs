
namespace Step_2_Components;

public class Walk_Model : Action_Model, IWalk_Model
{
    private readonly IDisabled_Model disabled;

    public Walk_Model(IPrint_Model print_Component, IDisabled_Model disabled) : base(print_Component)
    {
        this.disabled = disabled;
    }

    public void Walk()
    {
        if (Can_Walk())
            Print_Was(Actions_Description.Walking);
        else
            Print_Cant(Actions.Walk);
    }

    public virtual bool Can_Walk()
    {
        return !disabled.Is_Disabled;
    }
}