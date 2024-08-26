namespace Step_3_Components;

public interface IRecharge_Component : IComponent
{
    bool Is_Charged { get; }

    void Recharge_If_Need();

    void Recharge();
}

public static class Recharge_Component_Extension
{
    public static void Recharge_If_Need(this IComponents components)
    {
        components.Get<IRecharge_Component>()?
            .Recharge_If_Need();
    }
}