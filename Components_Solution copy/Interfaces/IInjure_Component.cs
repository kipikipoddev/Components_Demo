
namespace Components_Solution;

public interface IInjure_Component : IComponent
{
    bool Is_Injured { get; }
}

public static class IInjure_Component_Ext
{
    public static bool Is_Injured(this IComponents components)
    {
        return components.Get<IInjure_Component>().Is_Injured;
    }
}