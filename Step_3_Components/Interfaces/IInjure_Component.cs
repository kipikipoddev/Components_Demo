namespace Step_3_Components;

public interface IInjure_Component : IComponent
{
    bool Is_Injured { get; set; }

    void Injure();
}

public static class Injure_Extension
{
    public static void Injure(this IComponents components)
    {
        components.Get<IInjure_Component>().Injure();
    }

    public static bool Is_Injured(this IComponents components)
    {
        return components.Get<IInjure_Component>().Is_Injured;
    }
}