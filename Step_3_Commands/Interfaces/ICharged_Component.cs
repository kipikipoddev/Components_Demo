
namespace Step_3_Commands;

public interface ICharged_Component : IComponent
{
    bool Is_Charged { get; }
    bool Can_Charge();
    void Charge();
}