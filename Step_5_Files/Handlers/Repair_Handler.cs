namespace Step_5_Files.Sound_Handlers;

public class Repair_Handler<T> : Handler<T>
    where T : Command
{
    public override void Handle(T cmd)
    {
        var data = cmd.Components.Get<Data_Component>();
        if (!data.Is_Injured)
            return;
        Parent.Write_Action("repairing...");
        data.Is_Injured = false;
        Parent.Write_Action("repaired");
    }
}