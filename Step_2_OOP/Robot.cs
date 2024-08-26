namespace Step_2_OOP;

public class Robot : Entity
{
    private bool is_charged;

    public override void Make_Sound()
    {
        Recharge();
        Write("Beeping");
    }

    public override void Walk()
    {
        Recharge();
        Write("Walking like a robot");
    }

    public void Recharge()
    {
        if (is_charged)
            return;
        Write("Recharging");
        is_charged = true;
        Write("Recharged");
    }
}