namespace Step_3_Components;

public interface ISound_Component : IComponent
{
    void Make_Sound();
}

public static class Sound_Extnsion
{
    public static bool Can_Make_Sound(this IComponents components)
    {
        return components.Has<ISound_Component>();
    }

    public static void Make_Sound(this IComponents components)
    {
        if (components.Has<ISound_Component>())
            components.Get<ISound_Component>().Make_Sound();
        else
            components.Write_Cannot("make sound");
    }
}