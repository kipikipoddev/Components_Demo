using Step_5_Files.Core;

namespace Step_5_Files.Interfaces;

public interface IName_Component : IComponent
{
    string Name { get; }
}

public static class Name_Component_Extension
{
    public static string Name(this IComponents components)
    {
        return components.Get<IName_Component>().Name;
    }
}