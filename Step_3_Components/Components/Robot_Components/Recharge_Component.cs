namespace Step_3_Components;

public class Recharge_Component : Component
{
    public void Recharge()
    {
        Parent.Write_Action("recharging...");
        Parent.Write_Action("recharged");
        Parent.Remove(this);
    }
}