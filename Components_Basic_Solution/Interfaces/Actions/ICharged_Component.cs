
namespace Components_Basic_Solution;

public interface ICharged_Component : IComponent
{
    bool Is_Charged { get; set; }

    bool Can_Charge();
    void Charge();
}