namespace Components_Solution;

public interface IName_Component : IComponent
{
    string Name { get; }
}

public static class IName_Component_Ext
{
    public static string Name(this IComponents components)
    {
        return components.Get<IName_Component>().Name;
    }
}