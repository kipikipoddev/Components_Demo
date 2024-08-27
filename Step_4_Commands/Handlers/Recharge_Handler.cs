using Step_4_Commands.Core;

namespace Step_4_Commands;

public class Recharge_Handler<T> : Handler<T>
    where T : Command
{
    public override void Handle(T cmd)
    {
        Write("recharging");
    }
}