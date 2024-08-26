using Step_4_Mediator.Commands;
using Step_4_Mediator.Core;
using Step_4_Mediator.Interfaces;

namespace Step_4_Mediator;

public class Charge_Component : 
    Component, 
    IHandler<Recharge_Command>,
    ICharged_Component
{
    public bool Is_Charged { get; private set; }

    public void Handle(Recharge_Command evnt)
    {
        Write("Recharging");
        Is_Charged = true;
        Write("Recharged");
    }

    protected override void Parent_Set()
    {
        Mediator.Add(this, Parent);
    }
}