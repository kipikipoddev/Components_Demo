
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
            Parent.Get<IPrint_Component>().Print_Was(Actions.Healed);
        else
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Heal);

        Is_Injured = false;
    }

    public void Injured()
    {
        if (Is_Injured)
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Injured);
        else
            Parent.Get<IPrint_Component>().Print_Was(Actions.Injure);

        Is_Injured = true;
    }
}