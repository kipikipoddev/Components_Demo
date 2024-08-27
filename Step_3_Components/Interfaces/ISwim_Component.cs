namespace Step_3_Components;

public interface ISwim_Component : IComponent
{
    void Swim();
}

public static class Swim_Component_Extension
{
    public static void Swim_If_Can(this IComponents components)
    {
        components.Get_Or_Default<ISwim_Component>()?.Swim();
    }
}