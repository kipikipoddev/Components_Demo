namespace Step_3_Components;

public interface ISwim_Component : IComponent
{
    void Swim();
}

public static class Swim_Extnsion
{
    public static bool Can_Swim(this IComponents components)
    {
        return components.Has<ISwim_Component>();
    }

    public static void Swim(this IComponents components)
    {
        if (components.Has<ISwim_Component>())
            components.Get<ISwim_Component>().Swim();
        else
            components.Write_Cannot("swim");
    }
}