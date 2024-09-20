
namespace Step_6_Validation;

public interface ICharged_Component : IAction_Component
{
    bool Is_Charged { get; }
    bool Can_Charge();
    void Charge();
}