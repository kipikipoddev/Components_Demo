using Step_4_Mediator.Core;
using Step_4_Mediator.Sound_Handlers;

namespace Step_4_Mediator;

public class Recharge_Handler<T> : Handler<T>
    where T : Command
{
    public override void Handle(T cmd)
    {
        Write("recharging");
    }
}