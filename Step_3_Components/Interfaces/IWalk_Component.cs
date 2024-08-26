namespace Step_3_Components;

public interface IWalk_Component : IComponent
{
    void Walk();
}

public static class Walk_Component_Extension
{
    public static void Walk(this IComponents components)
    {
        components.Get<IWalk_Component>().Walk();
    }
}