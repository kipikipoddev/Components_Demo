using Step_4_Commands.Commands;

namespace Step_4_Commands.Sound_Handlers;

public class Robot_Injure_Handler : Handler<Injure_Command>
{
    public override void Handle(Injure_Command cmd)
    {
        if (Parent.Is_Injured())
            return;
        Parent.Write_Action("broken");
        var data = Parent.Get<Data_Component>();
        data.Is_Injured = true;
    }
}