
namespace Step_5_Final;

public interface IInjure_Component : IComponent
{
    bool Is_Injured { get; }

    bool Can_Injure();
    void Injure();

    bool Can_Heal();
    void Heal();
}