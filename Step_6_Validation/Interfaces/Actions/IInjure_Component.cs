
namespace Step_6_Validation;

public interface IInjure_Component : IAction_Component
{
    bool Is_Injured { get; }

    bool Can_Injure();
    void Injure();

    bool Can_Heal();
    void Heal();
}