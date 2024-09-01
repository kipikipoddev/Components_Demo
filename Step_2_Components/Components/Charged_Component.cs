
namespace Components_Demo;

public class Charged_Component : Component, IHandler<Charge_Command>
{
    public bool Is_Charged { get; private set; }

    public void Handle(Charge_Command cmd, Action next)
    {
        Is_Charged = true;
    }
}

public static class Charged_Component_Ext
{
    public static bool Is_Charged(this IComponents components)
    {
        return components.Get<Charged_Component>().Is_Charged;
    }
}