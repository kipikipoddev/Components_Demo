
namespace Step_2_Components;

public class Injure_Component : Component, IInjure_Component
{
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
            Parent.Get<IDisabled_Component>().Is_Disabled = false;
            Parent.Get<IPrint_Component>().Print_Was(Actions.Healed);
        }
        else
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Heal);
    }

    public void Injured()
    {
        if (Is_Injured)
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Injured);
        else
        {
            Is_Injured = true;
            Parent.Get<IDisabled_Component>().Is_Disabled = true;
            Parent.Get<IPrint_Component>().Print_Was(Actions.Injure);
        }
    }
}