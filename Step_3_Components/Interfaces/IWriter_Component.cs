namespace Step_3_Components;

public interface IWriter_Component : IComponent
{
    void Write_Actions();
    void Write_Action(string action);
    void Write_Action_Like(string action);
    void Write_Cannot(string action);
}

public static class Writer_Extnsion
{
    public static void Write_Actions(this IComponents components)
    {
        components.Get<IWriter_Component>().Write_Actions();
    }

    public static void Write_Action(this IComponents components, string action)
    {
        components.Get<IWriter_Component>().Write_Action(action);
    }

    public static void Write_Action_Like(this IComponents components, string action)
    {
        components.Get<IWriter_Component>().Write_Action_Like(action);
    }

    public static void Write_Cannot(this IComponents components, string action)
    {
        components.Get<IWriter_Component>().Write_Cannot(action);
    }
}