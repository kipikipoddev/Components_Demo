namespace Step_3_Components;

public class Charge_Component : Component, IRecharge_Component
{
    private bool is_charged;

    public void Recharge()
    {
        if (is_charged)
            return;
        Write("Recharging");
        is_charged = true;
        Write("Recharged");
    }
}