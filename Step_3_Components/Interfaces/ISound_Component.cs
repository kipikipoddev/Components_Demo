namespace Step_3_Components;

public interface ISound_Component : IComponent
{
    void Make_Sound();
}

public static class Sound_Component_Extension
{
    public static void Make_Sound(this IComponents components)
    {
        components.Get<ISound_Component>().Make_Sound();
    }
}