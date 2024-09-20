namespace Step_5_Final;

public interface IAction_Component : IComponent
{
    IEnumerable<Actions> Available_Actions { get; }
}

public static class Action_Component_Ext
{
    public static IEnumerable<Actions> Available_Actions(this IComponents components)
    {
        return components.Get_All<IAction_Component>().SelectMany(e => e.Available_Actions);
    }
}