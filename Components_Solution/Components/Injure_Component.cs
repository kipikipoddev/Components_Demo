
namespace Components_Solution;

public class Injure_Component
    : Component, IInjure_Component, IHandler<Injure_Command>, IHandler<Heal_Command>
{
    public bool Is_Injured { get; private set; }

    public void Handle(Injure_Command cmd)
    {
        Is_Injured = true;
    }

    public void Handle(Heal_Command cmd)
    {
        Is_Injured = false;
    }
}