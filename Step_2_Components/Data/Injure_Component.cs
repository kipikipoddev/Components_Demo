namespace Components_Demo;

public class Injure_Component
    : Component, IHandler<Injure_Command>, IHandler<Heal_Command>
{
    public bool Is_Injured { get; private set; }

    public bool Is_Valid(Injure_Command cmd)
    {
        return !Is_Injured;
    }

    public void Handle(Injure_Command cmd)
    {
        Is_Injured = true;
    }

    public bool Is_Valid(Heal_Command cmd)
    {
        return Is_Injured;
    }

    public void Handle(Heal_Command cmd)
    {
        Is_Injured = false;
    }
}

public static class Injure_Component_Ext
{
    public static bool Is_Injured(this IComponents components)
    {
        return components.Get<Injure_Component>().Is_Injured;
    }
}