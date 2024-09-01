namespace Components_Demo;

public class Name_Component(string name) : Component
{
    public string Name { get; } = name;
}

public static class Name_Component_Ext
{
    public static string Name(this IComponents components)
    {
        return components.Get<Name_Component>().Name;
    }
}