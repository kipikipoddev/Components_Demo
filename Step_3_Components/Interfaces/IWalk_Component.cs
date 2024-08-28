namespace Step_3_Components;

public interface IWalk_Component : IComponent
{
    void Walk();
}

public static class Walk_Extnsion
{
    public static bool Can_Walk(this IComponents components)
    {
        return components.Has<IWalk_Component>();
    }

    public static void Walk(this IComponents components)
    {
        if (components.Has<IWalk_Component>())
            components.Get<IWalk_Component>().Walk();
        else
            components.Write_Cannot("walk");
    }
}