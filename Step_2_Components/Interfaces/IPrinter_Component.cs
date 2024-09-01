namespace Components_Demo;

public interface IPrinter_Component : IComponent
{
    void Print_Action(Actions action);
    void Print_Cannot(Actions action);
}

public static class Printer_Component_Ext
{
    public static void Print_Action(this IComponents components, Actions action)
    {
        components.Get<IPrinter_Component>().Print_Action(action);
    }

    public static void Print_Cannot(this IComponents components, Actions action)
    {
        components.Get<IPrinter_Component>().Print_Cannot(action);
    }
}