
namespace Step_2_Components;

public class Meow_Model : Action_Model, IMeow_Model
{
    private readonly IDisabled_Model disabled;

    public Meow_Model(IPrint_Model print_Component, IDisabled_Model disabled) : base(print_Component)
    {
        this.disabled = disabled;
    }

    public void Meow()
    {
        if (Can_Meow())
            Print_Was(Actions_Description.Meowing);
        else
            Print_Cant(Actions.Meow);
    }

    public virtual bool Can_Meow()
    {
        return !disabled.Is_Disabled;
    }
}