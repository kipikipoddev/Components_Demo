using Step_4_Mediator.Core;

namespace Step_4_Mediator.Interfaces;

public interface ICharged_Component : IComponent
{
    bool Is_Charged { get; }
}

public static class Charged_Component_Extension
{
    public static bool Charged(this IComponents components)
    {
        return components.Get<ICharged_Component>().Is_Charged;
    }
}