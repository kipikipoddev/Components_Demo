using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Core;
using Step_5_Files.Interfaces;

namespace Step_5_Files;

[Component_Name("Charge")]
public class Charge_Component :
    Component,
    IHandler<Recharge_Command>,
    ICharged_Component
{
    public bool Is_Charged { get; private set; }

    public void Handle(Recharge_Command evnt)
    {
        Write("recharging");
        Is_Charged = true;
        Write("recharged");
    }

    protected override void Parent_Set()
    {
        Mediator.Add(this, Parent);
    }
}