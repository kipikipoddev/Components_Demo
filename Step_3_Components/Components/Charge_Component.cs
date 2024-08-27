namespace Step_3_Components;

public class Charge_Component : Component, IRecharge_Component
{
    public void Recharge()
    {
        Write("recharged");
    }
}