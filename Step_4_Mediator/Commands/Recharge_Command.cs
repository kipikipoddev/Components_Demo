using Step_4_Mediator.Core;
using Step_4_Mediator.Interfaces;

namespace Step_4_Mediator.Commands;

public record Recharge_Command : Command
{
    public Recharge_Command(IComponents component)
        : base(component, false)
    {
        if (!component.Charged())
            Send();
    }
}