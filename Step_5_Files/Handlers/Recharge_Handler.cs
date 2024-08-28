using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Core;

namespace Step_5_Files;

[Component_Name("", "Recharge")]
public class Recharge_Handler : Handler<Make_Sound_Command>
{
    public override void Handle(Make_Sound_Command cmd)
    {
        Recharge();
    }

    private void Recharge()
    {
        Write("recharging");
    }
}