namespace Components_Demo;

public class Injure_Component
    : Component, IHandler<Injure_Command>, IHandler<Heal_Command>
{
    public bool Is_Injured { get; private set; }

    public void Handle(Injure_Command cmd)
    {
        if (Is_Injured)
            Parent.Print_Cannot(Actions.Injure);
        else
            Parent.Print_Action(Actions.Injured);
        Is_Injured = true;
    }

    public void Handle(Heal_Command cmd)
    {
        if (Is_Injured)
            Parent.Print_Action(Actions.Healed);
        else
            Parent.Print_Cannot(Actions.Heal);
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