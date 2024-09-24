
namespace Step_2_Components;

public interface IInjure_Model
{
    bool Is_Injured { get; }

    bool Can_Injured();
    void Injured();
    bool Can_Heal();
    void Heal();
}