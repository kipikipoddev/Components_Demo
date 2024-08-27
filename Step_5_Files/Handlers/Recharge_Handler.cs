using Step_5_Files.Attributes;
using Step_5_Files.Core;

namespace Step_5_Files.Handlers;

[Component_Name("Recharge")]
public class Recharge_Handler : Component, IHandler
{
    protected override void Parent_Set()
    {
        Mediator.Add(this, Parent);
    }

    public void Handle(Event evnt)
    {
        Write("recharging");
    }
}