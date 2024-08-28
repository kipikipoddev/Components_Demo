namespace Step_3_Components;

public interface IRecharge_Component : IComponent
{
    bool Is_Recharged { get; }
    void Recharge();
}

public static class Recharge_Extension
{
    public static void Recharge(this IComponents components)
    {
        components.Get<IRecharge_Component>().Recharge();
    }

    public static bool Is_Recharged(this IComponents components)
    {
        return components.Get<IRecharge_Component>().Is_Recharged;
    }
}