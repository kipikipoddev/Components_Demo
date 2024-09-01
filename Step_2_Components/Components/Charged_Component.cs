
namespace Components_Demo;

public class Charged_Component : Component, ICharged_Component, IHandler<Charge_Command>
{
    public bool Is_Charged { get; private set; }

    public void Handle(Charge_Command cmd, Action next)
    {
        Is_Charged = true;
    }
}