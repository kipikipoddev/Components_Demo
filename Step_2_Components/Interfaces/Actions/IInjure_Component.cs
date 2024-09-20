
namespace Step_2_Components;

public interface IInjure_Component : IComponent
{
    bool Is_Injured { get; }

    bool Can_Injured();
    void Injured();
    bool Can_Heal();
    void Heal();
}