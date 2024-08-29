using Step_3_Components.Enums;

namespace Step_3_Components;

public interface IData_Component : IComponent
{
    Speed Speed { get; }
    string Name { get; }
    Types Type { get; }
}

public static class Data_Extension
{
    public static Speed Speed(this IComponents components)
    {
        return components.Get<IData_Component>().Speed;
    }

    public static string Name(this IComponents components)
    {
        return components.Get<IData_Component>().Name;
    }

    public static Types Type(this IComponents components)
    {
        return components.Get<IData_Component>().Type;
    }
}