namespace Step_4_Commands;

public class Recharge_Handler<T> : Handler<T>
    where T : Command
{
    public override void Handle(T cmd)
    {
        var comp = cmd.Components.Get<Recharge_Component>();
        if (comp.Is_Recharged)
            return;
        Parent.Write_Action("recharging...");
        comp.Is_Recharged = true;
        Parent.Write_Action("recharged");
    }
}