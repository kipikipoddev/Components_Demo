namespace Step_3_Components;

public class Recharge_Component : Component, IRecharge_Component
{
    public bool Is_Recharged { get; set; }

    public void Recharge()
    {
        if (Is_Recharged)
            return;
        Parent.Write_Action("recharging...");
        Is_Recharged = true;
        Parent.Write_Action("recharged");
    }
}