namespace Components_Demo;

public class Injure_Component : Component
{
    public bool Is_Injured { get; }
}

public static class Injure_Component_Ext
{
    public static bool Is_Injured(this IComponents components)
    {
        return components.Get<Injure_Component>().Is_Injured;
    }
}