namespace Step_3_Components;

public class Name_Component : Component, IName_Component
{
    public string Name { get; private set; }

    protected override void Parent_Set()
    {
        Name = Parent!.GetType().Name.Replace('_', ' ');
    }
}

public static class Name_Component_Extension
{
    public static string Name(this IComponents components)
    {
        return components.Get<IName_Component>().Name;
    }
}