
namespace Step_5_Complex;

public interface ICharged_Component : IComponent
{
    int Charges { get; }
    int Max_Charges { get; }
    bool Has_Charge { get; }
}