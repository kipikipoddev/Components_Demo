
namespace Step_2_Components;

public interface ICharged_Model
{
    bool Is_Charged { get; set; }

    bool Can_Charge();
    void Charge();
}