
namespace Step_2_Components;

public class Charged_Component : Action_Model, ICharged_Model
{
    private readonly IDisabled_Model disabled;

    public Charged_Component(IPrint_Model print_model, IDisabled_Model disabled) : base(print_model)
    {
        this.disabled = disabled;
    }

    public bool Is_Charged { get; set; }

    public bool Can_Charge()
    {
        return !Is_Charged;
    }

    public void Charge()
    {
        if (Is_Charged)
            Print_Cant(Actions.Charge);
        else
        {
            Is_Charged = true;
            disabled.Is_Disabled = false;
            Print_Was(Actions_Description.Charged);
        }
    }
}