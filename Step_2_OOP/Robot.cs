namespace Step_2_OOP;

public class Robot : Entity
{
    private bool is_charged;

    public override void Make_Sound()
    {
        Recharge_If_Need();
        Write("Beeping");
    }

    public void Recharge()
    {
        Write("Recharging");
        is_charged = true;
        Write("Recharged");
    }

    public override void Walk()
    {
        Recharge_If_Need();
        Write("Walking like a robot");
    }

    protected void Recharge_If_Need()
    {
        if (!is_charged)
            Recharge();
    }
}