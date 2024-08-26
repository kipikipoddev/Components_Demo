namespace Step_3_Components;

public interface IRecharge_Component : IComponent
{
    void Recharge();
}

public static class Recharge_Component_Extension
{
    public static void Recharge(this IComponents components)
    {
        components.Get_Or_Default<IRecharge_Component>()?
            .Recharge();
    }
}