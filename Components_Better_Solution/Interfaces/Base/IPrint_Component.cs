namespace Components_Better_Solution;

public interface IPrint_Component : IComponent
{
    void Print_Was(Actions action);
    void Print_Cant(Actions action);
}

public static class Print_Component_Ext
{
    public static void Print_Was(this IComponents components, Actions action)
    {
        components.Get<IPrint_Component>().Print_Was(action);
    }

    public static void Print_Cant(this IComponents components, Actions action)
    {
        components.Get<IPrint_Component>().Print_Cant(action);
    }
}