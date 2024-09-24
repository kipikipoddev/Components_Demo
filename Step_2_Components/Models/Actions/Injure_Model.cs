
namespace Step_2_Components;

public class Injure_Model : Action_Model, IInjure_Model
{
    private readonly IDisabled_Model disabled;

    public Injure_Model(IPrint_Model print_model, IDisabled_Model disabled) 
        : base(print_model)
    {
        this.disabled = disabled;
    }

    public bool Is_Injured { get; set; }

    public bool Can_Heal()
    {
        return Is_Injured;
    }

    public bool Can_Injured()
    {
        return !Is_Injured;
    }

    public void Heal()
    {
        if (Is_Injured)
        {
            Is_Injured = false;
            disabled.Is_Disabled = false;
            Print_Was(Actions_Description.Healed);
        }
        else
            Print_Cant(Actions.Heal);
    }

    public void Injured()
    {
        if (Is_Injured)
            Print_Cant(Actions.Injure);
        else
        {
            Is_Injured = true;
            disabled.Is_Disabled = true;
            Print_Was(Actions_Description.Injured);
        }
    }
}