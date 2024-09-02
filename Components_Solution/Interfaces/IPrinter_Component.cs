namespace Components_Solution;

public interface IPrinter_Component : IComponent
{
    void Print_Action(string action);
    void Print_Cannot(string action);
}

public static class Printer_Component_Ext
{
    public static void Print_Action(this IComponents components, string action)
    {
        components.Get<IPrinter_Component>().Print_Action(action);
    }

    public static void Print_Cannot(this IComponents components, string action)
    {
        components.Get<IPrinter_Component>().Print_Cannot(action);
    }
}