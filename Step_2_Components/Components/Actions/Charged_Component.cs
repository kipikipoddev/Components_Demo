
namespace Step_2_Components;

public class Charged_Component : Component, ICharged_Component
{
    public bool Is_Charged { get; set; }

    public bool Can_Charge()
    {
        return !Is_Charged;
    }

    public void Charge()
    {
        if (Is_Charged)
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Charge);
        else
        {
            Is_Charged = true;
            Parent.Get<IDisabled_Component>().Is_Disabled = false;
            Parent.Get<IPrint_Component>().Print_Was(Actions.Charged);
        }
    }
}