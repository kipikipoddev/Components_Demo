namespace Step_3_Components;

public interface IWalk_Component : IComponent
{
    void Walk();
}

public static class Walk_Component_Extension
{
    public static void Walk_If_Can(this IComponents components)
    {
        components.Get_Or_Default<IWalk_Component>()?.Walk();
    }
}