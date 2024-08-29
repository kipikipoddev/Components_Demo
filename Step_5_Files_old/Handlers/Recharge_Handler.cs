using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Core;

namespace Step_5_Files;

[Generic_Component_Name("Recharge_Walk", typeof(Walk_Command))]
[Generic_Component_Name("Recharge_Sound", typeof(Make_Sound_Command))]
[Generic_Component_Name("Recharge_Swim", typeof(Swim_Command))]
public class Recharge_Handler<T> : Handler<T>
    where T : Command
{
    public override void Handle(T cmd)
    {
        Write("recharging");
    }
}