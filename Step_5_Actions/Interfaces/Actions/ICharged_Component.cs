
namespace Step_5_Final;

public interface ICharged_Component : IComponent
{
    bool Is_Charged { get; }
    bool Can_Charge();
    void Charge();
}