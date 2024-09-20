
namespace Step_4_Files;

public interface IInjure_Component : IComponent
{
    bool Is_Injured { get; }

    bool Can_Injure();
    void Injure();

    bool Can_Heal();
    void Heal();
}