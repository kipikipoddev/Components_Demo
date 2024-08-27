using Step_5_Files.Core;

namespace Step_5_Files;

public class Name_Component : Component
{
    public string Name { get; }

    public Name_Component(string name)
    {
        Name = name;
    }
}

public static class Name_Component_Extension
{
    public static string Name(this IComponents components)
    {
        return components.Get<Name_Component>().Name;
    }
}