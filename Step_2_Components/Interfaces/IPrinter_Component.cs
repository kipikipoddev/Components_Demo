namespace Components_Demo;

public interface IPrinter_Component : IComponent
{
    void Print_Action(IAction_Component action);
    void Print_Cannot(IAction_Component action);
}

public static class Printer_Component_Ext
{
    public static void Print_Action(this IComponents components, IAction_Component action)
    {
        components.Get<IPrinter_Component>().Print_Action(action);
    }

    public static void Print_Cannot(this IComponents components, IAction_Component action)
    {
        components.Get<IPrinter_Component>().Print_Cannot(action);
    }
}