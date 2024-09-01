
namespace Components_Demo;

public interface ICharged_Component : IComponent
{
    bool Is_Charged { get; }
}

public static class ICharged_Component_Ext
{
    public static bool Is_Charged(this IComponents components)
    {
        return components.Get<ICharged_Component>().Is_Charged;
    }
}