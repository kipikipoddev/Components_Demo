namespace Step_3_Components;

public interface IInjure_Component : IComponent
{
    bool Is_Injured { get; set; }
}

public static class Injure_Extension
{
    public static IInjure_Component Injure(this IComponents components)
    {
        return components.Get<IInjure_Component>();
    }
}