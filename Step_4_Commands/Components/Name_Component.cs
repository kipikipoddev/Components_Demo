using Step_4_Commands.Core;

namespace Step_4_Commands;

public class Name_Component : Component
{
    public string Name { get; private set; }

    protected override void Parent_Set()
    {
        Name = Parent!.GetType().Name;
    }
}

public static class Name_Component_Extension
{
    public static string Name(this IComponents components)
    {
        return components.Get<Name_Component>().Name;
    }
}