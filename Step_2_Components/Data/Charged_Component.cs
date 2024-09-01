namespace Components_Demo;

public class Charged_Component : Component
{
    public bool Is_Charged { get; }
}

public static class Charged_Component_Ext
{
    public static bool Is_Charged(this IComponents components)
    {
        return components.Get<Charged_Component>().Is_Charged;
    }
}