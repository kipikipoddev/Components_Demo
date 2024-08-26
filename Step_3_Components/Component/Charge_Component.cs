namespace Step_3_Components;

public class Charge_Component : Component, IRecharge_Component
{
    public bool Is_Charged { get; private set; }

    public void Recharge()
    {
        Write("Recharging");
        Is_Charged = true;
        Write("Recharged");
    }

    public void Recharge_If_Need()
    {
        if (!Is_Charged)
            Recharge();
    }
}

public static class Recharge_Component_Extension
{
    public static IRecharge_Component Charge(this IComponents components)
    {
        return components.Get<IRecharge_Component>();
    }
}