
namespace Step_2_Components;

public class Bark_Model : Action_Model, IBark_Model
{
    private readonly IDisabled_Model disabled;

    public Bark_Model(IPrint_Model print_Component, IDisabled_Model disabled) : base(print_Component)
    {
        this.disabled = disabled;
    }

    public void Bark()
    {
        if (Can_Bark())
            Print_Was(Actions_Description.Barking);
        else
            Print_Cant(Actions.Bark);
    }

    public virtual bool Can_Bark()
    {
        return !disabled.Is_Disabled;
    }
}