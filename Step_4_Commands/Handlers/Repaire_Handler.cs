using Step_4_Commands.Commands;

namespace Step_4_Commands.Sound_Handlers;

public class Repaire_Handler : Handler<Repaire_Command>
{
    public override void Handle(Repaire_Command cmd)
    {
        var data = cmd.Components.Get<Data_Component>();
        if (!data.Is_Injured)
            return;
        Parent.Write_Action("repairing...");
        data.Is_Injured = false;
        Parent.Write_Action("repaired");
    }
}