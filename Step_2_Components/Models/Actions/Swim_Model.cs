
namespace Step_2_Components;

public class Swim_Model : Action_Model, ISwim_Model
{
    private readonly IDisabled_Model disabled;

    public Swim_Model(IPrint_Model print_Component, IDisabled_Model disabled) : base(print_Component)
    {
        this.disabled = disabled;
    }

    public void Swim()
    {
        if (Can_Swim())
            Print_Was(Actions_Description.Swiming);
        else
            Print_Cant(Actions.Swim);
    }

    public virtual bool Can_Swim()
    {
        return !disabled.Is_Disabled;
    }
}